
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSkillVerDA
 表名:SysSkillVer(01120647)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:22
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
 /// 系统技能版本(SysSkillVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSysSkillVerDA : clsCommBase4DA
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
 return clsSysSkillVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSysSkillVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysSkillVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSysSkillVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSysSkillVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSysSkillVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSkillVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SysSkillVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSysSkillVerDA: GetDataTable_SysSkillVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSkillVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSysSkillVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSysSkillVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSkillVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSysSkillVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSysSkillVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSkillVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSkillVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSysSkillVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SysSkillVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSysSkillVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysSkillVer.* from SysSkillVer Left Join {1} on {2} where {3} and SysSkillVer.SkillVId not in (Select top {5} SysSkillVer.SkillVId from SysSkillVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSkillVer where {1} and SkillVId not in (Select top {2} SkillVId from SysSkillVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSkillVer where {1} and SkillVId not in (Select top {3} SkillVId from SysSkillVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSysSkillVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SysSkillVer.* from SysSkillVer Left Join {1} on {2} where {3} and SysSkillVer.SkillVId not in (Select top {5} SysSkillVer.SkillVId from SysSkillVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysSkillVer where {1} and SkillVId not in (Select top {2} SkillVId from SysSkillVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysSkillVer where {1} and SkillVId not in (Select top {3} SkillVId from SysSkillVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSysSkillVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSysSkillVerDA:GetObjLst)", objException.Message));
}
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSkillVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = TransNullToInt(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysSkillVerDA: GetObjLst)", objException.Message));
}
objSysSkillVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysSkillVerEN);
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
public List<clsSysSkillVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSysSkillVerDA:GetObjLstByTabName)", objException.Message));
}
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = TransNullToInt(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysSkillVerDA: GetObjLst)", objException.Message));
}
objSysSkillVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysSkillVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSysSkillVer(ref clsSysSkillVerEN objSysSkillVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSkillVer where SkillVId = " + ""+ objSysSkillVerEN.SkillVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSysSkillVerEN.SkillVId = TransNullToInt(objDT.Rows[0][conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId(字段类型:bigint,字段长度:8,是否可空:False)
 objSysSkillVerEN.SkillId = objDT.Rows[0][conSysSkillVer.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objSysSkillVerEN.SkillName = objDT.Rows[0][conSysSkillVer.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objSysSkillVerEN.OperationTypeId = objDT.Rows[0][conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objSysSkillVerEN.Process = objDT.Rows[0][conSysSkillVer.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objSysSkillVerEN.LevelId = objDT.Rows[0][conSysSkillVer.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objSysSkillVerEN.UpdUser = objDT.Rows[0][conSysSkillVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSkillVerEN.UpdDate = objDT.Rows[0][conSysSkillVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSkillVerEN.CitationId = objDT.Rows[0][conSysSkillVer.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objSysSkillVerEN.IdCurrEduCls = objDT.Rows[0][conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objSysSkillVerEN.PdfContent = objDT.Rows[0][conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objSysSkillVerEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillVerEN.Memo = objDT.Rows[0][conSysSkillVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSysSkillVerDA: GetSysSkillVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngSkillVId">表关键字</param>
 /// <returns>表对象</returns>
public clsSysSkillVerEN GetObjBySkillVId(long lngSkillVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSkillVer where SkillVId = " + ""+ lngSkillVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
 objSysSkillVerEN.SkillVId = Int32.Parse(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId(字段类型:bigint,字段长度:8,是否可空:False)
 objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSysSkillVerDA: GetObjBySkillVId)", objException.Message));
}
return objSysSkillVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSysSkillVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSysSkillVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSkillVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN()
{
SkillVId = TransNullToInt(objRow[conSysSkillVer.SkillVId].ToString().Trim()), //SkillVId
SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(), //技能Id
SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(), //技能名称
OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(), //操作类型ID
Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(), //实施过程
LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(), //级别Id
UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(), //修改日期
CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(), //引用Id
IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()), //Pdf页码
Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim() //备注
};
objSysSkillVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSkillVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSysSkillVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSysSkillVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = TransNullToInt(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSysSkillVerDA: GetObjByDataRowSysSkillVer)", objException.Message));
}
objSysSkillVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSkillVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSysSkillVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = TransNullToInt(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSysSkillVerDA: GetObjByDataRow)", objException.Message));
}
objSysSkillVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysSkillVerEN;
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
objSQL = clsSysSkillVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysSkillVerEN._CurrTabName, conSysSkillVer.SkillVId, 8, "");
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
objSQL = clsSysSkillVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysSkillVerEN._CurrTabName, conSysSkillVer.SkillVId, 8, strPrefix);
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SkillVId from SysSkillVer where " + strCondition;
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SkillVId from SysSkillVer where " + strCondition;
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysSkillVer", "SkillVId = " + ""+ lngSkillVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSysSkillVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysSkillVer", strCondition))
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
objSQL = clsSysSkillVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SysSkillVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSysSkillVerEN objSysSkillVerEN)
 {
 if (objSysSkillVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSkillVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSkillVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysSkillVer");
objRow = objDS.Tables["SysSkillVer"].NewRow();
objRow[conSysSkillVer.SkillId] = objSysSkillVerEN.SkillId; //技能Id
 if (objSysSkillVerEN.SkillName !=  "")
 {
objRow[conSysSkillVer.SkillName] = objSysSkillVerEN.SkillName; //技能名称
 }
 if (objSysSkillVerEN.OperationTypeId !=  "")
 {
objRow[conSysSkillVer.OperationTypeId] = objSysSkillVerEN.OperationTypeId; //操作类型ID
 }
 if (objSysSkillVerEN.Process !=  "")
 {
objRow[conSysSkillVer.Process] = objSysSkillVerEN.Process; //实施过程
 }
 if (objSysSkillVerEN.LevelId !=  "")
 {
objRow[conSysSkillVer.LevelId] = objSysSkillVerEN.LevelId; //级别Id
 }
 if (objSysSkillVerEN.UpdUser !=  "")
 {
objRow[conSysSkillVer.UpdUser] = objSysSkillVerEN.UpdUser; //修改人
 }
 if (objSysSkillVerEN.UpdDate !=  "")
 {
objRow[conSysSkillVer.UpdDate] = objSysSkillVerEN.UpdDate; //修改日期
 }
 if (objSysSkillVerEN.CitationId !=  "")
 {
objRow[conSysSkillVer.CitationId] = objSysSkillVerEN.CitationId; //引用Id
 }
 if (objSysSkillVerEN.IdCurrEduCls !=  "")
 {
objRow[conSysSkillVer.IdCurrEduCls] = objSysSkillVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objSysSkillVerEN.PdfContent !=  "")
 {
objRow[conSysSkillVer.PdfContent] = objSysSkillVerEN.PdfContent; //Pdf内容
 }
objRow[conSysSkillVer.PdfPageNum] = objSysSkillVerEN.PdfPageNum; //Pdf页码
 if (objSysSkillVerEN.Memo !=  "")
 {
objRow[conSysSkillVer.Memo] = objSysSkillVerEN.Memo; //备注
 }
objDS.Tables[clsSysSkillVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSysSkillVerEN._CurrTabName);
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
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysSkillVerEN objSysSkillVerEN)
{
 if (objSysSkillVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSkillVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysSkillVerEN.SkillId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.SkillId);
 var strSkillId = objSysSkillVerEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillId + "'");
 }
 
 if (objSysSkillVerEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.SkillName);
 var strSkillName = objSysSkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objSysSkillVerEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.OperationTypeId);
 var strOperationTypeId = objSysSkillVerEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objSysSkillVerEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.Process);
 var strProcess = objSysSkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objSysSkillVerEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.LevelId);
 var strLevelId = objSysSkillVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSkillVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.UpdUser);
 var strUpdUser = objSysSkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSkillVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.UpdDate);
 var strUpdDate = objSysSkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysSkillVerEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.CitationId);
 var strCitationId = objSysSkillVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSkillVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.IdCurrEduCls);
 var strIdCurrEduCls = objSysSkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSkillVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.PdfContent);
 var strPdfContent = objSysSkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSkillVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.PdfPageNum);
 arrValueListForInsert.Add(objSysSkillVerEN.PdfPageNum.ToString());
 }
 
 if (objSysSkillVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.Memo);
 var strMemo = objSysSkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSkillVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysSkillVerEN objSysSkillVerEN)
{
 if (objSysSkillVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSkillVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysSkillVerEN.SkillId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.SkillId);
 var strSkillId = objSysSkillVerEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillId + "'");
 }
 
 if (objSysSkillVerEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.SkillName);
 var strSkillName = objSysSkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objSysSkillVerEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.OperationTypeId);
 var strOperationTypeId = objSysSkillVerEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objSysSkillVerEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.Process);
 var strProcess = objSysSkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objSysSkillVerEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.LevelId);
 var strLevelId = objSysSkillVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSkillVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.UpdUser);
 var strUpdUser = objSysSkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSkillVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.UpdDate);
 var strUpdDate = objSysSkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysSkillVerEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.CitationId);
 var strCitationId = objSysSkillVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSkillVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.IdCurrEduCls);
 var strIdCurrEduCls = objSysSkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSkillVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.PdfContent);
 var strPdfContent = objSysSkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSkillVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.PdfPageNum);
 arrValueListForInsert.Add(objSysSkillVerEN.PdfPageNum.ToString());
 }
 
 if (objSysSkillVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.Memo);
 var strMemo = objSysSkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSkillVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysSkillVerEN objSysSkillVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysSkillVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSkillVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysSkillVerEN.SkillId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.SkillId);
 var strSkillId = objSysSkillVerEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillId + "'");
 }
 
 if (objSysSkillVerEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.SkillName);
 var strSkillName = objSysSkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objSysSkillVerEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.OperationTypeId);
 var strOperationTypeId = objSysSkillVerEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objSysSkillVerEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.Process);
 var strProcess = objSysSkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objSysSkillVerEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.LevelId);
 var strLevelId = objSysSkillVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSkillVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.UpdUser);
 var strUpdUser = objSysSkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSkillVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.UpdDate);
 var strUpdDate = objSysSkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysSkillVerEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.CitationId);
 var strCitationId = objSysSkillVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSkillVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.IdCurrEduCls);
 var strIdCurrEduCls = objSysSkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSkillVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.PdfContent);
 var strPdfContent = objSysSkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSkillVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.PdfPageNum);
 arrValueListForInsert.Add(objSysSkillVerEN.PdfPageNum.ToString());
 }
 
 if (objSysSkillVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.Memo);
 var strMemo = objSysSkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSkillVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysSkillVerEN objSysSkillVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysSkillVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysSkillVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysSkillVerEN.SkillId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.SkillId);
 var strSkillId = objSysSkillVerEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillId + "'");
 }
 
 if (objSysSkillVerEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.SkillName);
 var strSkillName = objSysSkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objSysSkillVerEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.OperationTypeId);
 var strOperationTypeId = objSysSkillVerEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objSysSkillVerEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.Process);
 var strProcess = objSysSkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objSysSkillVerEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.LevelId);
 var strLevelId = objSysSkillVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objSysSkillVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.UpdUser);
 var strUpdUser = objSysSkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objSysSkillVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.UpdDate);
 var strUpdDate = objSysSkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSysSkillVerEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.CitationId);
 var strCitationId = objSysSkillVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objSysSkillVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.IdCurrEduCls);
 var strIdCurrEduCls = objSysSkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objSysSkillVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.PdfContent);
 var strPdfContent = objSysSkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objSysSkillVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.PdfPageNum);
 arrValueListForInsert.Add(objSysSkillVerEN.PdfPageNum.ToString());
 }
 
 if (objSysSkillVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysSkillVer.Memo);
 var strMemo = objSysSkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysSkillVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSysSkillVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSkillVer where SkillVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysSkillVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngSkillVId = TransNullToInt(oRow[conSysSkillVer.SkillVId].ToString().Trim());
if (IsExist(lngSkillVId))
{
 string strResult = "关键字变量值为:" + string.Format("SkillVId = {0}", lngSkillVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSysSkillVerEN._CurrTabName ].NewRow();
objRow[conSysSkillVer.SkillId] = oRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objRow[conSysSkillVer.SkillName] = oRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objRow[conSysSkillVer.OperationTypeId] = oRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objRow[conSysSkillVer.Process] = oRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objRow[conSysSkillVer.LevelId] = oRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objRow[conSysSkillVer.UpdUser] = oRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objRow[conSysSkillVer.UpdDate] = oRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objRow[conSysSkillVer.CitationId] = oRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objRow[conSysSkillVer.IdCurrEduCls] = oRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conSysSkillVer.PdfContent] = oRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objRow[conSysSkillVer.PdfPageNum] = oRow[conSysSkillVer.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conSysSkillVer.Memo] = oRow[conSysSkillVer.Memo].ToString().Trim(); //备注
 objDS.Tables[clsSysSkillVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSysSkillVerEN._CurrTabName);
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
 /// <param name = "objSysSkillVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSysSkillVerEN objSysSkillVerEN)
{
 if (objSysSkillVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSkillVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
strSQL = "Select * from SysSkillVer where SkillVId = " + ""+ objSysSkillVerEN.SkillVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSysSkillVerEN._CurrTabName);
if (objDS.Tables[clsSysSkillVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SkillVId = " + ""+ objSysSkillVerEN.SkillVId+"");
return false;
}
objRow = objDS.Tables[clsSysSkillVerEN._CurrTabName].Rows[0];
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.SkillId))
 {
objRow[conSysSkillVer.SkillId] = objSysSkillVerEN.SkillId; //技能Id
 }
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.SkillName))
 {
objRow[conSysSkillVer.SkillName] = objSysSkillVerEN.SkillName; //技能名称
 }
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.OperationTypeId))
 {
objRow[conSysSkillVer.OperationTypeId] = objSysSkillVerEN.OperationTypeId; //操作类型ID
 }
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.Process))
 {
objRow[conSysSkillVer.Process] = objSysSkillVerEN.Process; //实施过程
 }
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.LevelId))
 {
objRow[conSysSkillVer.LevelId] = objSysSkillVerEN.LevelId; //级别Id
 }
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.UpdUser))
 {
objRow[conSysSkillVer.UpdUser] = objSysSkillVerEN.UpdUser; //修改人
 }
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.UpdDate))
 {
objRow[conSysSkillVer.UpdDate] = objSysSkillVerEN.UpdDate; //修改日期
 }
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.CitationId))
 {
objRow[conSysSkillVer.CitationId] = objSysSkillVerEN.CitationId; //引用Id
 }
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.IdCurrEduCls))
 {
objRow[conSysSkillVer.IdCurrEduCls] = objSysSkillVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.PdfContent))
 {
objRow[conSysSkillVer.PdfContent] = objSysSkillVerEN.PdfContent; //Pdf内容
 }
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.PdfPageNum))
 {
objRow[conSysSkillVer.PdfPageNum] = objSysSkillVerEN.PdfPageNum; //Pdf页码
 }
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.Memo))
 {
objRow[conSysSkillVer.Memo] = objSysSkillVerEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsSysSkillVerEN._CurrTabName);
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
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysSkillVerEN objSysSkillVerEN)
{
 if (objSysSkillVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSkillVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SysSkillVer Set ");
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.SkillId))
 {
 if (objSysSkillVerEN.SkillId !=  null)
 {
 var strSkillId = objSysSkillVerEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSkillId, conSysSkillVer.SkillId); //技能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.SkillId); //技能Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.SkillName))
 {
 if (objSysSkillVerEN.SkillName !=  null)
 {
 var strSkillName = objSysSkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSkillName, conSysSkillVer.SkillName); //技能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.SkillName); //技能名称
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.OperationTypeId))
 {
 if (objSysSkillVerEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objSysSkillVerEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationTypeId, conSysSkillVer.OperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.OperationTypeId); //操作类型ID
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.Process))
 {
 if (objSysSkillVerEN.Process !=  null)
 {
 var strProcess = objSysSkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProcess, conSysSkillVer.Process); //实施过程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.Process); //实施过程
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.LevelId))
 {
 if (objSysSkillVerEN.LevelId !=  null)
 {
 var strLevelId = objSysSkillVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelId, conSysSkillVer.LevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.LevelId); //级别Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.UpdUser))
 {
 if (objSysSkillVerEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysSkillVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.UpdUser); //修改人
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.UpdDate))
 {
 if (objSysSkillVerEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysSkillVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.UpdDate); //修改日期
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.CitationId))
 {
 if (objSysSkillVerEN.CitationId !=  null)
 {
 var strCitationId = objSysSkillVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conSysSkillVer.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.CitationId); //引用Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.IdCurrEduCls))
 {
 if (objSysSkillVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conSysSkillVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.PdfContent))
 {
 if (objSysSkillVerEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conSysSkillVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.PdfContent); //Pdf内容
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.PdfPageNum))
 {
 if (objSysSkillVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillVerEN.PdfPageNum, conSysSkillVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.Memo))
 {
 if (objSysSkillVerEN.Memo !=  null)
 {
 var strMemo = objSysSkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysSkillVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SkillVId = {0}", objSysSkillVerEN.SkillVId); 
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
 /// <param name = "objSysSkillVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSysSkillVerEN objSysSkillVerEN, string strCondition)
{
 if (objSysSkillVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSkillVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSkillVer Set ");
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.SkillId))
 {
 if (objSysSkillVerEN.SkillId !=  null)
 {
 var strSkillId = objSysSkillVerEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SkillId = '{0}',", strSkillId); //技能Id
 }
 else
 {
 sbSQL.Append(" SkillId = null,"); //技能Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.SkillName))
 {
 if (objSysSkillVerEN.SkillName !=  null)
 {
 var strSkillName = objSysSkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SkillName = '{0}',", strSkillName); //技能名称
 }
 else
 {
 sbSQL.Append(" SkillName = null,"); //技能名称
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.OperationTypeId))
 {
 if (objSysSkillVerEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objSysSkillVerEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationTypeId = '{0}',", strOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" OperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.Process))
 {
 if (objSysSkillVerEN.Process !=  null)
 {
 var strProcess = objSysSkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Process = '{0}',", strProcess); //实施过程
 }
 else
 {
 sbSQL.Append(" Process = null,"); //实施过程
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.LevelId))
 {
 if (objSysSkillVerEN.LevelId !=  null)
 {
 var strLevelId = objSysSkillVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelId = '{0}',", strLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" LevelId = null,"); //级别Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.UpdUser))
 {
 if (objSysSkillVerEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.UpdDate))
 {
 if (objSysSkillVerEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.CitationId))
 {
 if (objSysSkillVerEN.CitationId !=  null)
 {
 var strCitationId = objSysSkillVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.IdCurrEduCls))
 {
 if (objSysSkillVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.PdfContent))
 {
 if (objSysSkillVerEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.PdfPageNum))
 {
 if (objSysSkillVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillVerEN.PdfPageNum, conSysSkillVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.Memo))
 {
 if (objSysSkillVerEN.Memo !=  null)
 {
 var strMemo = objSysSkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSysSkillVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSysSkillVerEN objSysSkillVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysSkillVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSkillVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSkillVer Set ");
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.SkillId))
 {
 if (objSysSkillVerEN.SkillId !=  null)
 {
 var strSkillId = objSysSkillVerEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SkillId = '{0}',", strSkillId); //技能Id
 }
 else
 {
 sbSQL.Append(" SkillId = null,"); //技能Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.SkillName))
 {
 if (objSysSkillVerEN.SkillName !=  null)
 {
 var strSkillName = objSysSkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SkillName = '{0}',", strSkillName); //技能名称
 }
 else
 {
 sbSQL.Append(" SkillName = null,"); //技能名称
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.OperationTypeId))
 {
 if (objSysSkillVerEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objSysSkillVerEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationTypeId = '{0}',", strOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" OperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.Process))
 {
 if (objSysSkillVerEN.Process !=  null)
 {
 var strProcess = objSysSkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Process = '{0}',", strProcess); //实施过程
 }
 else
 {
 sbSQL.Append(" Process = null,"); //实施过程
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.LevelId))
 {
 if (objSysSkillVerEN.LevelId !=  null)
 {
 var strLevelId = objSysSkillVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelId = '{0}',", strLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" LevelId = null,"); //级别Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.UpdUser))
 {
 if (objSysSkillVerEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.UpdDate))
 {
 if (objSysSkillVerEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.CitationId))
 {
 if (objSysSkillVerEN.CitationId !=  null)
 {
 var strCitationId = objSysSkillVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.IdCurrEduCls))
 {
 if (objSysSkillVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.PdfContent))
 {
 if (objSysSkillVerEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.PdfPageNum))
 {
 if (objSysSkillVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillVerEN.PdfPageNum, conSysSkillVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.Memo))
 {
 if (objSysSkillVerEN.Memo !=  null)
 {
 var strMemo = objSysSkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysSkillVerEN objSysSkillVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysSkillVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysSkillVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysSkillVer Set ");
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.SkillId))
 {
 if (objSysSkillVerEN.SkillId !=  null)
 {
 var strSkillId = objSysSkillVerEN.SkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSkillId, conSysSkillVer.SkillId); //技能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.SkillId); //技能Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.SkillName))
 {
 if (objSysSkillVerEN.SkillName !=  null)
 {
 var strSkillName = objSysSkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSkillName, conSysSkillVer.SkillName); //技能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.SkillName); //技能名称
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.OperationTypeId))
 {
 if (objSysSkillVerEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objSysSkillVerEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationTypeId, conSysSkillVer.OperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.OperationTypeId); //操作类型ID
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.Process))
 {
 if (objSysSkillVerEN.Process !=  null)
 {
 var strProcess = objSysSkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProcess, conSysSkillVer.Process); //实施过程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.Process); //实施过程
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.LevelId))
 {
 if (objSysSkillVerEN.LevelId !=  null)
 {
 var strLevelId = objSysSkillVerEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelId, conSysSkillVer.LevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.LevelId); //级别Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.UpdUser))
 {
 if (objSysSkillVerEN.UpdUser !=  null)
 {
 var strUpdUser = objSysSkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conSysSkillVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.UpdUser); //修改人
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.UpdDate))
 {
 if (objSysSkillVerEN.UpdDate !=  null)
 {
 var strUpdDate = objSysSkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSysSkillVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.UpdDate); //修改日期
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.CitationId))
 {
 if (objSysSkillVerEN.CitationId !=  null)
 {
 var strCitationId = objSysSkillVerEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conSysSkillVer.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.CitationId); //引用Id
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.IdCurrEduCls))
 {
 if (objSysSkillVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objSysSkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conSysSkillVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.PdfContent))
 {
 if (objSysSkillVerEN.PdfContent !=  null)
 {
 var strPdfContent = objSysSkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conSysSkillVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.PdfContent); //Pdf内容
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.PdfPageNum))
 {
 if (objSysSkillVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSysSkillVerEN.PdfPageNum, conSysSkillVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objSysSkillVerEN.IsUpdated(conSysSkillVer.Memo))
 {
 if (objSysSkillVerEN.Memo !=  null)
 {
 var strMemo = objSysSkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysSkillVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysSkillVer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SkillVId = {0}", objSysSkillVerEN.SkillVId); 
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngSkillVId,
};
 objSQL.ExecSP("SysSkillVer_Delete", values);
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
//删除SysSkillVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSkillVer where SkillVId = " + ""+ lngSkillVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSysSkillVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
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
//删除SysSkillVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSkillVer where SkillVId in (" + strKeyList + ")";
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
//删除SysSkillVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysSkillVer where SkillVId = " + ""+ lngSkillVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSysSkillVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSysSkillVerDA: DelSysSkillVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysSkillVer where " + strCondition ;
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
public bool DelSysSkillVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSysSkillVerDA: DelSysSkillVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysSkillVer where " + strCondition ;
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
 /// <param name = "objSysSkillVerENS">源对象</param>
 /// <param name = "objSysSkillVerENT">目标对象</param>
public void CopyTo(clsSysSkillVerEN objSysSkillVerENS, clsSysSkillVerEN objSysSkillVerENT)
{
objSysSkillVerENT.SkillVId = objSysSkillVerENS.SkillVId; //SkillVId
objSysSkillVerENT.SkillId = objSysSkillVerENS.SkillId; //技能Id
objSysSkillVerENT.SkillName = objSysSkillVerENS.SkillName; //技能名称
objSysSkillVerENT.OperationTypeId = objSysSkillVerENS.OperationTypeId; //操作类型ID
objSysSkillVerENT.Process = objSysSkillVerENS.Process; //实施过程
objSysSkillVerENT.LevelId = objSysSkillVerENS.LevelId; //级别Id
objSysSkillVerENT.UpdUser = objSysSkillVerENS.UpdUser; //修改人
objSysSkillVerENT.UpdDate = objSysSkillVerENS.UpdDate; //修改日期
objSysSkillVerENT.CitationId = objSysSkillVerENS.CitationId; //引用Id
objSysSkillVerENT.IdCurrEduCls = objSysSkillVerENS.IdCurrEduCls; //教学班流水号
objSysSkillVerENT.PdfContent = objSysSkillVerENS.PdfContent; //Pdf内容
objSysSkillVerENT.PdfPageNum = objSysSkillVerENS.PdfPageNum; //Pdf页码
objSysSkillVerENT.Memo = objSysSkillVerENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSysSkillVerEN objSysSkillVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSysSkillVerEN.SkillId, conSysSkillVer.SkillId);
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSkillVerEN.SkillId, 10, conSysSkillVer.SkillId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.SkillName, 200, conSysSkillVer.SkillName);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.OperationTypeId, 4, conSysSkillVer.OperationTypeId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.LevelId, 2, conSysSkillVer.LevelId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.UpdUser, 20, conSysSkillVer.UpdUser);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.UpdDate, 20, conSysSkillVer.UpdDate);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.CitationId, 8, conSysSkillVer.CitationId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.IdCurrEduCls, 8, conSysSkillVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.PdfContent, 2000, conSysSkillVer.PdfContent);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.Memo, 1000, conSysSkillVer.Memo);
//检查字段外键固定长度
 objSysSkillVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSysSkillVerEN objSysSkillVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSkillVerEN.SkillId, 10, conSysSkillVer.SkillId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.SkillName, 200, conSysSkillVer.SkillName);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.OperationTypeId, 4, conSysSkillVer.OperationTypeId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.LevelId, 2, conSysSkillVer.LevelId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.UpdUser, 20, conSysSkillVer.UpdUser);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.UpdDate, 20, conSysSkillVer.UpdDate);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.CitationId, 8, conSysSkillVer.CitationId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.IdCurrEduCls, 8, conSysSkillVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.PdfContent, 2000, conSysSkillVer.PdfContent);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.Memo, 1000, conSysSkillVer.Memo);
//检查外键字段长度
 objSysSkillVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSysSkillVerEN objSysSkillVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysSkillVerEN.SkillId, 10, conSysSkillVer.SkillId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.SkillName, 200, conSysSkillVer.SkillName);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.OperationTypeId, 4, conSysSkillVer.OperationTypeId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.LevelId, 2, conSysSkillVer.LevelId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.UpdUser, 20, conSysSkillVer.UpdUser);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.UpdDate, 20, conSysSkillVer.UpdDate);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.CitationId, 8, conSysSkillVer.CitationId);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.IdCurrEduCls, 8, conSysSkillVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.PdfContent, 2000, conSysSkillVer.PdfContent);
clsCheckSql.CheckFieldLen(objSysSkillVerEN.Memo, 1000, conSysSkillVer.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSysSkillVerEN.SkillId, conSysSkillVer.SkillId);
clsCheckSql.CheckSqlInjection4Field(objSysSkillVerEN.SkillName, conSysSkillVer.SkillName);
clsCheckSql.CheckSqlInjection4Field(objSysSkillVerEN.OperationTypeId, conSysSkillVer.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objSysSkillVerEN.LevelId, conSysSkillVer.LevelId);
clsCheckSql.CheckSqlInjection4Field(objSysSkillVerEN.UpdUser, conSysSkillVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objSysSkillVerEN.UpdDate, conSysSkillVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSysSkillVerEN.CitationId, conSysSkillVer.CitationId);
clsCheckSql.CheckSqlInjection4Field(objSysSkillVerEN.IdCurrEduCls, conSysSkillVer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objSysSkillVerEN.PdfContent, conSysSkillVer.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objSysSkillVerEN.Memo, conSysSkillVer.Memo);
//检查外键字段长度
 objSysSkillVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SysSkillVer(系统技能版本),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysSkillVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSysSkillVerEN objSysSkillVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SkillVId = '{0}'", objSysSkillVerEN.SkillVId);
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysSkillVerEN._CurrTabName);
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysSkillVerEN._CurrTabName, strCondition);
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
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
 objSQL = clsSysSkillVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}