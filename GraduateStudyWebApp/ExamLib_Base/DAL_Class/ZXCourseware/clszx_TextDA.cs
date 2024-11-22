
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TextDA
 表名:zx_Text(01120704)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:53:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 中学课件表(zx_Text)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_TextDA : clsCommBase4DA
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
 return clszx_TextEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_TextEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TextEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_TextEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_TextEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTextId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTextId)
{
strTextId = strTextId.Replace("'", "''");
if (strTextId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:zx_Text中,检查关键字,长度不正确!(clszx_TextDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTextId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_Text中,关键字不能为空 或 null!(clszx_TextDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_TextDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_TextDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
strSQL = "Select * from zx_Text where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_Text(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_TextDA: GetDataTable_zx_Text)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
strSQL = "Select * from zx_Text where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_TextDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_TextDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
strSQL = "Select * from zx_Text where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_TextDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_TextDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Text where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Text where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_TextDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_Text where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_TextDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Text.* from zx_Text Left Join {1} on {2} where {3} and zx_Text.TextId not in (Select top {5} zx_Text.TextId from zx_Text Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Text where {1} and TextId not in (Select top {2} TextId from zx_Text where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Text where {1} and TextId not in (Select top {3} TextId from zx_Text where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_TextDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Text.* from zx_Text Left Join {1} on {2} where {3} and zx_Text.TextId not in (Select top {5} zx_Text.TextId from zx_Text Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Text where {1} and TextId not in (Select top {2} TextId from zx_Text where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Text where {1} and TextId not in (Select top {3} TextId from zx_Text where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_TextEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_TextDA:GetObjLst)", objException.Message));
}
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
strSQL = "Select * from zx_Text where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = TransNullToBool(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = TransNullToBool(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = TransNullToBool(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TextDA: GetObjLst)", objException.Message));
}
objzx_TextEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TextEN);
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
public List<clszx_TextEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_TextDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = TransNullToBool(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = TransNullToBool(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = TransNullToBool(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TextDA: GetObjLst)", objException.Message));
}
objzx_TextEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TextEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_TextEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_Text(ref clszx_TextEN objzx_TextEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
strSQL = "Select * from zx_Text where TextId = " + "'"+ objzx_TextEN.TextId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_TextEN.TextId = objDT.Rows[0][conzx_Text.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TextEN.TextTitle = objDT.Rows[0][conzx_Text.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objzx_TextEN.TextContent = objDT.Rows[0][conzx_Text.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TextEN.Edition = objDT.Rows[0][conzx_Text.Edition].ToString().Trim(); //Edition(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_TextEN.Author = objDT.Rows[0][conzx_Text.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_TextEN.ResearchQuestion = objDT.Rows[0][conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_TextEN.UpdDate = objDT.Rows[0][conzx_Text.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextEN.UpdUser = objDT.Rows[0][conzx_Text.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextEN.CreateDate = objDT.Rows[0][conzx_Text.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextEN.Checker = objDT.Rows[0][conzx_Text.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextEN.IdCurrEduCls = objDT.Rows[0][conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TextEN.Keyword = objDT.Rows[0][conzx_Text.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextEN.LiteratureSources = objDT.Rows[0][conzx_Text.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextEN.LiteratureLink = objDT.Rows[0][conzx_Text.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextEN.UploadfileUrl = objDT.Rows[0][conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_Text.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TextEN.IsChecked = TransNullToBool(objDT.Rows[0][conzx_Text.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TextEN.BrowseNumber = TransNullToInt(objDT.Rows[0][conzx_Text.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.VCount = TransNullToInt(objDT.Rows[0][conzx_Text.VCount].ToString().Trim()); //VCount(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_Text.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.CollectionCount = TransNullToInt(objDT.Rows[0][conzx_Text.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_TextEN.DownloadCount = TransNullToInt(objDT.Rows[0][conzx_Text.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.AttachmentCount = TransNullToInt(objDT.Rows[0][conzx_Text.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_Text.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.Score = TransNullToFloat(objDT.Rows[0][conzx_Text.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TextEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_Text.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TextEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_Text.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TextEN.TextTypeId = objDT.Rows[0][conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId(字段类型:char,字段长度:2,是否可空:True)
 objzx_TextEN.TextStatusId = objDT.Rows[0][conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId(字段类型:char,字段长度:2,是否可空:True)
 objzx_TextEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_Text.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.IsPublic = TransNullToBool(objDT.Rows[0][conzx_Text.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TextEN.zxShareId = objDT.Rows[0][conzx_Text.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_TextEN.SchoolTerm = objDT.Rows[0][conzx_Text.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objzx_TextEN.GradeId = objDT.Rows[0][conzx_Text.GradeId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objzx_TextEN.Memo = objDT.Rows[0][conzx_Text.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextEN.UnitId = objDT.Rows[0][conzx_Text.UnitId].ToString().Trim(); //UnitId(字段类型:char,字段长度:4,是否可空:True)
 objzx_TextEN.PaperQCount = TransNullToInt(objDT.Rows[0][conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.SubVCount = TransNullToInt(objDT.Rows[0][conzx_Text.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.TagsCount = TransNullToInt(objDT.Rows[0][conzx_Text.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.TeaQCount = TransNullToInt(objDT.Rows[0][conzx_Text.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_TextDA: Getzx_Text)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTextId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_TextEN GetObjByTextId(string strTextId)
{
CheckPrimaryKey(strTextId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
strSQL = "Select * from zx_Text where TextId = " + "'"+ strTextId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
 objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TextEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VCount].ToString().Trim()); //VCount(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId(字段类型:char,字段长度:2,是否可空:True)
 objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId(字段类型:char,字段长度:2,是否可空:True)
 objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId(字段类型:char,字段长度:4,是否可空:True)
 objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_TextDA: GetObjByTextId)", objException.Message));
}
return objzx_TextEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_TextEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_TextDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
strSQL = "Select * from zx_Text where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN()
{
TextId = objRow[conzx_Text.TextId].ToString().Trim(), //课件Id
TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(), //TextTitle
TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(), //TextContent
Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(), //Edition
Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(), //研究问题
UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(), //修改人
CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(), //建立日期
Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(), //审核人
IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(), //教学班流水号
Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(), //关键字
LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(), //文献来源
LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(), //文献链接
UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(), //文件地址
IsSubmit = TransNullToBool(objRow[conzx_Text.IsSubmit].ToString().Trim()), //是否提交
IsChecked = TransNullToBool(objRow[conzx_Text.IsChecked].ToString().Trim()), //是否检查
BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.BrowseNumber].ToString().Trim()), //浏览量
VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VCount].ToString().Trim()), //VCount
VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VoteCount].ToString().Trim()), //点赞计数
CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_Text.CollectionCount].ToString().Trim()), //收藏数量
DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.DownloadCount].ToString().Trim()), //下载数
AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.AttachmentCount].ToString().Trim()), //附件计数
AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.TeaScore].ToString().Trim()), //教师评分
TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(), //TextTypeId
TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(), //TextStatusId
VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VersionCount].ToString().Trim()), //版本统计
IsPublic = TransNullToBool(objRow[conzx_Text.IsPublic].ToString().Trim()), //是否公开
zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(), //分享Id
SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(), //学期
GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(), //年级代号
Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(), //备注
UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(), //UnitId
PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.PaperQCount].ToString().Trim()), //论文答疑数
SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.SubVCount].ToString().Trim()), //论文子观点数
TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.TagsCount].ToString().Trim()), //论文标注数
TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.TeaQCount].ToString().Trim()) //教师提问数
};
objzx_TextEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TextEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_TextDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_TextEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = TransNullToBool(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = TransNullToBool(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = TransNullToBool(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_TextDA: GetObjByDataRowzx_Text)", objException.Message));
}
objzx_TextEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TextEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_TextEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = TransNullToBool(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = TransNullToBool(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = TransNullToBool(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_TextDA: GetObjByDataRow)", objException.Message));
}
objzx_TextEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TextEN;
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
objSQL = clszx_TextDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TextEN._CurrTabName, conzx_Text.TextId, 8, "");
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
objSQL = clszx_TextDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TextEN._CurrTabName, conzx_Text.TextId, 8, strPrefix);
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
 objSQL = clszx_TextDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TextId from zx_Text where " + strCondition;
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
 objSQL = clszx_TextDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TextId from zx_Text where " + strCondition;
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
 /// <param name = "strTextId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTextId)
{
CheckPrimaryKey(strTextId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Text", "TextId = " + "'"+ strTextId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_TextDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Text", strCondition))
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
objSQL = clszx_TextDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_Text");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_TextEN objzx_TextEN)
 {
 if (objzx_TextEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TextEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
strSQL = "Select * from zx_Text where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Text");
objRow = objDS.Tables["zx_Text"].NewRow();
objRow[conzx_Text.TextId] = objzx_TextEN.TextId; //课件Id
objRow[conzx_Text.TextTitle] = objzx_TextEN.TextTitle; //TextTitle
 if (objzx_TextEN.TextContent !=  "")
 {
objRow[conzx_Text.TextContent] = objzx_TextEN.TextContent; //TextContent
 }
 if (objzx_TextEN.Edition !=  "")
 {
objRow[conzx_Text.Edition] = objzx_TextEN.Edition; //Edition
 }
 if (objzx_TextEN.Author !=  "")
 {
objRow[conzx_Text.Author] = objzx_TextEN.Author; //作者
 }
 if (objzx_TextEN.ResearchQuestion !=  "")
 {
objRow[conzx_Text.ResearchQuestion] = objzx_TextEN.ResearchQuestion; //研究问题
 }
 if (objzx_TextEN.UpdDate !=  "")
 {
objRow[conzx_Text.UpdDate] = objzx_TextEN.UpdDate; //修改日期
 }
 if (objzx_TextEN.UpdUser !=  "")
 {
objRow[conzx_Text.UpdUser] = objzx_TextEN.UpdUser; //修改人
 }
 if (objzx_TextEN.CreateDate !=  "")
 {
objRow[conzx_Text.CreateDate] = objzx_TextEN.CreateDate; //建立日期
 }
 if (objzx_TextEN.Checker !=  "")
 {
objRow[conzx_Text.Checker] = objzx_TextEN.Checker; //审核人
 }
 if (objzx_TextEN.IdCurrEduCls !=  "")
 {
objRow[conzx_Text.IdCurrEduCls] = objzx_TextEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_TextEN.Keyword !=  "")
 {
objRow[conzx_Text.Keyword] = objzx_TextEN.Keyword; //关键字
 }
 if (objzx_TextEN.LiteratureSources !=  "")
 {
objRow[conzx_Text.LiteratureSources] = objzx_TextEN.LiteratureSources; //文献来源
 }
 if (objzx_TextEN.LiteratureLink !=  "")
 {
objRow[conzx_Text.LiteratureLink] = objzx_TextEN.LiteratureLink; //文献链接
 }
 if (objzx_TextEN.UploadfileUrl !=  "")
 {
objRow[conzx_Text.UploadfileUrl] = objzx_TextEN.UploadfileUrl; //文件地址
 }
objRow[conzx_Text.IsSubmit] = objzx_TextEN.IsSubmit; //是否提交
objRow[conzx_Text.IsChecked] = objzx_TextEN.IsChecked; //是否检查
objRow[conzx_Text.BrowseNumber] = objzx_TextEN.BrowseNumber; //浏览量
objRow[conzx_Text.VCount] = objzx_TextEN.VCount; //VCount
objRow[conzx_Text.VoteCount] = objzx_TextEN.VoteCount; //点赞计数
objRow[conzx_Text.CollectionCount] = objzx_TextEN.CollectionCount; //收藏数量
objRow[conzx_Text.DownloadCount] = objzx_TextEN.DownloadCount; //下载数
objRow[conzx_Text.AttachmentCount] = objzx_TextEN.AttachmentCount; //附件计数
objRow[conzx_Text.AppraiseCount] = objzx_TextEN.AppraiseCount; //评论数
objRow[conzx_Text.Score] = objzx_TextEN.Score; //评分
objRow[conzx_Text.StuScore] = objzx_TextEN.StuScore; //学生平均分
objRow[conzx_Text.TeaScore] = objzx_TextEN.TeaScore; //教师评分
 if (objzx_TextEN.TextTypeId !=  "")
 {
objRow[conzx_Text.TextTypeId] = objzx_TextEN.TextTypeId; //TextTypeId
 }
 if (objzx_TextEN.TextStatusId !=  "")
 {
objRow[conzx_Text.TextStatusId] = objzx_TextEN.TextStatusId; //TextStatusId
 }
objRow[conzx_Text.VersionCount] = objzx_TextEN.VersionCount; //版本统计
objRow[conzx_Text.IsPublic] = objzx_TextEN.IsPublic; //是否公开
 if (objzx_TextEN.zxShareId !=  "")
 {
objRow[conzx_Text.zxShareId] = objzx_TextEN.zxShareId; //分享Id
 }
 if (objzx_TextEN.SchoolTerm !=  "")
 {
objRow[conzx_Text.SchoolTerm] = objzx_TextEN.SchoolTerm; //学期
 }
 if (objzx_TextEN.GradeId !=  "")
 {
objRow[conzx_Text.GradeId] = objzx_TextEN.GradeId; //年级代号
 }
 if (objzx_TextEN.Memo !=  "")
 {
objRow[conzx_Text.Memo] = objzx_TextEN.Memo; //备注
 }
 if (objzx_TextEN.UnitId !=  "")
 {
objRow[conzx_Text.UnitId] = objzx_TextEN.UnitId; //UnitId
 }
objRow[conzx_Text.PaperQCount] = objzx_TextEN.PaperQCount; //论文答疑数
objRow[conzx_Text.SubVCount] = objzx_TextEN.SubVCount; //论文子观点数
objRow[conzx_Text.TagsCount] = objzx_TextEN.TagsCount; //论文标注数
objRow[conzx_Text.TeaQCount] = objzx_TextEN.TeaQCount; //教师提问数
objDS.Tables[clszx_TextEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_TextEN._CurrTabName);
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
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TextEN objzx_TextEN)
{
 if (objzx_TextEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TextEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TextEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextId);
 var strTextId = objzx_TextEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TextEN.TextTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextTitle);
 var strTextTitle = objzx_TextEN.TextTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextTitle + "'");
 }
 
 if (objzx_TextEN.TextContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextContent);
 var strTextContent = objzx_TextEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextContent + "'");
 }
 
 if (objzx_TextEN.Edition !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Edition);
 var strEdition = objzx_TextEN.Edition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEdition + "'");
 }
 
 if (objzx_TextEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Author);
 var strAuthor = objzx_TextEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_TextEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.ResearchQuestion);
 var strResearchQuestion = objzx_TextEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objzx_TextEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UpdDate);
 var strUpdDate = objzx_TextEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TextEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UpdUser);
 var strUpdUser = objzx_TextEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TextEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.CreateDate);
 var strCreateDate = objzx_TextEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TextEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Checker);
 var strChecker = objzx_TextEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objzx_TextEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TextEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TextEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Keyword);
 var strKeyword = objzx_TextEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objzx_TextEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.LiteratureSources);
 var strLiteratureSources = objzx_TextEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objzx_TextEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.LiteratureLink);
 var strLiteratureLink = objzx_TextEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objzx_TextEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UploadfileUrl);
 var strUploadfileUrl = objzx_TextEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Text.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Text.IsChecked);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.BrowseNumber);
 arrValueListForInsert.Add(objzx_TextEN.BrowseNumber.ToString());
 }
 
 if (objzx_TextEN.VCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VCount);
 arrValueListForInsert.Add(objzx_TextEN.VCount.ToString());
 }
 
 if (objzx_TextEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VoteCount);
 arrValueListForInsert.Add(objzx_TextEN.VoteCount.ToString());
 }
 
 if (objzx_TextEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.CollectionCount);
 arrValueListForInsert.Add(objzx_TextEN.CollectionCount.ToString());
 }
 
 if (objzx_TextEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.DownloadCount);
 arrValueListForInsert.Add(objzx_TextEN.DownloadCount.ToString());
 }
 
 if (objzx_TextEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.AttachmentCount);
 arrValueListForInsert.Add(objzx_TextEN.AttachmentCount.ToString());
 }
 
 if (objzx_TextEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.AppraiseCount);
 arrValueListForInsert.Add(objzx_TextEN.AppraiseCount.ToString());
 }
 
 if (objzx_TextEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Score);
 arrValueListForInsert.Add(objzx_TextEN.Score.ToString());
 }
 
 if (objzx_TextEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.StuScore);
 arrValueListForInsert.Add(objzx_TextEN.StuScore.ToString());
 }
 
 if (objzx_TextEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TeaScore);
 arrValueListForInsert.Add(objzx_TextEN.TeaScore.ToString());
 }
 
 if (objzx_TextEN.TextTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextTypeId);
 var strTextTypeId = objzx_TextEN.TextTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextTypeId + "'");
 }
 
 if (objzx_TextEN.TextStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextStatusId);
 var strTextStatusId = objzx_TextEN.TextStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextStatusId + "'");
 }
 
 if (objzx_TextEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VersionCount);
 arrValueListForInsert.Add(objzx_TextEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Text.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.zxShareId);
 var strzxShareId = objzx_TextEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TextEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.SchoolTerm);
 var strSchoolTerm = objzx_TextEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objzx_TextEN.GradeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.GradeId);
 var strGradeId = objzx_TextEN.GradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeId + "'");
 }
 
 if (objzx_TextEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Memo);
 var strMemo = objzx_TextEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TextEN.UnitId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UnitId);
 var strUnitId = objzx_TextEN.UnitId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUnitId + "'");
 }
 
 if (objzx_TextEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.PaperQCount);
 arrValueListForInsert.Add(objzx_TextEN.PaperQCount.ToString());
 }
 
 if (objzx_TextEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.SubVCount);
 arrValueListForInsert.Add(objzx_TextEN.SubVCount.ToString());
 }
 
 if (objzx_TextEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TagsCount);
 arrValueListForInsert.Add(objzx_TextEN.TagsCount.ToString());
 }
 
 if (objzx_TextEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TeaQCount);
 arrValueListForInsert.Add(objzx_TextEN.TeaQCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Text");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TextEN objzx_TextEN)
{
 if (objzx_TextEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TextEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TextEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextId);
 var strTextId = objzx_TextEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TextEN.TextTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextTitle);
 var strTextTitle = objzx_TextEN.TextTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextTitle + "'");
 }
 
 if (objzx_TextEN.TextContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextContent);
 var strTextContent = objzx_TextEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextContent + "'");
 }
 
 if (objzx_TextEN.Edition !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Edition);
 var strEdition = objzx_TextEN.Edition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEdition + "'");
 }
 
 if (objzx_TextEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Author);
 var strAuthor = objzx_TextEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_TextEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.ResearchQuestion);
 var strResearchQuestion = objzx_TextEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objzx_TextEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UpdDate);
 var strUpdDate = objzx_TextEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TextEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UpdUser);
 var strUpdUser = objzx_TextEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TextEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.CreateDate);
 var strCreateDate = objzx_TextEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TextEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Checker);
 var strChecker = objzx_TextEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objzx_TextEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TextEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TextEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Keyword);
 var strKeyword = objzx_TextEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objzx_TextEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.LiteratureSources);
 var strLiteratureSources = objzx_TextEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objzx_TextEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.LiteratureLink);
 var strLiteratureLink = objzx_TextEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objzx_TextEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UploadfileUrl);
 var strUploadfileUrl = objzx_TextEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Text.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Text.IsChecked);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.BrowseNumber);
 arrValueListForInsert.Add(objzx_TextEN.BrowseNumber.ToString());
 }
 
 if (objzx_TextEN.VCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VCount);
 arrValueListForInsert.Add(objzx_TextEN.VCount.ToString());
 }
 
 if (objzx_TextEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VoteCount);
 arrValueListForInsert.Add(objzx_TextEN.VoteCount.ToString());
 }
 
 if (objzx_TextEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.CollectionCount);
 arrValueListForInsert.Add(objzx_TextEN.CollectionCount.ToString());
 }
 
 if (objzx_TextEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.DownloadCount);
 arrValueListForInsert.Add(objzx_TextEN.DownloadCount.ToString());
 }
 
 if (objzx_TextEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.AttachmentCount);
 arrValueListForInsert.Add(objzx_TextEN.AttachmentCount.ToString());
 }
 
 if (objzx_TextEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.AppraiseCount);
 arrValueListForInsert.Add(objzx_TextEN.AppraiseCount.ToString());
 }
 
 if (objzx_TextEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Score);
 arrValueListForInsert.Add(objzx_TextEN.Score.ToString());
 }
 
 if (objzx_TextEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.StuScore);
 arrValueListForInsert.Add(objzx_TextEN.StuScore.ToString());
 }
 
 if (objzx_TextEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TeaScore);
 arrValueListForInsert.Add(objzx_TextEN.TeaScore.ToString());
 }
 
 if (objzx_TextEN.TextTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextTypeId);
 var strTextTypeId = objzx_TextEN.TextTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextTypeId + "'");
 }
 
 if (objzx_TextEN.TextStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextStatusId);
 var strTextStatusId = objzx_TextEN.TextStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextStatusId + "'");
 }
 
 if (objzx_TextEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VersionCount);
 arrValueListForInsert.Add(objzx_TextEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Text.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.zxShareId);
 var strzxShareId = objzx_TextEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TextEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.SchoolTerm);
 var strSchoolTerm = objzx_TextEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objzx_TextEN.GradeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.GradeId);
 var strGradeId = objzx_TextEN.GradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeId + "'");
 }
 
 if (objzx_TextEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Memo);
 var strMemo = objzx_TextEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TextEN.UnitId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UnitId);
 var strUnitId = objzx_TextEN.UnitId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUnitId + "'");
 }
 
 if (objzx_TextEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.PaperQCount);
 arrValueListForInsert.Add(objzx_TextEN.PaperQCount.ToString());
 }
 
 if (objzx_TextEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.SubVCount);
 arrValueListForInsert.Add(objzx_TextEN.SubVCount.ToString());
 }
 
 if (objzx_TextEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TagsCount);
 arrValueListForInsert.Add(objzx_TextEN.TagsCount.ToString());
 }
 
 if (objzx_TextEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TeaQCount);
 arrValueListForInsert.Add(objzx_TextEN.TeaQCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Text");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_TextEN.TextId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TextEN objzx_TextEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TextEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TextEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TextEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextId);
 var strTextId = objzx_TextEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TextEN.TextTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextTitle);
 var strTextTitle = objzx_TextEN.TextTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextTitle + "'");
 }
 
 if (objzx_TextEN.TextContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextContent);
 var strTextContent = objzx_TextEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextContent + "'");
 }
 
 if (objzx_TextEN.Edition !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Edition);
 var strEdition = objzx_TextEN.Edition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEdition + "'");
 }
 
 if (objzx_TextEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Author);
 var strAuthor = objzx_TextEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_TextEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.ResearchQuestion);
 var strResearchQuestion = objzx_TextEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objzx_TextEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UpdDate);
 var strUpdDate = objzx_TextEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TextEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UpdUser);
 var strUpdUser = objzx_TextEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TextEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.CreateDate);
 var strCreateDate = objzx_TextEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TextEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Checker);
 var strChecker = objzx_TextEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objzx_TextEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TextEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TextEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Keyword);
 var strKeyword = objzx_TextEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objzx_TextEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.LiteratureSources);
 var strLiteratureSources = objzx_TextEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objzx_TextEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.LiteratureLink);
 var strLiteratureLink = objzx_TextEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objzx_TextEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UploadfileUrl);
 var strUploadfileUrl = objzx_TextEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Text.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Text.IsChecked);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.BrowseNumber);
 arrValueListForInsert.Add(objzx_TextEN.BrowseNumber.ToString());
 }
 
 if (objzx_TextEN.VCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VCount);
 arrValueListForInsert.Add(objzx_TextEN.VCount.ToString());
 }
 
 if (objzx_TextEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VoteCount);
 arrValueListForInsert.Add(objzx_TextEN.VoteCount.ToString());
 }
 
 if (objzx_TextEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.CollectionCount);
 arrValueListForInsert.Add(objzx_TextEN.CollectionCount.ToString());
 }
 
 if (objzx_TextEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.DownloadCount);
 arrValueListForInsert.Add(objzx_TextEN.DownloadCount.ToString());
 }
 
 if (objzx_TextEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.AttachmentCount);
 arrValueListForInsert.Add(objzx_TextEN.AttachmentCount.ToString());
 }
 
 if (objzx_TextEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.AppraiseCount);
 arrValueListForInsert.Add(objzx_TextEN.AppraiseCount.ToString());
 }
 
 if (objzx_TextEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Score);
 arrValueListForInsert.Add(objzx_TextEN.Score.ToString());
 }
 
 if (objzx_TextEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.StuScore);
 arrValueListForInsert.Add(objzx_TextEN.StuScore.ToString());
 }
 
 if (objzx_TextEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TeaScore);
 arrValueListForInsert.Add(objzx_TextEN.TeaScore.ToString());
 }
 
 if (objzx_TextEN.TextTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextTypeId);
 var strTextTypeId = objzx_TextEN.TextTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextTypeId + "'");
 }
 
 if (objzx_TextEN.TextStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextStatusId);
 var strTextStatusId = objzx_TextEN.TextStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextStatusId + "'");
 }
 
 if (objzx_TextEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VersionCount);
 arrValueListForInsert.Add(objzx_TextEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Text.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.zxShareId);
 var strzxShareId = objzx_TextEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TextEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.SchoolTerm);
 var strSchoolTerm = objzx_TextEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objzx_TextEN.GradeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.GradeId);
 var strGradeId = objzx_TextEN.GradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeId + "'");
 }
 
 if (objzx_TextEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Memo);
 var strMemo = objzx_TextEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TextEN.UnitId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UnitId);
 var strUnitId = objzx_TextEN.UnitId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUnitId + "'");
 }
 
 if (objzx_TextEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.PaperQCount);
 arrValueListForInsert.Add(objzx_TextEN.PaperQCount.ToString());
 }
 
 if (objzx_TextEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.SubVCount);
 arrValueListForInsert.Add(objzx_TextEN.SubVCount.ToString());
 }
 
 if (objzx_TextEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TagsCount);
 arrValueListForInsert.Add(objzx_TextEN.TagsCount.ToString());
 }
 
 if (objzx_TextEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TeaQCount);
 arrValueListForInsert.Add(objzx_TextEN.TeaQCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Text");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_TextEN.TextId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TextEN objzx_TextEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TextEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TextEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TextEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextId);
 var strTextId = objzx_TextEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TextEN.TextTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextTitle);
 var strTextTitle = objzx_TextEN.TextTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextTitle + "'");
 }
 
 if (objzx_TextEN.TextContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextContent);
 var strTextContent = objzx_TextEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextContent + "'");
 }
 
 if (objzx_TextEN.Edition !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Edition);
 var strEdition = objzx_TextEN.Edition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEdition + "'");
 }
 
 if (objzx_TextEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Author);
 var strAuthor = objzx_TextEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_TextEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.ResearchQuestion);
 var strResearchQuestion = objzx_TextEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objzx_TextEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UpdDate);
 var strUpdDate = objzx_TextEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TextEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UpdUser);
 var strUpdUser = objzx_TextEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TextEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.CreateDate);
 var strCreateDate = objzx_TextEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_TextEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Checker);
 var strChecker = objzx_TextEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objzx_TextEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TextEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TextEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Keyword);
 var strKeyword = objzx_TextEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objzx_TextEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.LiteratureSources);
 var strLiteratureSources = objzx_TextEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objzx_TextEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.LiteratureLink);
 var strLiteratureLink = objzx_TextEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objzx_TextEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UploadfileUrl);
 var strUploadfileUrl = objzx_TextEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Text.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Text.IsChecked);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.BrowseNumber);
 arrValueListForInsert.Add(objzx_TextEN.BrowseNumber.ToString());
 }
 
 if (objzx_TextEN.VCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VCount);
 arrValueListForInsert.Add(objzx_TextEN.VCount.ToString());
 }
 
 if (objzx_TextEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VoteCount);
 arrValueListForInsert.Add(objzx_TextEN.VoteCount.ToString());
 }
 
 if (objzx_TextEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.CollectionCount);
 arrValueListForInsert.Add(objzx_TextEN.CollectionCount.ToString());
 }
 
 if (objzx_TextEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.DownloadCount);
 arrValueListForInsert.Add(objzx_TextEN.DownloadCount.ToString());
 }
 
 if (objzx_TextEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.AttachmentCount);
 arrValueListForInsert.Add(objzx_TextEN.AttachmentCount.ToString());
 }
 
 if (objzx_TextEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.AppraiseCount);
 arrValueListForInsert.Add(objzx_TextEN.AppraiseCount.ToString());
 }
 
 if (objzx_TextEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Score);
 arrValueListForInsert.Add(objzx_TextEN.Score.ToString());
 }
 
 if (objzx_TextEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.StuScore);
 arrValueListForInsert.Add(objzx_TextEN.StuScore.ToString());
 }
 
 if (objzx_TextEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TeaScore);
 arrValueListForInsert.Add(objzx_TextEN.TeaScore.ToString());
 }
 
 if (objzx_TextEN.TextTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextTypeId);
 var strTextTypeId = objzx_TextEN.TextTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextTypeId + "'");
 }
 
 if (objzx_TextEN.TextStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TextStatusId);
 var strTextStatusId = objzx_TextEN.TextStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextStatusId + "'");
 }
 
 if (objzx_TextEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.VersionCount);
 arrValueListForInsert.Add(objzx_TextEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Text.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_TextEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_TextEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.zxShareId);
 var strzxShareId = objzx_TextEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TextEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.SchoolTerm);
 var strSchoolTerm = objzx_TextEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objzx_TextEN.GradeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.GradeId);
 var strGradeId = objzx_TextEN.GradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGradeId + "'");
 }
 
 if (objzx_TextEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.Memo);
 var strMemo = objzx_TextEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TextEN.UnitId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.UnitId);
 var strUnitId = objzx_TextEN.UnitId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUnitId + "'");
 }
 
 if (objzx_TextEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.PaperQCount);
 arrValueListForInsert.Add(objzx_TextEN.PaperQCount.ToString());
 }
 
 if (objzx_TextEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.SubVCount);
 arrValueListForInsert.Add(objzx_TextEN.SubVCount.ToString());
 }
 
 if (objzx_TextEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TagsCount);
 arrValueListForInsert.Add(objzx_TextEN.TagsCount.ToString());
 }
 
 if (objzx_TextEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Text.TeaQCount);
 arrValueListForInsert.Add(objzx_TextEN.TeaQCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Text");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_Texts(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
strSQL = "Select * from zx_Text where TextId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Text");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTextId = oRow[conzx_Text.TextId].ToString().Trim();
if (IsExist(strTextId))
{
 string strResult = "关键字变量值为:" + string.Format("TextId = {0}", strTextId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_TextEN._CurrTabName ].NewRow();
objRow[conzx_Text.TextId] = oRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objRow[conzx_Text.TextTitle] = oRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objRow[conzx_Text.TextContent] = oRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objRow[conzx_Text.Edition] = oRow[conzx_Text.Edition].ToString().Trim(); //Edition
objRow[conzx_Text.Author] = oRow[conzx_Text.Author].ToString().Trim(); //作者
objRow[conzx_Text.ResearchQuestion] = oRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objRow[conzx_Text.UpdDate] = oRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_Text.UpdUser] = oRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objRow[conzx_Text.CreateDate] = oRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_Text.Checker] = oRow[conzx_Text.Checker].ToString().Trim(); //审核人
objRow[conzx_Text.IdCurrEduCls] = oRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_Text.Keyword] = oRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objRow[conzx_Text.LiteratureSources] = oRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objRow[conzx_Text.LiteratureLink] = oRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objRow[conzx_Text.UploadfileUrl] = oRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objRow[conzx_Text.IsSubmit] = oRow[conzx_Text.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_Text.IsChecked] = oRow[conzx_Text.IsChecked].ToString().Trim(); //是否检查
objRow[conzx_Text.BrowseNumber] = oRow[conzx_Text.BrowseNumber].ToString().Trim(); //浏览量
objRow[conzx_Text.VCount] = oRow[conzx_Text.VCount].ToString().Trim(); //VCount
objRow[conzx_Text.VoteCount] = oRow[conzx_Text.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_Text.CollectionCount] = oRow[conzx_Text.CollectionCount].ToString().Trim(); //收藏数量
objRow[conzx_Text.DownloadCount] = oRow[conzx_Text.DownloadCount].ToString().Trim(); //下载数
objRow[conzx_Text.AttachmentCount] = oRow[conzx_Text.AttachmentCount].ToString().Trim(); //附件计数
objRow[conzx_Text.AppraiseCount] = oRow[conzx_Text.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_Text.Score] = oRow[conzx_Text.Score].ToString().Trim(); //评分
objRow[conzx_Text.StuScore] = oRow[conzx_Text.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_Text.TeaScore] = oRow[conzx_Text.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_Text.TextTypeId] = oRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objRow[conzx_Text.TextStatusId] = oRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objRow[conzx_Text.VersionCount] = oRow[conzx_Text.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_Text.IsPublic] = oRow[conzx_Text.IsPublic].ToString().Trim(); //是否公开
objRow[conzx_Text.zxShareId] = oRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_Text.SchoolTerm] = oRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objRow[conzx_Text.GradeId] = oRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objRow[conzx_Text.Memo] = oRow[conzx_Text.Memo].ToString().Trim(); //备注
objRow[conzx_Text.UnitId] = oRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objRow[conzx_Text.PaperQCount] = oRow[conzx_Text.PaperQCount].ToString().Trim(); //论文答疑数
objRow[conzx_Text.SubVCount] = oRow[conzx_Text.SubVCount].ToString().Trim(); //论文子观点数
objRow[conzx_Text.TagsCount] = oRow[conzx_Text.TagsCount].ToString().Trim(); //论文标注数
objRow[conzx_Text.TeaQCount] = oRow[conzx_Text.TeaQCount].ToString().Trim(); //教师提问数
 objDS.Tables[clszx_TextEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_TextEN._CurrTabName);
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
 /// <param name = "objzx_TextEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_TextEN objzx_TextEN)
{
 if (objzx_TextEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TextEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
strSQL = "Select * from zx_Text where TextId = " + "'"+ objzx_TextEN.TextId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_TextEN._CurrTabName);
if (objDS.Tables[clszx_TextEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TextId = " + "'"+ objzx_TextEN.TextId+"'");
return false;
}
objRow = objDS.Tables[clszx_TextEN._CurrTabName].Rows[0];
 if (objzx_TextEN.IsUpdated(conzx_Text.TextId))
 {
objRow[conzx_Text.TextId] = objzx_TextEN.TextId; //课件Id
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.TextTitle))
 {
objRow[conzx_Text.TextTitle] = objzx_TextEN.TextTitle; //TextTitle
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.TextContent))
 {
objRow[conzx_Text.TextContent] = objzx_TextEN.TextContent; //TextContent
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.Edition))
 {
objRow[conzx_Text.Edition] = objzx_TextEN.Edition; //Edition
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.Author))
 {
objRow[conzx_Text.Author] = objzx_TextEN.Author; //作者
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.ResearchQuestion))
 {
objRow[conzx_Text.ResearchQuestion] = objzx_TextEN.ResearchQuestion; //研究问题
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.UpdDate))
 {
objRow[conzx_Text.UpdDate] = objzx_TextEN.UpdDate; //修改日期
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.UpdUser))
 {
objRow[conzx_Text.UpdUser] = objzx_TextEN.UpdUser; //修改人
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.CreateDate))
 {
objRow[conzx_Text.CreateDate] = objzx_TextEN.CreateDate; //建立日期
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.Checker))
 {
objRow[conzx_Text.Checker] = objzx_TextEN.Checker; //审核人
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.IdCurrEduCls))
 {
objRow[conzx_Text.IdCurrEduCls] = objzx_TextEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.Keyword))
 {
objRow[conzx_Text.Keyword] = objzx_TextEN.Keyword; //关键字
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.LiteratureSources))
 {
objRow[conzx_Text.LiteratureSources] = objzx_TextEN.LiteratureSources; //文献来源
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.LiteratureLink))
 {
objRow[conzx_Text.LiteratureLink] = objzx_TextEN.LiteratureLink; //文献链接
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.UploadfileUrl))
 {
objRow[conzx_Text.UploadfileUrl] = objzx_TextEN.UploadfileUrl; //文件地址
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.IsSubmit))
 {
objRow[conzx_Text.IsSubmit] = objzx_TextEN.IsSubmit; //是否提交
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.IsChecked))
 {
objRow[conzx_Text.IsChecked] = objzx_TextEN.IsChecked; //是否检查
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.BrowseNumber))
 {
objRow[conzx_Text.BrowseNumber] = objzx_TextEN.BrowseNumber; //浏览量
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.VCount))
 {
objRow[conzx_Text.VCount] = objzx_TextEN.VCount; //VCount
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.VoteCount))
 {
objRow[conzx_Text.VoteCount] = objzx_TextEN.VoteCount; //点赞计数
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.CollectionCount))
 {
objRow[conzx_Text.CollectionCount] = objzx_TextEN.CollectionCount; //收藏数量
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.DownloadCount))
 {
objRow[conzx_Text.DownloadCount] = objzx_TextEN.DownloadCount; //下载数
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.AttachmentCount))
 {
objRow[conzx_Text.AttachmentCount] = objzx_TextEN.AttachmentCount; //附件计数
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.AppraiseCount))
 {
objRow[conzx_Text.AppraiseCount] = objzx_TextEN.AppraiseCount; //评论数
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.Score))
 {
objRow[conzx_Text.Score] = objzx_TextEN.Score; //评分
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.StuScore))
 {
objRow[conzx_Text.StuScore] = objzx_TextEN.StuScore; //学生平均分
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.TeaScore))
 {
objRow[conzx_Text.TeaScore] = objzx_TextEN.TeaScore; //教师评分
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.TextTypeId))
 {
objRow[conzx_Text.TextTypeId] = objzx_TextEN.TextTypeId; //TextTypeId
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.TextStatusId))
 {
objRow[conzx_Text.TextStatusId] = objzx_TextEN.TextStatusId; //TextStatusId
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.VersionCount))
 {
objRow[conzx_Text.VersionCount] = objzx_TextEN.VersionCount; //版本统计
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.IsPublic))
 {
objRow[conzx_Text.IsPublic] = objzx_TextEN.IsPublic; //是否公开
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.zxShareId))
 {
objRow[conzx_Text.zxShareId] = objzx_TextEN.zxShareId; //分享Id
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.SchoolTerm))
 {
objRow[conzx_Text.SchoolTerm] = objzx_TextEN.SchoolTerm; //学期
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.GradeId))
 {
objRow[conzx_Text.GradeId] = objzx_TextEN.GradeId; //年级代号
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.Memo))
 {
objRow[conzx_Text.Memo] = objzx_TextEN.Memo; //备注
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.UnitId))
 {
objRow[conzx_Text.UnitId] = objzx_TextEN.UnitId; //UnitId
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.PaperQCount))
 {
objRow[conzx_Text.PaperQCount] = objzx_TextEN.PaperQCount; //论文答疑数
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.SubVCount))
 {
objRow[conzx_Text.SubVCount] = objzx_TextEN.SubVCount; //论文子观点数
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.TagsCount))
 {
objRow[conzx_Text.TagsCount] = objzx_TextEN.TagsCount; //论文标注数
 }
 if (objzx_TextEN.IsUpdated(conzx_Text.TeaQCount))
 {
objRow[conzx_Text.TeaQCount] = objzx_TextEN.TeaQCount; //教师提问数
 }
try
{
objDA.Update(objDS, clszx_TextEN._CurrTabName);
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
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TextEN objzx_TextEN)
{
 if (objzx_TextEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TextEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_Text Set ");
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextTitle))
 {
 if (objzx_TextEN.TextTitle !=  null)
 {
 var strTextTitle = objzx_TextEN.TextTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextTitle, conzx_Text.TextTitle); //TextTitle
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TextTitle); //TextTitle
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextContent))
 {
 if (objzx_TextEN.TextContent !=  null)
 {
 var strTextContent = objzx_TextEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextContent, conzx_Text.TextContent); //TextContent
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TextContent); //TextContent
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Edition))
 {
 if (objzx_TextEN.Edition !=  null)
 {
 var strEdition = objzx_TextEN.Edition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEdition, conzx_Text.Edition); //Edition
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Edition); //Edition
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Author))
 {
 if (objzx_TextEN.Author !=  null)
 {
 var strAuthor = objzx_TextEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, conzx_Text.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Author); //作者
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.ResearchQuestion))
 {
 if (objzx_TextEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objzx_TextEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchQuestion, conzx_Text.ResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.ResearchQuestion); //研究问题
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UpdDate))
 {
 if (objzx_TextEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TextEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Text.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.UpdDate); //修改日期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UpdUser))
 {
 if (objzx_TextEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TextEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Text.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.UpdUser); //修改人
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.CreateDate))
 {
 if (objzx_TextEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TextEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Text.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.CreateDate); //建立日期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Checker))
 {
 if (objzx_TextEN.Checker !=  null)
 {
 var strChecker = objzx_TextEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChecker, conzx_Text.Checker); //审核人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Checker); //审核人
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IdCurrEduCls))
 {
 if (objzx_TextEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TextEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Text.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Keyword))
 {
 if (objzx_TextEN.Keyword !=  null)
 {
 var strKeyword = objzx_TextEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conzx_Text.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Keyword); //关键字
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.LiteratureSources))
 {
 if (objzx_TextEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objzx_TextEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureSources, conzx_Text.LiteratureSources); //文献来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.LiteratureSources); //文献来源
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.LiteratureLink))
 {
 if (objzx_TextEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objzx_TextEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureLink, conzx_Text.LiteratureLink); //文献链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.LiteratureLink); //文献链接
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UploadfileUrl))
 {
 if (objzx_TextEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objzx_TextEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadfileUrl, conzx_Text.UploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.UploadfileUrl); //文件地址
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TextEN.IsSubmit == true?"1":"0", conzx_Text.IsSubmit); //是否提交
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TextEN.IsChecked == true?"1":"0", conzx_Text.IsChecked); //是否检查
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.BrowseNumber))
 {
 if (objzx_TextEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.BrowseNumber, conzx_Text.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.BrowseNumber); //浏览量
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VCount))
 {
 if (objzx_TextEN.VCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VCount, conzx_Text.VCount); //VCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VCount); //VCount
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VoteCount))
 {
 if (objzx_TextEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VoteCount, conzx_Text.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.CollectionCount))
 {
 if (objzx_TextEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.CollectionCount, conzx_Text.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.DownloadCount))
 {
 if (objzx_TextEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.DownloadCount, conzx_Text.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.DownloadCount); //下载数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.AttachmentCount))
 {
 if (objzx_TextEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.AttachmentCount, conzx_Text.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.AppraiseCount))
 {
 if (objzx_TextEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.AppraiseCount, conzx_Text.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Score))
 {
 if (objzx_TextEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.Score, conzx_Text.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Score); //评分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.StuScore))
 {
 if (objzx_TextEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.StuScore, conzx_Text.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.StuScore); //学生平均分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TeaScore))
 {
 if (objzx_TextEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TeaScore, conzx_Text.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TeaScore); //教师评分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextTypeId))
 {
 if (objzx_TextEN.TextTypeId !=  null)
 {
 var strTextTypeId = objzx_TextEN.TextTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextTypeId, conzx_Text.TextTypeId); //TextTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TextTypeId); //TextTypeId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextStatusId))
 {
 if (objzx_TextEN.TextStatusId !=  null)
 {
 var strTextStatusId = objzx_TextEN.TextStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextStatusId, conzx_Text.TextStatusId); //TextStatusId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TextStatusId); //TextStatusId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VersionCount))
 {
 if (objzx_TextEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VersionCount, conzx_Text.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VersionCount); //版本统计
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TextEN.IsPublic == true?"1":"0", conzx_Text.IsPublic); //是否公开
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.zxShareId))
 {
 if (objzx_TextEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TextEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Text.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.zxShareId); //分享Id
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.SchoolTerm))
 {
 if (objzx_TextEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objzx_TextEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conzx_Text.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.SchoolTerm); //学期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.GradeId))
 {
 if (objzx_TextEN.GradeId !=  null)
 {
 var strGradeId = objzx_TextEN.GradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGradeId, conzx_Text.GradeId); //年级代号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.GradeId); //年级代号
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Memo))
 {
 if (objzx_TextEN.Memo !=  null)
 {
 var strMemo = objzx_TextEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Text.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Memo); //备注
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UnitId))
 {
 if (objzx_TextEN.UnitId !=  null)
 {
 var strUnitId = objzx_TextEN.UnitId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUnitId, conzx_Text.UnitId); //UnitId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.UnitId); //UnitId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.PaperQCount))
 {
 if (objzx_TextEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.PaperQCount, conzx_Text.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.PaperQCount); //论文答疑数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.SubVCount))
 {
 if (objzx_TextEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.SubVCount, conzx_Text.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.SubVCount); //论文子观点数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TagsCount))
 {
 if (objzx_TextEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TagsCount, conzx_Text.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TagsCount); //论文标注数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TeaQCount))
 {
 if (objzx_TextEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TeaQCount, conzx_Text.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TeaQCount); //教师提问数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TextId = '{0}'", objzx_TextEN.TextId); 
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
 /// <param name = "objzx_TextEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_TextEN objzx_TextEN, string strCondition)
{
 if (objzx_TextEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TextEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Text Set ");
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextTitle))
 {
 if (objzx_TextEN.TextTitle !=  null)
 {
 var strTextTitle = objzx_TextEN.TextTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextTitle = '{0}',", strTextTitle); //TextTitle
 }
 else
 {
 sbSQL.Append(" TextTitle = null,"); //TextTitle
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextContent))
 {
 if (objzx_TextEN.TextContent !=  null)
 {
 var strTextContent = objzx_TextEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextContent = '{0}',", strTextContent); //TextContent
 }
 else
 {
 sbSQL.Append(" TextContent = null,"); //TextContent
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Edition))
 {
 if (objzx_TextEN.Edition !=  null)
 {
 var strEdition = objzx_TextEN.Edition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Edition = '{0}',", strEdition); //Edition
 }
 else
 {
 sbSQL.Append(" Edition = null,"); //Edition
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Author))
 {
 if (objzx_TextEN.Author !=  null)
 {
 var strAuthor = objzx_TextEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.ResearchQuestion))
 {
 if (objzx_TextEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objzx_TextEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchQuestion = '{0}',", strResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.Append(" ResearchQuestion = null,"); //研究问题
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UpdDate))
 {
 if (objzx_TextEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TextEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UpdUser))
 {
 if (objzx_TextEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TextEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.CreateDate))
 {
 if (objzx_TextEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TextEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Checker))
 {
 if (objzx_TextEN.Checker !=  null)
 {
 var strChecker = objzx_TextEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Checker = '{0}',", strChecker); //审核人
 }
 else
 {
 sbSQL.Append(" Checker = null,"); //审核人
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IdCurrEduCls))
 {
 if (objzx_TextEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TextEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Keyword))
 {
 if (objzx_TextEN.Keyword !=  null)
 {
 var strKeyword = objzx_TextEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.LiteratureSources))
 {
 if (objzx_TextEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objzx_TextEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureSources = '{0}',", strLiteratureSources); //文献来源
 }
 else
 {
 sbSQL.Append(" LiteratureSources = null,"); //文献来源
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.LiteratureLink))
 {
 if (objzx_TextEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objzx_TextEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureLink = '{0}',", strLiteratureLink); //文献链接
 }
 else
 {
 sbSQL.Append(" LiteratureLink = null,"); //文献链接
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UploadfileUrl))
 {
 if (objzx_TextEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objzx_TextEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadfileUrl = '{0}',", strUploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.Append(" UploadfileUrl = null,"); //文件地址
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TextEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objzx_TextEN.IsChecked == true?"1":"0"); //是否检查
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.BrowseNumber))
 {
 if (objzx_TextEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.BrowseNumber, conzx_Text.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.BrowseNumber); //浏览量
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VCount))
 {
 if (objzx_TextEN.VCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VCount, conzx_Text.VCount); //VCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VCount); //VCount
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VoteCount))
 {
 if (objzx_TextEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VoteCount, conzx_Text.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.CollectionCount))
 {
 if (objzx_TextEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.CollectionCount, conzx_Text.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.DownloadCount))
 {
 if (objzx_TextEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.DownloadCount, conzx_Text.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.DownloadCount); //下载数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.AttachmentCount))
 {
 if (objzx_TextEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.AttachmentCount, conzx_Text.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.AppraiseCount))
 {
 if (objzx_TextEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.AppraiseCount, conzx_Text.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Score))
 {
 if (objzx_TextEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.Score, conzx_Text.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Score); //评分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.StuScore))
 {
 if (objzx_TextEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.StuScore, conzx_Text.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.StuScore); //学生平均分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TeaScore))
 {
 if (objzx_TextEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TeaScore, conzx_Text.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TeaScore); //教师评分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextTypeId))
 {
 if (objzx_TextEN.TextTypeId !=  null)
 {
 var strTextTypeId = objzx_TextEN.TextTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextTypeId = '{0}',", strTextTypeId); //TextTypeId
 }
 else
 {
 sbSQL.Append(" TextTypeId = null,"); //TextTypeId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextStatusId))
 {
 if (objzx_TextEN.TextStatusId !=  null)
 {
 var strTextStatusId = objzx_TextEN.TextStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextStatusId = '{0}',", strTextStatusId); //TextStatusId
 }
 else
 {
 sbSQL.Append(" TextStatusId = null,"); //TextStatusId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VersionCount))
 {
 if (objzx_TextEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VersionCount, conzx_Text.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VersionCount); //版本统计
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_TextEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.zxShareId))
 {
 if (objzx_TextEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TextEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.SchoolTerm))
 {
 if (objzx_TextEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objzx_TextEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.GradeId))
 {
 if (objzx_TextEN.GradeId !=  null)
 {
 var strGradeId = objzx_TextEN.GradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GradeId = '{0}',", strGradeId); //年级代号
 }
 else
 {
 sbSQL.Append(" GradeId = null,"); //年级代号
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Memo))
 {
 if (objzx_TextEN.Memo !=  null)
 {
 var strMemo = objzx_TextEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UnitId))
 {
 if (objzx_TextEN.UnitId !=  null)
 {
 var strUnitId = objzx_TextEN.UnitId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UnitId = '{0}',", strUnitId); //UnitId
 }
 else
 {
 sbSQL.Append(" UnitId = null,"); //UnitId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.PaperQCount))
 {
 if (objzx_TextEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.PaperQCount, conzx_Text.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.PaperQCount); //论文答疑数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.SubVCount))
 {
 if (objzx_TextEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.SubVCount, conzx_Text.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.SubVCount); //论文子观点数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TagsCount))
 {
 if (objzx_TextEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TagsCount, conzx_Text.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TagsCount); //论文标注数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TeaQCount))
 {
 if (objzx_TextEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TeaQCount, conzx_Text.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TeaQCount); //教师提问数
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
 /// <param name = "objzx_TextEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_TextEN objzx_TextEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TextEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TextEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Text Set ");
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextTitle))
 {
 if (objzx_TextEN.TextTitle !=  null)
 {
 var strTextTitle = objzx_TextEN.TextTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextTitle = '{0}',", strTextTitle); //TextTitle
 }
 else
 {
 sbSQL.Append(" TextTitle = null,"); //TextTitle
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextContent))
 {
 if (objzx_TextEN.TextContent !=  null)
 {
 var strTextContent = objzx_TextEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextContent = '{0}',", strTextContent); //TextContent
 }
 else
 {
 sbSQL.Append(" TextContent = null,"); //TextContent
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Edition))
 {
 if (objzx_TextEN.Edition !=  null)
 {
 var strEdition = objzx_TextEN.Edition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Edition = '{0}',", strEdition); //Edition
 }
 else
 {
 sbSQL.Append(" Edition = null,"); //Edition
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Author))
 {
 if (objzx_TextEN.Author !=  null)
 {
 var strAuthor = objzx_TextEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.ResearchQuestion))
 {
 if (objzx_TextEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objzx_TextEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchQuestion = '{0}',", strResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.Append(" ResearchQuestion = null,"); //研究问题
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UpdDate))
 {
 if (objzx_TextEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TextEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UpdUser))
 {
 if (objzx_TextEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TextEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.CreateDate))
 {
 if (objzx_TextEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TextEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Checker))
 {
 if (objzx_TextEN.Checker !=  null)
 {
 var strChecker = objzx_TextEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Checker = '{0}',", strChecker); //审核人
 }
 else
 {
 sbSQL.Append(" Checker = null,"); //审核人
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IdCurrEduCls))
 {
 if (objzx_TextEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TextEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Keyword))
 {
 if (objzx_TextEN.Keyword !=  null)
 {
 var strKeyword = objzx_TextEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.LiteratureSources))
 {
 if (objzx_TextEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objzx_TextEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureSources = '{0}',", strLiteratureSources); //文献来源
 }
 else
 {
 sbSQL.Append(" LiteratureSources = null,"); //文献来源
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.LiteratureLink))
 {
 if (objzx_TextEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objzx_TextEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureLink = '{0}',", strLiteratureLink); //文献链接
 }
 else
 {
 sbSQL.Append(" LiteratureLink = null,"); //文献链接
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UploadfileUrl))
 {
 if (objzx_TextEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objzx_TextEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadfileUrl = '{0}',", strUploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.Append(" UploadfileUrl = null,"); //文件地址
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TextEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objzx_TextEN.IsChecked == true?"1":"0"); //是否检查
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.BrowseNumber))
 {
 if (objzx_TextEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.BrowseNumber, conzx_Text.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.BrowseNumber); //浏览量
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VCount))
 {
 if (objzx_TextEN.VCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VCount, conzx_Text.VCount); //VCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VCount); //VCount
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VoteCount))
 {
 if (objzx_TextEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VoteCount, conzx_Text.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.CollectionCount))
 {
 if (objzx_TextEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.CollectionCount, conzx_Text.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.DownloadCount))
 {
 if (objzx_TextEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.DownloadCount, conzx_Text.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.DownloadCount); //下载数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.AttachmentCount))
 {
 if (objzx_TextEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.AttachmentCount, conzx_Text.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.AppraiseCount))
 {
 if (objzx_TextEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.AppraiseCount, conzx_Text.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Score))
 {
 if (objzx_TextEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.Score, conzx_Text.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Score); //评分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.StuScore))
 {
 if (objzx_TextEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.StuScore, conzx_Text.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.StuScore); //学生平均分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TeaScore))
 {
 if (objzx_TextEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TeaScore, conzx_Text.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TeaScore); //教师评分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextTypeId))
 {
 if (objzx_TextEN.TextTypeId !=  null)
 {
 var strTextTypeId = objzx_TextEN.TextTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextTypeId = '{0}',", strTextTypeId); //TextTypeId
 }
 else
 {
 sbSQL.Append(" TextTypeId = null,"); //TextTypeId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextStatusId))
 {
 if (objzx_TextEN.TextStatusId !=  null)
 {
 var strTextStatusId = objzx_TextEN.TextStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextStatusId = '{0}',", strTextStatusId); //TextStatusId
 }
 else
 {
 sbSQL.Append(" TextStatusId = null,"); //TextStatusId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VersionCount))
 {
 if (objzx_TextEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VersionCount, conzx_Text.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VersionCount); //版本统计
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_TextEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.zxShareId))
 {
 if (objzx_TextEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TextEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.SchoolTerm))
 {
 if (objzx_TextEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objzx_TextEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.GradeId))
 {
 if (objzx_TextEN.GradeId !=  null)
 {
 var strGradeId = objzx_TextEN.GradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GradeId = '{0}',", strGradeId); //年级代号
 }
 else
 {
 sbSQL.Append(" GradeId = null,"); //年级代号
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Memo))
 {
 if (objzx_TextEN.Memo !=  null)
 {
 var strMemo = objzx_TextEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UnitId))
 {
 if (objzx_TextEN.UnitId !=  null)
 {
 var strUnitId = objzx_TextEN.UnitId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UnitId = '{0}',", strUnitId); //UnitId
 }
 else
 {
 sbSQL.Append(" UnitId = null,"); //UnitId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.PaperQCount))
 {
 if (objzx_TextEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.PaperQCount, conzx_Text.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.PaperQCount); //论文答疑数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.SubVCount))
 {
 if (objzx_TextEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.SubVCount, conzx_Text.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.SubVCount); //论文子观点数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TagsCount))
 {
 if (objzx_TextEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TagsCount, conzx_Text.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TagsCount); //论文标注数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TeaQCount))
 {
 if (objzx_TextEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TeaQCount, conzx_Text.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TeaQCount); //教师提问数
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
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TextEN objzx_TextEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TextEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TextEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Text Set ");
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextTitle))
 {
 if (objzx_TextEN.TextTitle !=  null)
 {
 var strTextTitle = objzx_TextEN.TextTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextTitle, conzx_Text.TextTitle); //TextTitle
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TextTitle); //TextTitle
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextContent))
 {
 if (objzx_TextEN.TextContent !=  null)
 {
 var strTextContent = objzx_TextEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextContent, conzx_Text.TextContent); //TextContent
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TextContent); //TextContent
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Edition))
 {
 if (objzx_TextEN.Edition !=  null)
 {
 var strEdition = objzx_TextEN.Edition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEdition, conzx_Text.Edition); //Edition
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Edition); //Edition
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Author))
 {
 if (objzx_TextEN.Author !=  null)
 {
 var strAuthor = objzx_TextEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, conzx_Text.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Author); //作者
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.ResearchQuestion))
 {
 if (objzx_TextEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objzx_TextEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchQuestion, conzx_Text.ResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.ResearchQuestion); //研究问题
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UpdDate))
 {
 if (objzx_TextEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TextEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Text.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.UpdDate); //修改日期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UpdUser))
 {
 if (objzx_TextEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TextEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Text.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.UpdUser); //修改人
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.CreateDate))
 {
 if (objzx_TextEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_TextEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Text.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.CreateDate); //建立日期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Checker))
 {
 if (objzx_TextEN.Checker !=  null)
 {
 var strChecker = objzx_TextEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChecker, conzx_Text.Checker); //审核人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Checker); //审核人
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IdCurrEduCls))
 {
 if (objzx_TextEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TextEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Text.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Keyword))
 {
 if (objzx_TextEN.Keyword !=  null)
 {
 var strKeyword = objzx_TextEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conzx_Text.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Keyword); //关键字
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.LiteratureSources))
 {
 if (objzx_TextEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objzx_TextEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureSources, conzx_Text.LiteratureSources); //文献来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.LiteratureSources); //文献来源
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.LiteratureLink))
 {
 if (objzx_TextEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objzx_TextEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureLink, conzx_Text.LiteratureLink); //文献链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.LiteratureLink); //文献链接
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UploadfileUrl))
 {
 if (objzx_TextEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objzx_TextEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadfileUrl, conzx_Text.UploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.UploadfileUrl); //文件地址
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TextEN.IsSubmit == true?"1":"0", conzx_Text.IsSubmit); //是否提交
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TextEN.IsChecked == true?"1":"0", conzx_Text.IsChecked); //是否检查
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.BrowseNumber))
 {
 if (objzx_TextEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.BrowseNumber, conzx_Text.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.BrowseNumber); //浏览量
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VCount))
 {
 if (objzx_TextEN.VCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VCount, conzx_Text.VCount); //VCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VCount); //VCount
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VoteCount))
 {
 if (objzx_TextEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VoteCount, conzx_Text.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.CollectionCount))
 {
 if (objzx_TextEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.CollectionCount, conzx_Text.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.DownloadCount))
 {
 if (objzx_TextEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.DownloadCount, conzx_Text.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.DownloadCount); //下载数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.AttachmentCount))
 {
 if (objzx_TextEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.AttachmentCount, conzx_Text.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.AppraiseCount))
 {
 if (objzx_TextEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.AppraiseCount, conzx_Text.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.AppraiseCount); //评论数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Score))
 {
 if (objzx_TextEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.Score, conzx_Text.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Score); //评分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.StuScore))
 {
 if (objzx_TextEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.StuScore, conzx_Text.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.StuScore); //学生平均分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TeaScore))
 {
 if (objzx_TextEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TeaScore, conzx_Text.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TeaScore); //教师评分
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextTypeId))
 {
 if (objzx_TextEN.TextTypeId !=  null)
 {
 var strTextTypeId = objzx_TextEN.TextTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextTypeId, conzx_Text.TextTypeId); //TextTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TextTypeId); //TextTypeId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TextStatusId))
 {
 if (objzx_TextEN.TextStatusId !=  null)
 {
 var strTextStatusId = objzx_TextEN.TextStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextStatusId, conzx_Text.TextStatusId); //TextStatusId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TextStatusId); //TextStatusId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.VersionCount))
 {
 if (objzx_TextEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.VersionCount, conzx_Text.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.VersionCount); //版本统计
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TextEN.IsPublic == true?"1":"0", conzx_Text.IsPublic); //是否公开
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.zxShareId))
 {
 if (objzx_TextEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TextEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Text.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.zxShareId); //分享Id
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.SchoolTerm))
 {
 if (objzx_TextEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objzx_TextEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conzx_Text.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.SchoolTerm); //学期
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.GradeId))
 {
 if (objzx_TextEN.GradeId !=  null)
 {
 var strGradeId = objzx_TextEN.GradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGradeId, conzx_Text.GradeId); //年级代号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.GradeId); //年级代号
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.Memo))
 {
 if (objzx_TextEN.Memo !=  null)
 {
 var strMemo = objzx_TextEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Text.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.Memo); //备注
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.UnitId))
 {
 if (objzx_TextEN.UnitId !=  null)
 {
 var strUnitId = objzx_TextEN.UnitId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUnitId, conzx_Text.UnitId); //UnitId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.UnitId); //UnitId
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.PaperQCount))
 {
 if (objzx_TextEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.PaperQCount, conzx_Text.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.PaperQCount); //论文答疑数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.SubVCount))
 {
 if (objzx_TextEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.SubVCount, conzx_Text.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.SubVCount); //论文子观点数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TagsCount))
 {
 if (objzx_TextEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TagsCount, conzx_Text.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TagsCount); //论文标注数
 }
 }
 
 if (objzx_TextEN.IsUpdated(conzx_Text.TeaQCount))
 {
 if (objzx_TextEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TextEN.TeaQCount, conzx_Text.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Text.TeaQCount); //教师提问数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TextId = '{0}'", objzx_TextEN.TextId); 
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
 /// <param name = "strTextId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTextId) 
{
CheckPrimaryKey(strTextId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTextId,
};
 objSQL.ExecSP("zx_Text_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTextId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTextId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTextId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
//删除zx_Text本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Text where TextId = " + "'"+ strTextId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_Text(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
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
//删除zx_Text本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Text where TextId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTextId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTextId) 
{
CheckPrimaryKey(strTextId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
//删除zx_Text本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Text where TextId = " + "'"+ strTextId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_Text(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_TextDA: Delzx_Text)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Text where " + strCondition ;
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
public bool Delzx_TextWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_TextDA: Delzx_TextWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TextDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Text where " + strCondition ;
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
 /// <param name = "objzx_TextENS">源对象</param>
 /// <param name = "objzx_TextENT">目标对象</param>
public void CopyTo(clszx_TextEN objzx_TextENS, clszx_TextEN objzx_TextENT)
{
objzx_TextENT.TextId = objzx_TextENS.TextId; //课件Id
objzx_TextENT.TextTitle = objzx_TextENS.TextTitle; //TextTitle
objzx_TextENT.TextContent = objzx_TextENS.TextContent; //TextContent
objzx_TextENT.Edition = objzx_TextENS.Edition; //Edition
objzx_TextENT.Author = objzx_TextENS.Author; //作者
objzx_TextENT.ResearchQuestion = objzx_TextENS.ResearchQuestion; //研究问题
objzx_TextENT.UpdDate = objzx_TextENS.UpdDate; //修改日期
objzx_TextENT.UpdUser = objzx_TextENS.UpdUser; //修改人
objzx_TextENT.CreateDate = objzx_TextENS.CreateDate; //建立日期
objzx_TextENT.Checker = objzx_TextENS.Checker; //审核人
objzx_TextENT.IdCurrEduCls = objzx_TextENS.IdCurrEduCls; //教学班流水号
objzx_TextENT.Keyword = objzx_TextENS.Keyword; //关键字
objzx_TextENT.LiteratureSources = objzx_TextENS.LiteratureSources; //文献来源
objzx_TextENT.LiteratureLink = objzx_TextENS.LiteratureLink; //文献链接
objzx_TextENT.UploadfileUrl = objzx_TextENS.UploadfileUrl; //文件地址
objzx_TextENT.IsSubmit = objzx_TextENS.IsSubmit; //是否提交
objzx_TextENT.IsChecked = objzx_TextENS.IsChecked; //是否检查
objzx_TextENT.BrowseNumber = objzx_TextENS.BrowseNumber; //浏览量
objzx_TextENT.VCount = objzx_TextENS.VCount; //VCount
objzx_TextENT.VoteCount = objzx_TextENS.VoteCount; //点赞计数
objzx_TextENT.CollectionCount = objzx_TextENS.CollectionCount; //收藏数量
objzx_TextENT.DownloadCount = objzx_TextENS.DownloadCount; //下载数
objzx_TextENT.AttachmentCount = objzx_TextENS.AttachmentCount; //附件计数
objzx_TextENT.AppraiseCount = objzx_TextENS.AppraiseCount; //评论数
objzx_TextENT.Score = objzx_TextENS.Score; //评分
objzx_TextENT.StuScore = objzx_TextENS.StuScore; //学生平均分
objzx_TextENT.TeaScore = objzx_TextENS.TeaScore; //教师评分
objzx_TextENT.TextTypeId = objzx_TextENS.TextTypeId; //TextTypeId
objzx_TextENT.TextStatusId = objzx_TextENS.TextStatusId; //TextStatusId
objzx_TextENT.VersionCount = objzx_TextENS.VersionCount; //版本统计
objzx_TextENT.IsPublic = objzx_TextENS.IsPublic; //是否公开
objzx_TextENT.zxShareId = objzx_TextENS.zxShareId; //分享Id
objzx_TextENT.SchoolTerm = objzx_TextENS.SchoolTerm; //学期
objzx_TextENT.GradeId = objzx_TextENS.GradeId; //年级代号
objzx_TextENT.Memo = objzx_TextENS.Memo; //备注
objzx_TextENT.UnitId = objzx_TextENS.UnitId; //UnitId
objzx_TextENT.PaperQCount = objzx_TextENS.PaperQCount; //论文答疑数
objzx_TextENT.SubVCount = objzx_TextENS.SubVCount; //论文子观点数
objzx_TextENT.TagsCount = objzx_TextENS.TagsCount; //论文标注数
objzx_TextENT.TeaQCount = objzx_TextENS.TeaQCount; //教师提问数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_TextEN objzx_TextEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_TextEN.TextTitle, conzx_Text.TextTitle);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TextEN.TextId, 8, conzx_Text.TextId);
clsCheckSql.CheckFieldLen(objzx_TextEN.TextTitle, 500, conzx_Text.TextTitle);
clsCheckSql.CheckFieldLen(objzx_TextEN.Edition, 100, conzx_Text.Edition);
clsCheckSql.CheckFieldLen(objzx_TextEN.Author, 200, conzx_Text.Author);
clsCheckSql.CheckFieldLen(objzx_TextEN.ResearchQuestion, 2000, conzx_Text.ResearchQuestion);
clsCheckSql.CheckFieldLen(objzx_TextEN.UpdDate, 20, conzx_Text.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TextEN.UpdUser, 20, conzx_Text.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TextEN.CreateDate, 20, conzx_Text.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TextEN.Checker, 20, conzx_Text.Checker);
clsCheckSql.CheckFieldLen(objzx_TextEN.IdCurrEduCls, 8, conzx_Text.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TextEN.Keyword, 1000, conzx_Text.Keyword);
clsCheckSql.CheckFieldLen(objzx_TextEN.LiteratureSources, 1000, conzx_Text.LiteratureSources);
clsCheckSql.CheckFieldLen(objzx_TextEN.LiteratureLink, 1000, conzx_Text.LiteratureLink);
clsCheckSql.CheckFieldLen(objzx_TextEN.UploadfileUrl, 1000, conzx_Text.UploadfileUrl);
clsCheckSql.CheckFieldLen(objzx_TextEN.TextTypeId, 2, conzx_Text.TextTypeId);
clsCheckSql.CheckFieldLen(objzx_TextEN.TextStatusId, 2, conzx_Text.TextStatusId);
clsCheckSql.CheckFieldLen(objzx_TextEN.zxShareId, 2, conzx_Text.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TextEN.SchoolTerm, 1, conzx_Text.SchoolTerm);
clsCheckSql.CheckFieldLen(objzx_TextEN.GradeId, 4, conzx_Text.GradeId);
clsCheckSql.CheckFieldLen(objzx_TextEN.Memo, 1000, conzx_Text.Memo);
clsCheckSql.CheckFieldLen(objzx_TextEN.UnitId, 4, conzx_Text.UnitId);
//检查字段外键固定长度
 objzx_TextEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_TextEN objzx_TextEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TextEN.TextTitle, 500, conzx_Text.TextTitle);
clsCheckSql.CheckFieldLen(objzx_TextEN.Edition, 100, conzx_Text.Edition);
clsCheckSql.CheckFieldLen(objzx_TextEN.Author, 200, conzx_Text.Author);
clsCheckSql.CheckFieldLen(objzx_TextEN.ResearchQuestion, 2000, conzx_Text.ResearchQuestion);
clsCheckSql.CheckFieldLen(objzx_TextEN.UpdDate, 20, conzx_Text.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TextEN.UpdUser, 20, conzx_Text.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TextEN.CreateDate, 20, conzx_Text.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TextEN.Checker, 20, conzx_Text.Checker);
clsCheckSql.CheckFieldLen(objzx_TextEN.IdCurrEduCls, 8, conzx_Text.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TextEN.Keyword, 1000, conzx_Text.Keyword);
clsCheckSql.CheckFieldLen(objzx_TextEN.LiteratureSources, 1000, conzx_Text.LiteratureSources);
clsCheckSql.CheckFieldLen(objzx_TextEN.LiteratureLink, 1000, conzx_Text.LiteratureLink);
clsCheckSql.CheckFieldLen(objzx_TextEN.UploadfileUrl, 1000, conzx_Text.UploadfileUrl);
clsCheckSql.CheckFieldLen(objzx_TextEN.TextTypeId, 2, conzx_Text.TextTypeId);
clsCheckSql.CheckFieldLen(objzx_TextEN.TextStatusId, 2, conzx_Text.TextStatusId);
clsCheckSql.CheckFieldLen(objzx_TextEN.zxShareId, 2, conzx_Text.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TextEN.SchoolTerm, 1, conzx_Text.SchoolTerm);
clsCheckSql.CheckFieldLen(objzx_TextEN.GradeId, 4, conzx_Text.GradeId);
clsCheckSql.CheckFieldLen(objzx_TextEN.Memo, 1000, conzx_Text.Memo);
clsCheckSql.CheckFieldLen(objzx_TextEN.UnitId, 4, conzx_Text.UnitId);
//检查外键字段长度
 objzx_TextEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_TextEN objzx_TextEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TextEN.TextId, 8, conzx_Text.TextId);
clsCheckSql.CheckFieldLen(objzx_TextEN.TextTitle, 500, conzx_Text.TextTitle);
clsCheckSql.CheckFieldLen(objzx_TextEN.Edition, 100, conzx_Text.Edition);
clsCheckSql.CheckFieldLen(objzx_TextEN.Author, 200, conzx_Text.Author);
clsCheckSql.CheckFieldLen(objzx_TextEN.ResearchQuestion, 2000, conzx_Text.ResearchQuestion);
clsCheckSql.CheckFieldLen(objzx_TextEN.UpdDate, 20, conzx_Text.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TextEN.UpdUser, 20, conzx_Text.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TextEN.CreateDate, 20, conzx_Text.CreateDate);
clsCheckSql.CheckFieldLen(objzx_TextEN.Checker, 20, conzx_Text.Checker);
clsCheckSql.CheckFieldLen(objzx_TextEN.IdCurrEduCls, 8, conzx_Text.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TextEN.Keyword, 1000, conzx_Text.Keyword);
clsCheckSql.CheckFieldLen(objzx_TextEN.LiteratureSources, 1000, conzx_Text.LiteratureSources);
clsCheckSql.CheckFieldLen(objzx_TextEN.LiteratureLink, 1000, conzx_Text.LiteratureLink);
clsCheckSql.CheckFieldLen(objzx_TextEN.UploadfileUrl, 1000, conzx_Text.UploadfileUrl);
clsCheckSql.CheckFieldLen(objzx_TextEN.TextTypeId, 2, conzx_Text.TextTypeId);
clsCheckSql.CheckFieldLen(objzx_TextEN.TextStatusId, 2, conzx_Text.TextStatusId);
clsCheckSql.CheckFieldLen(objzx_TextEN.zxShareId, 2, conzx_Text.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TextEN.SchoolTerm, 1, conzx_Text.SchoolTerm);
clsCheckSql.CheckFieldLen(objzx_TextEN.GradeId, 4, conzx_Text.GradeId);
clsCheckSql.CheckFieldLen(objzx_TextEN.Memo, 1000, conzx_Text.Memo);
clsCheckSql.CheckFieldLen(objzx_TextEN.UnitId, 4, conzx_Text.UnitId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.TextId, conzx_Text.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.TextTitle, conzx_Text.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.Edition, conzx_Text.Edition);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.Author, conzx_Text.Author);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.ResearchQuestion, conzx_Text.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.UpdDate, conzx_Text.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.UpdUser, conzx_Text.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.CreateDate, conzx_Text.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.Checker, conzx_Text.Checker);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.IdCurrEduCls, conzx_Text.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.Keyword, conzx_Text.Keyword);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.LiteratureSources, conzx_Text.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.LiteratureLink, conzx_Text.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.UploadfileUrl, conzx_Text.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.TextTypeId, conzx_Text.TextTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.TextStatusId, conzx_Text.TextStatusId);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.zxShareId, conzx_Text.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.SchoolTerm, conzx_Text.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.GradeId, conzx_Text.GradeId);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.Memo, conzx_Text.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_TextEN.UnitId, conzx_Text.UnitId);
//检查外键字段长度
 objzx_TextEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_Text(中学课件表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TextEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_TextEN objzx_TextEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objzx_TextEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null");
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objzx_TextEN.IdCurrEduCls);
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
 objSQL = clszx_TextDA.GetSpecSQLObj();
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
 objSQL = clszx_TextDA.GetSpecSQLObj();
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
 objSQL = clszx_TextDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TextEN._CurrTabName);
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
 objSQL = clszx_TextDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TextEN._CurrTabName, strCondition);
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
 objSQL = clszx_TextDA.GetSpecSQLObj();
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
 objSQL = clszx_TextDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}