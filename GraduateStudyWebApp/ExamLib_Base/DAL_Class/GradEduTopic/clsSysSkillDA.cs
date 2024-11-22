
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSkillDA
 表名:SysSkill(01120646)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 技能表(SysSkill)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSysSkillDA : clsCommBase4DA
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
 return clsSysSkillEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSysSkillEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysSkillEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSysSkillEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSysSkillEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:SysSkill中,检查关键字,长度不正确!(clsSysSkillDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strSkillId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SysSkill中,关键字不能为空 或 null!(clsSysSkillDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSkillId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSysSkillDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from SysSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SysSkill(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSysSkillDA: GetDataTable_SysSkill)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from SysSkill where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from SysSkill where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSysSkillDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSkill where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSkill where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSysSkillDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SysSkill where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSysSkillDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysSkill.* from SysSkill Left Join {1} on {2} where {3} and SysSkill.SkillId not in (Select top {5} SysSkill.SkillId from SysSkill Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSkill where {1} and SkillId not in (Select top {2} SkillId from SysSkill where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSkill where {1} and SkillId not in (Select top {3} SkillId from SysSkill where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSysSkillDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysSkill.* from SysSkill Left Join {1} on {2} where {3} and SysSkill.SkillId not in (Select top {5} SysSkill.SkillId from SysSkill Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSkill where {1} and SkillId not in (Select top {2} SkillId from SysSkill where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSkill where {1} and SkillId not in (Select top {3} SkillId from SysSkill where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSysSkillEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSysSkillDA:GetObjLst)", objException.Message));
}
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from SysSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = TransNullToBool(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysSkillDA: GetObjLst)", objException.Message));
}
objSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysSkillEN);
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
public List<clsSysSkillEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSysSkillDA:GetObjLstByTabName)", objException.Message));
}
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = TransNullToBool(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysSkillDA: GetObjLst)", objException.Message));
}
objSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysSkillEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSysSkillEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSysSkill(ref clsSysSkillEN objSysSkillEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from SysSkill where SkillId = " + "'"+ objSysSkillEN.SkillId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSysSkillEN.SkillId = objDT.Rows[0][conSysSkill.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objSysSkillEN.SkillName = objDT.Rows[0][conSysSkill.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objSysSkillEN.OperationTypeId = objDT.Rows[0][conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objSysSkillEN.Process = objDT.Rows[0][conSysSkill.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objSysSkillEN.LevelId = objDT.Rows[0][conSysSkill.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objSysSkillEN.UpdUser = objDT.Rows[0][conSysSkill.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSkillEN.UpdDate = objDT.Rows[0][conSysSkill.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSkillEN.IsSubmit = TransNullToBool(objDT.Rows[0][conSysSkill.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objSysSkillEN.CitationId = objDT.Rows[0][conSysSkill.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objSysSkillEN.OkCount = TransNullToInt(objDT.Rows[0][conSysSkill.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conSysSkill.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillEN.Score = TransNullToFloat(objDT.Rows[0][conSysSkill.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objSysSkillEN.StuScore = TransNullToFloat(objDT.Rows[0][conSysSkill.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objSysSkillEN.TeaScore = TransNullToFloat(objDT.Rows[0][conSysSkill.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objSysSkillEN.IdCurrEduCls = objDT.Rows[0][conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objSysSkillEN.PdfContent = objDT.Rows[0][conSysSkill.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objSysSkillEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillEN.CitationCount = TransNullToInt(objDT.Rows[0][conSysSkill.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillEN.VersionCount = TransNullToInt(objDT.Rows[0][conSysSkill.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillEN.Memo = objDT.Rows[0][conSysSkill.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objSysSkillEN.CreateDate = objDT.Rows[0][conSysSkill.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSkillEN.ShareId = objDT.Rows[0][conSysSkill.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSysSkillDA: GetSysSkill)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSkillId">表关键字</param>
 /// <returns>表对象</returns>
public clsSysSkillEN GetObjBySkillId(string strSkillId)
{
CheckPrimaryKey(strSkillId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from SysSkill where SkillId = " + "'"+ strSkillId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
 objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSysSkillDA: GetObjBySkillId)", objException.Message));
}
return objSysSkillEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSysSkillEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSysSkillDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from SysSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN()
{
SkillId = objRow[conSysSkill.SkillId].ToString().Trim(), //技能Id
SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(), //技能名称
OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(), //操作类型ID
Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(), //实施过程
LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(), //级别Id
UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(), //修改日期
IsSubmit = TransNullToBool(objRow[conSysSkill.IsSubmit].ToString().Trim()), //是否提交
CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(), //引用Id
OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.OkCount].ToString().Trim()), //点赞统计
AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.Score].ToString().Trim()), //评分
StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.VersionCount].ToString().Trim()), //版本统计
Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(), //备注
CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim() //分享Id
};
objSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSkillEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSysSkillDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSysSkillEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = TransNullToBool(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSysSkillDA: GetObjByDataRowSysSkill)", objException.Message));
}
objSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSkillEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSysSkillEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = TransNullToBool(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSysSkillDA: GetObjByDataRow)", objException.Message));
}
objSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSkillEN;
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
objSQL = clsSysSkillDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysSkillEN._CurrTabName, conSysSkill.SkillId, 10, "");
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
objSQL = clsSysSkillDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysSkillEN._CurrTabName, conSysSkill.SkillId, 10, strPrefix);
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
 objSQL = clsSysSkillDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SkillId from SysSkill where " + strCondition;
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
 objSQL = clsSysSkillDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SkillId from SysSkill where " + strCondition;
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
 objSQL = clsSysSkillDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysSkill", "SkillId = " + "'"+ strSkillId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSysSkillDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysSkill", strCondition))
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
objSQL = clsSysSkillDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SysSkill");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSysSkillEN objSysSkillEN)
 {
 if (objSysSkillEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSkillEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from SysSkill where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysSkill");
objRow = objDS.Tables["SysSkill"].NewRow();
objRow[conSysSkill.SkillId] = objSysSkillEN.SkillId; //技能Id
 if (objSysSkillEN.SkillName !=  "")
 {
objRow[conSysSkill.SkillName] = objSysSkillEN.SkillName; //技能名称
 }
 if (objSysSkillEN.OperationTypeId !=  "")
 {
objRow[conSysSkill.OperationTypeId] = objSysSkillEN.OperationTypeId; //操作类型ID
 }
 if (objSysSkillEN.Process !=  "")
 {
objRow[conSysSkill.Process] = objSysSkillEN.Process; //实施过程
 }
 if (objSysSkillEN.LevelId !=  "")
 {
objRow[conSysSkill.LevelId] = objSysSkillEN.LevelId; //级别Id
 }
 if (objSysSkillEN.UpdUser !=  "")
 {
objRow[conSysSkill.UpdUser] = objSysSkillEN.UpdUser; //修改人
 }
 if (objSysSkillEN.UpdDate !=  "")
 {
objRow[conSysSkill.UpdDate] = objSysSkillEN.UpdDate; //修改日期
 }
objRow[conSysSkill.IsSubmit] = objSysSkillEN.IsSubmit; //是否提交
 if (objSysSkillEN.CitationId !=  "")
 {
objRow[conSysSkill.CitationId] = objSysSkillEN.CitationId; //引用Id
 }
objRow[conSysSkill.OkCount] = objSysSkillEN.OkCount; //点赞统计
objRow[conSysSkill.AppraiseCount] = objSysSkillEN.AppraiseCount; //评论数
objRow[conSysSkill.Score] = objSysSkillEN.Score; //评分
objRow[conSysSkill.StuScore] = objSysSkillEN.StuScore; //学生平均分
objRow[conSysSkill.TeaScore] = objSysSkillEN.TeaScore; //教师评分
 if (objSysSkillEN.IdCurrEduCls !=  "")
 {
objRow[conSysSkill.IdCurrEduCls] = objSysSkillEN.IdCurrEduCls; //教学班流水号
 }
 if (objSysSkillEN.PdfContent !=  "")
 {
objRow[conSysSkill.PdfContent] = objSysSkillEN.PdfContent; //Pdf内容
 }
objRow[conSysSkill.PdfPageNum] = objSysSkillEN.PdfPageNum; //Pdf页码
objRow[conSysSkill.CitationCount] = objSysSkillEN.CitationCount; //引用统计
objRow[conSysSkill.VersionCount] = objSysSkillEN.VersionCount; //版本统计
 if (objSysSkillEN.Memo !=  "")
 {
objRow[conSysSkill.Memo] = objSysSkillEN.Memo; //备注
 }
 if (objSysSkillEN.CreateDate !=  "")
 {
objRow[conSysSkill.CreateDate] = objSysSkillEN.CreateDate; //建立日期
 }
 if (objSysSkillEN.ShareId !=  "")
 {
objRow[conSysSkill.ShareId] = objSysSkillEN.ShareId; //分享Id
 }
objDS.Tables[clsSysSkillEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSysSkillEN._CurrTabName);
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
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysSkillEN objSysSkillEN)
{
 if (objSysSkillEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSkillEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysSkillEN.SkillId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.SkillId);
 var strSkillId = objSysSkillEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillId + "'");
 }
 
 if (objSysSkillEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.SkillName);
 var strSkillName = objSysSkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objSysSkillEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.OperationTypeId);
 var strOperationTypeId = objSysSkillEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objSysSkillEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Process);
 var strProcess = objSysSkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objSysSkillEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.LevelId);
 var strLevelId = objSysSkillEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSkillEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.UpdUser);
 var strUpdUser = objSysSkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSkillEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.UpdDate);
 var strUpdDate = objSysSkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conSysSkill.IsSubmit);
 arrValueListForInsert.Add("'" + (objSysSkillEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objSysSkillEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CitationId);
 var strCitationId = objSysSkillEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSkillEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.OkCount);
 arrValueListForInsert.Add(objSysSkillEN.OkCount.ToString());
 }
 
 if (objSysSkillEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.AppraiseCount);
 arrValueListForInsert.Add(objSysSkillEN.AppraiseCount.ToString());
 }
 
 if (objSysSkillEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Score);
 arrValueListForInsert.Add(objSysSkillEN.Score.ToString());
 }
 
 if (objSysSkillEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.StuScore);
 arrValueListForInsert.Add(objSysSkillEN.StuScore.ToString());
 }
 
 if (objSysSkillEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.TeaScore);
 arrValueListForInsert.Add(objSysSkillEN.TeaScore.ToString());
 }
 
 if (objSysSkillEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.IdCurrEduCls);
 var strIdCurrEduCls = objSysSkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSkillEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.PdfContent);
 var strPdfContent = objSysSkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSkillEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.PdfPageNum);
 arrValueListForInsert.Add(objSysSkillEN.PdfPageNum.ToString());
 }
 
 if (objSysSkillEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CitationCount);
 arrValueListForInsert.Add(objSysSkillEN.CitationCount.ToString());
 }
 
 if (objSysSkillEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.VersionCount);
 arrValueListForInsert.Add(objSysSkillEN.VersionCount.ToString());
 }
 
 if (objSysSkillEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Memo);
 var strMemo = objSysSkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSkillEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CreateDate);
 var strCreateDate = objSysSkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objSysSkillEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.ShareId);
 var strShareId = objSysSkillEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSkill");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysSkillEN objSysSkillEN)
{
 if (objSysSkillEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSkillEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysSkillEN.SkillId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.SkillId);
 var strSkillId = objSysSkillEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillId + "'");
 }
 
 if (objSysSkillEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.SkillName);
 var strSkillName = objSysSkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objSysSkillEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.OperationTypeId);
 var strOperationTypeId = objSysSkillEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objSysSkillEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Process);
 var strProcess = objSysSkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objSysSkillEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.LevelId);
 var strLevelId = objSysSkillEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSkillEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.UpdUser);
 var strUpdUser = objSysSkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSkillEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.UpdDate);
 var strUpdDate = objSysSkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conSysSkill.IsSubmit);
 arrValueListForInsert.Add("'" + (objSysSkillEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objSysSkillEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CitationId);
 var strCitationId = objSysSkillEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSkillEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.OkCount);
 arrValueListForInsert.Add(objSysSkillEN.OkCount.ToString());
 }
 
 if (objSysSkillEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.AppraiseCount);
 arrValueListForInsert.Add(objSysSkillEN.AppraiseCount.ToString());
 }
 
 if (objSysSkillEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Score);
 arrValueListForInsert.Add(objSysSkillEN.Score.ToString());
 }
 
 if (objSysSkillEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.StuScore);
 arrValueListForInsert.Add(objSysSkillEN.StuScore.ToString());
 }
 
 if (objSysSkillEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.TeaScore);
 arrValueListForInsert.Add(objSysSkillEN.TeaScore.ToString());
 }
 
 if (objSysSkillEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.IdCurrEduCls);
 var strIdCurrEduCls = objSysSkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSkillEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.PdfContent);
 var strPdfContent = objSysSkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSkillEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.PdfPageNum);
 arrValueListForInsert.Add(objSysSkillEN.PdfPageNum.ToString());
 }
 
 if (objSysSkillEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CitationCount);
 arrValueListForInsert.Add(objSysSkillEN.CitationCount.ToString());
 }
 
 if (objSysSkillEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.VersionCount);
 arrValueListForInsert.Add(objSysSkillEN.VersionCount.ToString());
 }
 
 if (objSysSkillEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Memo);
 var strMemo = objSysSkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSkillEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CreateDate);
 var strCreateDate = objSysSkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objSysSkillEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.ShareId);
 var strShareId = objSysSkillEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSkill");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSysSkillEN.SkillId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysSkillEN objSysSkillEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysSkillEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSkillEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysSkillEN.SkillId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.SkillId);
 var strSkillId = objSysSkillEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillId + "'");
 }
 
 if (objSysSkillEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.SkillName);
 var strSkillName = objSysSkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objSysSkillEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.OperationTypeId);
 var strOperationTypeId = objSysSkillEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objSysSkillEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Process);
 var strProcess = objSysSkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objSysSkillEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.LevelId);
 var strLevelId = objSysSkillEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSkillEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.UpdUser);
 var strUpdUser = objSysSkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSkillEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.UpdDate);
 var strUpdDate = objSysSkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conSysSkill.IsSubmit);
 arrValueListForInsert.Add("'" + (objSysSkillEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objSysSkillEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CitationId);
 var strCitationId = objSysSkillEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSkillEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.OkCount);
 arrValueListForInsert.Add(objSysSkillEN.OkCount.ToString());
 }
 
 if (objSysSkillEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.AppraiseCount);
 arrValueListForInsert.Add(objSysSkillEN.AppraiseCount.ToString());
 }
 
 if (objSysSkillEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Score);
 arrValueListForInsert.Add(objSysSkillEN.Score.ToString());
 }
 
 if (objSysSkillEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.StuScore);
 arrValueListForInsert.Add(objSysSkillEN.StuScore.ToString());
 }
 
 if (objSysSkillEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.TeaScore);
 arrValueListForInsert.Add(objSysSkillEN.TeaScore.ToString());
 }
 
 if (objSysSkillEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.IdCurrEduCls);
 var strIdCurrEduCls = objSysSkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSkillEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.PdfContent);
 var strPdfContent = objSysSkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSkillEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.PdfPageNum);
 arrValueListForInsert.Add(objSysSkillEN.PdfPageNum.ToString());
 }
 
 if (objSysSkillEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CitationCount);
 arrValueListForInsert.Add(objSysSkillEN.CitationCount.ToString());
 }
 
 if (objSysSkillEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.VersionCount);
 arrValueListForInsert.Add(objSysSkillEN.VersionCount.ToString());
 }
 
 if (objSysSkillEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Memo);
 var strMemo = objSysSkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSkillEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CreateDate);
 var strCreateDate = objSysSkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objSysSkillEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.ShareId);
 var strShareId = objSysSkillEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSkill");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSysSkillEN.SkillId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysSkillEN objSysSkillEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysSkillEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSkillEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSysSkillEN.SkillId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.SkillId);
 var strSkillId = objSysSkillEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillId + "'");
 }
 
 if (objSysSkillEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.SkillName);
 var strSkillName = objSysSkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objSysSkillEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.OperationTypeId);
 var strOperationTypeId = objSysSkillEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objSysSkillEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Process);
 var strProcess = objSysSkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objSysSkillEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.LevelId);
 var strLevelId = objSysSkillEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSkillEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.UpdUser);
 var strUpdUser = objSysSkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSkillEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.UpdDate);
 var strUpdDate = objSysSkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conSysSkill.IsSubmit);
 arrValueListForInsert.Add("'" + (objSysSkillEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objSysSkillEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CitationId);
 var strCitationId = objSysSkillEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSkillEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.OkCount);
 arrValueListForInsert.Add(objSysSkillEN.OkCount.ToString());
 }
 
 if (objSysSkillEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.AppraiseCount);
 arrValueListForInsert.Add(objSysSkillEN.AppraiseCount.ToString());
 }
 
 if (objSysSkillEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Score);
 arrValueListForInsert.Add(objSysSkillEN.Score.ToString());
 }
 
 if (objSysSkillEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.StuScore);
 arrValueListForInsert.Add(objSysSkillEN.StuScore.ToString());
 }
 
 if (objSysSkillEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.TeaScore);
 arrValueListForInsert.Add(objSysSkillEN.TeaScore.ToString());
 }
 
 if (objSysSkillEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.IdCurrEduCls);
 var strIdCurrEduCls = objSysSkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSkillEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.PdfContent);
 var strPdfContent = objSysSkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSkillEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.PdfPageNum);
 arrValueListForInsert.Add(objSysSkillEN.PdfPageNum.ToString());
 }
 
 if (objSysSkillEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CitationCount);
 arrValueListForInsert.Add(objSysSkillEN.CitationCount.ToString());
 }
 
 if (objSysSkillEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.VersionCount);
 arrValueListForInsert.Add(objSysSkillEN.VersionCount.ToString());
 }
 
 if (objSysSkillEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.Memo);
 var strMemo = objSysSkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSysSkillEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.CreateDate);
 var strCreateDate = objSysSkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objSysSkillEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkill.ShareId);
 var strShareId = objSysSkillEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSkill");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSysSkills(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from SysSkill where SkillId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysSkill");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strSkillId = oRow[conSysSkill.SkillId].ToString().Trim();
if (IsExist(strSkillId))
{
 string strResult = "关键字变量值为:" + string.Format("SkillId = {0}", strSkillId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSysSkillEN._CurrTabName ].NewRow();
objRow[conSysSkill.SkillId] = oRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objRow[conSysSkill.SkillName] = oRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objRow[conSysSkill.OperationTypeId] = oRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objRow[conSysSkill.Process] = oRow[conSysSkill.Process].ToString().Trim(); //实施过程
objRow[conSysSkill.LevelId] = oRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objRow[conSysSkill.UpdUser] = oRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objRow[conSysSkill.UpdDate] = oRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objRow[conSysSkill.IsSubmit] = oRow[conSysSkill.IsSubmit].ToString().Trim(); //是否提交
objRow[conSysSkill.CitationId] = oRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objRow[conSysSkill.OkCount] = oRow[conSysSkill.OkCount].ToString().Trim(); //点赞统计
objRow[conSysSkill.AppraiseCount] = oRow[conSysSkill.AppraiseCount].ToString().Trim(); //评论数
objRow[conSysSkill.Score] = oRow[conSysSkill.Score].ToString().Trim(); //评分
objRow[conSysSkill.StuScore] = oRow[conSysSkill.StuScore].ToString().Trim(); //学生平均分
objRow[conSysSkill.TeaScore] = oRow[conSysSkill.TeaScore].ToString().Trim(); //教师评分
objRow[conSysSkill.IdCurrEduCls] = oRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conSysSkill.PdfContent] = oRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objRow[conSysSkill.PdfPageNum] = oRow[conSysSkill.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conSysSkill.CitationCount] = oRow[conSysSkill.CitationCount].ToString().Trim(); //引用统计
objRow[conSysSkill.VersionCount] = oRow[conSysSkill.VersionCount].ToString().Trim(); //版本统计
objRow[conSysSkill.Memo] = oRow[conSysSkill.Memo].ToString().Trim(); //备注
objRow[conSysSkill.CreateDate] = oRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objRow[conSysSkill.ShareId] = oRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
 objDS.Tables[clsSysSkillEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSysSkillEN._CurrTabName);
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
 /// <param name = "objSysSkillEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSysSkillEN objSysSkillEN)
{
 if (objSysSkillEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSkillEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from SysSkill where SkillId = " + "'"+ objSysSkillEN.SkillId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSysSkillEN._CurrTabName);
if (objDS.Tables[clsSysSkillEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SkillId = " + "'"+ objSysSkillEN.SkillId+"'");
return false;
}
objRow = objDS.Tables[clsSysSkillEN._CurrTabName].Rows[0];
 if (objSysSkillEN.IsUpdated(conSysSkill.SkillId))
 {
objRow[conSysSkill.SkillId] = objSysSkillEN.SkillId; //技能Id
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.SkillName))
 {
objRow[conSysSkill.SkillName] = objSysSkillEN.SkillName; //技能名称
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.OperationTypeId))
 {
objRow[conSysSkill.OperationTypeId] = objSysSkillEN.OperationTypeId; //操作类型ID
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.Process))
 {
objRow[conSysSkill.Process] = objSysSkillEN.Process; //实施过程
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.LevelId))
 {
objRow[conSysSkill.LevelId] = objSysSkillEN.LevelId; //级别Id
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.UpdUser))
 {
objRow[conSysSkill.UpdUser] = objSysSkillEN.UpdUser; //修改人
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.UpdDate))
 {
objRow[conSysSkill.UpdDate] = objSysSkillEN.UpdDate; //修改日期
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.IsSubmit))
 {
objRow[conSysSkill.IsSubmit] = objSysSkillEN.IsSubmit; //是否提交
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.CitationId))
 {
objRow[conSysSkill.CitationId] = objSysSkillEN.CitationId; //引用Id
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.OkCount))
 {
objRow[conSysSkill.OkCount] = objSysSkillEN.OkCount; //点赞统计
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.AppraiseCount))
 {
objRow[conSysSkill.AppraiseCount] = objSysSkillEN.AppraiseCount; //评论数
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.Score))
 {
objRow[conSysSkill.Score] = objSysSkillEN.Score; //评分
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.StuScore))
 {
objRow[conSysSkill.StuScore] = objSysSkillEN.StuScore; //学生平均分
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.TeaScore))
 {
objRow[conSysSkill.TeaScore] = objSysSkillEN.TeaScore; //教师评分
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.IdCurrEduCls))
 {
objRow[conSysSkill.IdCurrEduCls] = objSysSkillEN.IdCurrEduCls; //教学班流水号
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.PdfContent))
 {
objRow[conSysSkill.PdfContent] = objSysSkillEN.PdfContent; //Pdf内容
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.PdfPageNum))
 {
objRow[conSysSkill.PdfPageNum] = objSysSkillEN.PdfPageNum; //Pdf页码
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.CitationCount))
 {
objRow[conSysSkill.CitationCount] = objSysSkillEN.CitationCount; //引用统计
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.VersionCount))
 {
objRow[conSysSkill.VersionCount] = objSysSkillEN.VersionCount; //版本统计
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.Memo))
 {
objRow[conSysSkill.Memo] = objSysSkillEN.Memo; //备注
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.CreateDate))
 {
objRow[conSysSkill.CreateDate] = objSysSkillEN.CreateDate; //建立日期
 }
 if (objSysSkillEN.IsUpdated(conSysSkill.ShareId))
 {
objRow[conSysSkill.ShareId] = objSysSkillEN.ShareId; //分享Id
 }
try
{
objDA.Update(objDS, clsSysSkillEN._CurrTabName);
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
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysSkillEN objSysSkillEN)
{
 if (objSysSkillEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSkillEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SysSkill Set ");
 
 if (objSysSkillEN.IsUpdated(conSysSkill.SkillName))
 {
 if (objSysSkillEN.SkillName !=  null)
 {
 var strSkillName = objSysSkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSkillName, conSysSkill.SkillName); //技能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.SkillName); //技能名称
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.OperationTypeId))
 {
 if (objSysSkillEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objSysSkillEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationTypeId, conSysSkill.OperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.OperationTypeId); //操作类型ID
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Process))
 {
 if (objSysSkillEN.Process !=  null)
 {
 var strProcess = objSysSkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProcess, conSysSkill.Process); //实施过程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.Process); //实施过程
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.LevelId))
 {
 if (objSysSkillEN.LevelId !=  null)
 {
 var strLevelId = objSysSkillEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelId, conSysSkill.LevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.LevelId); //级别Id
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.UpdUser))
 {
 if (objSysSkillEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysSkill.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.UpdUser); //修改人
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.UpdDate))
 {
 if (objSysSkillEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysSkill.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.UpdDate); //修改日期
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSysSkillEN.IsSubmit == true?"1":"0", conSysSkill.IsSubmit); //是否提交
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CitationId))
 {
 if (objSysSkillEN.CitationId !=  null)
 {
 var strCitationId = objSysSkillEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conSysSkill.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.CitationId); //引用Id
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.OkCount))
 {
 if (objSysSkillEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.OkCount, conSysSkill.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.OkCount); //点赞统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.AppraiseCount))
 {
 if (objSysSkillEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.AppraiseCount, conSysSkill.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.AppraiseCount); //评论数
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Score))
 {
 if (objSysSkillEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.Score, conSysSkill.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.Score); //评分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.StuScore))
 {
 if (objSysSkillEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.StuScore, conSysSkill.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.StuScore); //学生平均分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.TeaScore))
 {
 if (objSysSkillEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.TeaScore, conSysSkill.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.TeaScore); //教师评分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.IdCurrEduCls))
 {
 if (objSysSkillEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conSysSkill.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.PdfContent))
 {
 if (objSysSkillEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conSysSkill.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.PdfContent); //Pdf内容
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.PdfPageNum))
 {
 if (objSysSkillEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.PdfPageNum, conSysSkill.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.PdfPageNum); //Pdf页码
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CitationCount))
 {
 if (objSysSkillEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.CitationCount, conSysSkill.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.CitationCount); //引用统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.VersionCount))
 {
 if (objSysSkillEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.VersionCount, conSysSkill.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.VersionCount); //版本统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Memo))
 {
 if (objSysSkillEN.Memo !=  null)
 {
 var strMemo = objSysSkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysSkill.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.Memo); //备注
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CreateDate))
 {
 if (objSysSkillEN.CreateDate !=  null)
 {
 var strCreateDate = objSysSkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conSysSkill.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.CreateDate); //建立日期
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.ShareId))
 {
 if (objSysSkillEN.ShareId !=  null)
 {
 var strShareId = objSysSkillEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conSysSkill.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.ShareId); //分享Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SkillId = '{0}'", objSysSkillEN.SkillId); 
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
 /// <param name = "objSysSkillEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSysSkillEN objSysSkillEN, string strCondition)
{
 if (objSysSkillEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSkillEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSkill Set ");
 
 if (objSysSkillEN.IsUpdated(conSysSkill.SkillName))
 {
 if (objSysSkillEN.SkillName !=  null)
 {
 var strSkillName = objSysSkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SkillName = '{0}',", strSkillName); //技能名称
 }
 else
 {
 sbSQL.Append(" SkillName = null,"); //技能名称
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.OperationTypeId))
 {
 if (objSysSkillEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objSysSkillEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationTypeId = '{0}',", strOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" OperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Process))
 {
 if (objSysSkillEN.Process !=  null)
 {
 var strProcess = objSysSkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Process = '{0}',", strProcess); //实施过程
 }
 else
 {
 sbSQL.Append(" Process = null,"); //实施过程
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.LevelId))
 {
 if (objSysSkillEN.LevelId !=  null)
 {
 var strLevelId = objSysSkillEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelId = '{0}',", strLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" LevelId = null,"); //级别Id
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.UpdUser))
 {
 if (objSysSkillEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.UpdDate))
 {
 if (objSysSkillEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objSysSkillEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CitationId))
 {
 if (objSysSkillEN.CitationId !=  null)
 {
 var strCitationId = objSysSkillEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.OkCount))
 {
 if (objSysSkillEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.OkCount, conSysSkill.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.OkCount); //点赞统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.AppraiseCount))
 {
 if (objSysSkillEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.AppraiseCount, conSysSkill.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.AppraiseCount); //评论数
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Score))
 {
 if (objSysSkillEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.Score, conSysSkill.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.Score); //评分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.StuScore))
 {
 if (objSysSkillEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.StuScore, conSysSkill.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.StuScore); //学生平均分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.TeaScore))
 {
 if (objSysSkillEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.TeaScore, conSysSkill.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.TeaScore); //教师评分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.IdCurrEduCls))
 {
 if (objSysSkillEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.PdfContent))
 {
 if (objSysSkillEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.PdfPageNum))
 {
 if (objSysSkillEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.PdfPageNum, conSysSkill.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.PdfPageNum); //Pdf页码
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CitationCount))
 {
 if (objSysSkillEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.CitationCount, conSysSkill.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.CitationCount); //引用统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.VersionCount))
 {
 if (objSysSkillEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.VersionCount, conSysSkill.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.VersionCount); //版本统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Memo))
 {
 if (objSysSkillEN.Memo !=  null)
 {
 var strMemo = objSysSkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CreateDate))
 {
 if (objSysSkillEN.CreateDate !=  null)
 {
 var strCreateDate = objSysSkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.ShareId))
 {
 if (objSysSkillEN.ShareId !=  null)
 {
 var strShareId = objSysSkillEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
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
 /// <param name = "objSysSkillEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSysSkillEN objSysSkillEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysSkillEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSkillEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSkill Set ");
 
 if (objSysSkillEN.IsUpdated(conSysSkill.SkillName))
 {
 if (objSysSkillEN.SkillName !=  null)
 {
 var strSkillName = objSysSkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SkillName = '{0}',", strSkillName); //技能名称
 }
 else
 {
 sbSQL.Append(" SkillName = null,"); //技能名称
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.OperationTypeId))
 {
 if (objSysSkillEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objSysSkillEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationTypeId = '{0}',", strOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" OperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Process))
 {
 if (objSysSkillEN.Process !=  null)
 {
 var strProcess = objSysSkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Process = '{0}',", strProcess); //实施过程
 }
 else
 {
 sbSQL.Append(" Process = null,"); //实施过程
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.LevelId))
 {
 if (objSysSkillEN.LevelId !=  null)
 {
 var strLevelId = objSysSkillEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelId = '{0}',", strLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" LevelId = null,"); //级别Id
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.UpdUser))
 {
 if (objSysSkillEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.UpdDate))
 {
 if (objSysSkillEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objSysSkillEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CitationId))
 {
 if (objSysSkillEN.CitationId !=  null)
 {
 var strCitationId = objSysSkillEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.OkCount))
 {
 if (objSysSkillEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.OkCount, conSysSkill.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.OkCount); //点赞统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.AppraiseCount))
 {
 if (objSysSkillEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.AppraiseCount, conSysSkill.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.AppraiseCount); //评论数
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Score))
 {
 if (objSysSkillEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.Score, conSysSkill.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.Score); //评分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.StuScore))
 {
 if (objSysSkillEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.StuScore, conSysSkill.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.StuScore); //学生平均分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.TeaScore))
 {
 if (objSysSkillEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.TeaScore, conSysSkill.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.TeaScore); //教师评分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.IdCurrEduCls))
 {
 if (objSysSkillEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.PdfContent))
 {
 if (objSysSkillEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.PdfPageNum))
 {
 if (objSysSkillEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.PdfPageNum, conSysSkill.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.PdfPageNum); //Pdf页码
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CitationCount))
 {
 if (objSysSkillEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.CitationCount, conSysSkill.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.CitationCount); //引用统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.VersionCount))
 {
 if (objSysSkillEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.VersionCount, conSysSkill.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.VersionCount); //版本统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Memo))
 {
 if (objSysSkillEN.Memo !=  null)
 {
 var strMemo = objSysSkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CreateDate))
 {
 if (objSysSkillEN.CreateDate !=  null)
 {
 var strCreateDate = objSysSkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.ShareId))
 {
 if (objSysSkillEN.ShareId !=  null)
 {
 var strShareId = objSysSkillEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
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
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysSkillEN objSysSkillEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysSkillEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSkillEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSkill Set ");
 
 if (objSysSkillEN.IsUpdated(conSysSkill.SkillName))
 {
 if (objSysSkillEN.SkillName !=  null)
 {
 var strSkillName = objSysSkillEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSkillName, conSysSkill.SkillName); //技能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.SkillName); //技能名称
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.OperationTypeId))
 {
 if (objSysSkillEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objSysSkillEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationTypeId, conSysSkill.OperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.OperationTypeId); //操作类型ID
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Process))
 {
 if (objSysSkillEN.Process !=  null)
 {
 var strProcess = objSysSkillEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProcess, conSysSkill.Process); //实施过程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.Process); //实施过程
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.LevelId))
 {
 if (objSysSkillEN.LevelId !=  null)
 {
 var strLevelId = objSysSkillEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelId, conSysSkill.LevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.LevelId); //级别Id
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.UpdUser))
 {
 if (objSysSkillEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSkillEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysSkill.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.UpdUser); //修改人
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.UpdDate))
 {
 if (objSysSkillEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSkillEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysSkill.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.UpdDate); //修改日期
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSysSkillEN.IsSubmit == true?"1":"0", conSysSkill.IsSubmit); //是否提交
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CitationId))
 {
 if (objSysSkillEN.CitationId !=  null)
 {
 var strCitationId = objSysSkillEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conSysSkill.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.CitationId); //引用Id
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.OkCount))
 {
 if (objSysSkillEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.OkCount, conSysSkill.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.OkCount); //点赞统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.AppraiseCount))
 {
 if (objSysSkillEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.AppraiseCount, conSysSkill.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.AppraiseCount); //评论数
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Score))
 {
 if (objSysSkillEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.Score, conSysSkill.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.Score); //评分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.StuScore))
 {
 if (objSysSkillEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.StuScore, conSysSkill.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.StuScore); //学生平均分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.TeaScore))
 {
 if (objSysSkillEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.TeaScore, conSysSkill.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.TeaScore); //教师评分
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.IdCurrEduCls))
 {
 if (objSysSkillEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSkillEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conSysSkill.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.PdfContent))
 {
 if (objSysSkillEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSkillEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conSysSkill.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.PdfContent); //Pdf内容
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.PdfPageNum))
 {
 if (objSysSkillEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.PdfPageNum, conSysSkill.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.PdfPageNum); //Pdf页码
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CitationCount))
 {
 if (objSysSkillEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.CitationCount, conSysSkill.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.CitationCount); //引用统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.VersionCount))
 {
 if (objSysSkillEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillEN.VersionCount, conSysSkill.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.VersionCount); //版本统计
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.Memo))
 {
 if (objSysSkillEN.Memo !=  null)
 {
 var strMemo = objSysSkillEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysSkill.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.Memo); //备注
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.CreateDate))
 {
 if (objSysSkillEN.CreateDate !=  null)
 {
 var strCreateDate = objSysSkillEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conSysSkill.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.CreateDate); //建立日期
 }
 }
 
 if (objSysSkillEN.IsUpdated(conSysSkill.ShareId))
 {
 if (objSysSkillEN.ShareId !=  null)
 {
 var strShareId = objSysSkillEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conSysSkill.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkill.ShareId); //分享Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SkillId = '{0}'", objSysSkillEN.SkillId); 
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
 /// <param name = "strSkillId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strSkillId) 
{
CheckPrimaryKey(strSkillId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strSkillId,
};
 objSQL.ExecSP("SysSkill_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strSkillId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strSkillId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strSkillId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
//删除SysSkill本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSkill where SkillId = " + "'"+ strSkillId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSysSkill(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
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
//删除SysSkill本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSkill where SkillId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strSkillId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strSkillId) 
{
CheckPrimaryKey(strSkillId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
//删除SysSkill本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSkill where SkillId = " + "'"+ strSkillId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSysSkill(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSysSkillDA: DelSysSkill)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysSkill where " + strCondition ;
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
public bool DelSysSkillWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSysSkillDA: DelSysSkillWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysSkill where " + strCondition ;
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
 /// <param name = "objSysSkillENS">源对象</param>
 /// <param name = "objSysSkillENT">目标对象</param>
public void CopyTo(clsSysSkillEN objSysSkillENS, clsSysSkillEN objSysSkillENT)
{
objSysSkillENT.SkillId = objSysSkillENS.SkillId; //技能Id
objSysSkillENT.SkillName = objSysSkillENS.SkillName; //技能名称
objSysSkillENT.OperationTypeId = objSysSkillENS.OperationTypeId; //操作类型ID
objSysSkillENT.Process = objSysSkillENS.Process; //实施过程
objSysSkillENT.LevelId = objSysSkillENS.LevelId; //级别Id
objSysSkillENT.UpdUser = objSysSkillENS.UpdUser; //修改人
objSysSkillENT.UpdDate = objSysSkillENS.UpdDate; //修改日期
objSysSkillENT.IsSubmit = objSysSkillENS.IsSubmit; //是否提交
objSysSkillENT.CitationId = objSysSkillENS.CitationId; //引用Id
objSysSkillENT.OkCount = objSysSkillENS.OkCount; //点赞统计
objSysSkillENT.AppraiseCount = objSysSkillENS.AppraiseCount; //评论数
objSysSkillENT.Score = objSysSkillENS.Score; //评分
objSysSkillENT.StuScore = objSysSkillENS.StuScore; //学生平均分
objSysSkillENT.TeaScore = objSysSkillENS.TeaScore; //教师评分
objSysSkillENT.IdCurrEduCls = objSysSkillENS.IdCurrEduCls; //教学班流水号
objSysSkillENT.PdfContent = objSysSkillENS.PdfContent; //Pdf内容
objSysSkillENT.PdfPageNum = objSysSkillENS.PdfPageNum; //Pdf页码
objSysSkillENT.CitationCount = objSysSkillENS.CitationCount; //引用统计
objSysSkillENT.VersionCount = objSysSkillENS.VersionCount; //版本统计
objSysSkillENT.Memo = objSysSkillENS.Memo; //备注
objSysSkillENT.CreateDate = objSysSkillENS.CreateDate; //建立日期
objSysSkillENT.ShareId = objSysSkillENS.ShareId; //分享Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSysSkillEN objSysSkillEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSkillEN.SkillId, 10, conSysSkill.SkillId);
clsCheckSql.CheckFieldLen(objSysSkillEN.SkillName, 200, conSysSkill.SkillName);
clsCheckSql.CheckFieldLen(objSysSkillEN.OperationTypeId, 4, conSysSkill.OperationTypeId);
clsCheckSql.CheckFieldLen(objSysSkillEN.LevelId, 2, conSysSkill.LevelId);
clsCheckSql.CheckFieldLen(objSysSkillEN.UpdUser, 20, conSysSkill.UpdUser);
clsCheckSql.CheckFieldLen(objSysSkillEN.UpdDate, 20, conSysSkill.UpdDate);
clsCheckSql.CheckFieldLen(objSysSkillEN.CitationId, 8, conSysSkill.CitationId);
clsCheckSql.CheckFieldLen(objSysSkillEN.IdCurrEduCls, 8, conSysSkill.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSkillEN.PdfContent, 2000, conSysSkill.PdfContent);
clsCheckSql.CheckFieldLen(objSysSkillEN.Memo, 1000, conSysSkill.Memo);
clsCheckSql.CheckFieldLen(objSysSkillEN.CreateDate, 20, conSysSkill.CreateDate);
clsCheckSql.CheckFieldLen(objSysSkillEN.ShareId, 2, conSysSkill.ShareId);
//检查字段外键固定长度
 objSysSkillEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSysSkillEN objSysSkillEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSkillEN.SkillName, 200, conSysSkill.SkillName);
clsCheckSql.CheckFieldLen(objSysSkillEN.OperationTypeId, 4, conSysSkill.OperationTypeId);
clsCheckSql.CheckFieldLen(objSysSkillEN.LevelId, 2, conSysSkill.LevelId);
clsCheckSql.CheckFieldLen(objSysSkillEN.UpdUser, 20, conSysSkill.UpdUser);
clsCheckSql.CheckFieldLen(objSysSkillEN.UpdDate, 20, conSysSkill.UpdDate);
clsCheckSql.CheckFieldLen(objSysSkillEN.CitationId, 8, conSysSkill.CitationId);
clsCheckSql.CheckFieldLen(objSysSkillEN.IdCurrEduCls, 8, conSysSkill.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSkillEN.PdfContent, 2000, conSysSkill.PdfContent);
clsCheckSql.CheckFieldLen(objSysSkillEN.Memo, 1000, conSysSkill.Memo);
clsCheckSql.CheckFieldLen(objSysSkillEN.CreateDate, 20, conSysSkill.CreateDate);
clsCheckSql.CheckFieldLen(objSysSkillEN.ShareId, 2, conSysSkill.ShareId);
//检查外键字段长度
 objSysSkillEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSysSkillEN objSysSkillEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSkillEN.SkillId, 10, conSysSkill.SkillId);
clsCheckSql.CheckFieldLen(objSysSkillEN.SkillName, 200, conSysSkill.SkillName);
clsCheckSql.CheckFieldLen(objSysSkillEN.OperationTypeId, 4, conSysSkill.OperationTypeId);
clsCheckSql.CheckFieldLen(objSysSkillEN.LevelId, 2, conSysSkill.LevelId);
clsCheckSql.CheckFieldLen(objSysSkillEN.UpdUser, 20, conSysSkill.UpdUser);
clsCheckSql.CheckFieldLen(objSysSkillEN.UpdDate, 20, conSysSkill.UpdDate);
clsCheckSql.CheckFieldLen(objSysSkillEN.CitationId, 8, conSysSkill.CitationId);
clsCheckSql.CheckFieldLen(objSysSkillEN.IdCurrEduCls, 8, conSysSkill.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSkillEN.PdfContent, 2000, conSysSkill.PdfContent);
clsCheckSql.CheckFieldLen(objSysSkillEN.Memo, 1000, conSysSkill.Memo);
clsCheckSql.CheckFieldLen(objSysSkillEN.CreateDate, 20, conSysSkill.CreateDate);
clsCheckSql.CheckFieldLen(objSysSkillEN.ShareId, 2, conSysSkill.ShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.SkillId, conSysSkill.SkillId);
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.SkillName, conSysSkill.SkillName);
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.OperationTypeId, conSysSkill.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.LevelId, conSysSkill.LevelId);
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.UpdUser, conSysSkill.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.UpdDate, conSysSkill.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.CitationId, conSysSkill.CitationId);
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.IdCurrEduCls, conSysSkill.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.PdfContent, conSysSkill.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.Memo, conSysSkill.Memo);
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.CreateDate, conSysSkill.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objSysSkillEN.ShareId, conSysSkill.ShareId);
//检查外键字段长度
 objSysSkillEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SysSkill(技能表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysSkillEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSysSkillEN objSysSkillEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SkillId = '{0}'", objSysSkillEN.SkillId);
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
 objSQL = clsSysSkillDA.GetSpecSQLObj();
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
 objSQL = clsSysSkillDA.GetSpecSQLObj();
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
 objSQL = clsSysSkillDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysSkillEN._CurrTabName);
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
 objSQL = clsSysSkillDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysSkillEN._CurrTabName, strCondition);
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
 objSQL = clsSysSkillDA.GetSpecSQLObj();
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
 objSQL = clsSysSkillDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}