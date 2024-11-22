
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_CompositionDA
 表名:zx_Composition(01120761)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:53:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 作文表(zx_Composition)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_CompositionDA : clsCommBase4DA
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
 return clszx_CompositionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_CompositionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_CompositionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_CompositionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_CompositionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxPaperId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxPaperId)
{
strzxPaperId = strzxPaperId.Replace("'", "''");
if (strzxPaperId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:zx_Composition中,检查关键字,长度不正确!(clszx_CompositionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_Composition中,关键字不能为空 或 null!(clszx_CompositionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_CompositionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_CompositionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from zx_Composition where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_Composition(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_CompositionDA: GetDataTable_zx_Composition)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from zx_Composition where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_CompositionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_CompositionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from zx_Composition where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_CompositionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_CompositionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Composition where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Composition where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_CompositionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_Composition where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_CompositionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Composition.* from zx_Composition Left Join {1} on {2} where {3} and zx_Composition.zxPaperId not in (Select top {5} zx_Composition.zxPaperId from zx_Composition Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Composition where {1} and zxPaperId not in (Select top {2} zxPaperId from zx_Composition where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Composition where {1} and zxPaperId not in (Select top {3} zxPaperId from zx_Composition where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_CompositionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Composition.* from zx_Composition Left Join {1} on {2} where {3} and zx_Composition.zxPaperId not in (Select top {5} zx_Composition.zxPaperId from zx_Composition Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Composition where {1} and zxPaperId not in (Select top {2} zxPaperId from zx_Composition where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Composition where {1} and zxPaperId not in (Select top {3} zxPaperId from zx_Composition where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_CompositionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_CompositionDA:GetObjLst)", objException.Message));
}
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from zx_Composition where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = TransNullToBool(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = TransNullToBool(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = TransNullToBool(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = TransNullToBool(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_CompositionDA: GetObjLst)", objException.Message));
}
objzx_CompositionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_CompositionEN);
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
public List<clszx_CompositionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_CompositionDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = TransNullToBool(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = TransNullToBool(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = TransNullToBool(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = TransNullToBool(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_CompositionDA: GetObjLst)", objException.Message));
}
objzx_CompositionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_CompositionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_Composition(ref clszx_CompositionEN objzx_CompositionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from zx_Composition where zxPaperId = " + "'"+ objzx_CompositionEN.zxPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_CompositionEN.zxPaperId = objDT.Rows[0][conzx_Composition.zxPaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objzx_CompositionEN.PaperTitle = objDT.Rows[0][conzx_Composition.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objzx_CompositionEN.PaperName = objDT.Rows[0][conzx_Composition.PaperName].ToString().Trim(); //主题名称(字段类型:varchar,字段长度:500,是否可空:False)
 objzx_CompositionEN.PaperContent = objDT.Rows[0][conzx_Composition.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_CompositionEN.Periodical = objDT.Rows[0][conzx_Composition.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_CompositionEN.Author = objDT.Rows[0][conzx_Composition.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_CompositionEN.ResearchQuestion = objDT.Rows[0][conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_CompositionEN.UpdDate = objDT.Rows[0][conzx_Composition.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_CompositionEN.Memo = objDT.Rows[0][conzx_Composition.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_CompositionEN.Keyword = objDT.Rows[0][conzx_Composition.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_CompositionEN.LiteratureSources = objDT.Rows[0][conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_CompositionEN.LiteratureLink = objDT.Rows[0][conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_CompositionEN.UploadfileUrl = objDT.Rows[0][conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_CompositionEN.IsQuotethesis = TransNullToBool(objDT.Rows[0][conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objzx_CompositionEN.QuoteId = objDT.Rows[0][conzx_Composition.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objzx_CompositionEN.IsChecked = TransNullToBool(objDT.Rows[0][conzx_Composition.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objzx_CompositionEN.Checker = objDT.Rows[0][conzx_Composition.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_CompositionEN.zxLiteratureTypeId = objDT.Rows[0][conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_CompositionEN.BrowseNumber = TransNullToInt(objDT.Rows[0][conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_Composition.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_CompositionEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_Composition.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.AttachmentCount = TransNullToInt(objDT.Rows[0][conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.CollectionCount = TransNullToInt(objDT.Rows[0][conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_CompositionEN.DownloadCount = TransNullToInt(objDT.Rows[0][conzx_Composition.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.OkCount = TransNullToInt(objDT.Rows[0][conzx_Composition.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.Pcount = TransNullToInt(objDT.Rows[0][conzx_Composition.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.Score = TransNullToFloat(objDT.Rows[0][conzx_Composition.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_CompositionEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_Composition.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_CompositionEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_Composition.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_CompositionEN.IdCurrEduCls = objDT.Rows[0][conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_CompositionEN.PaperTypeId = objDT.Rows[0][conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_CompositionEN.zxPaperStatusId = objDT.Rows[0][conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_CompositionEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_Composition.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.IsPublic = TransNullToBool(objDT.Rows[0][conzx_Composition.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_CompositionEN.AskQuestion = objDT.Rows[0][conzx_Composition.AskQuestion].ToString().Trim(); //问题提出(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.ResearchStatus = objDT.Rows[0][conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.InnovationPoints = objDT.Rows[0][conzx_Composition.InnovationPoints].ToString().Trim(); //创新点(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.ResearchDesign = objDT.Rows[0][conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.DimensionDataProcess = objDT.Rows[0][conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.ExpectedConclusion = objDT.Rows[0][conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.CreateDate = objDT.Rows[0][conzx_Composition.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_CompositionEN.zxShareId = objDT.Rows[0][conzx_Composition.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_CompositionEN.UpdUser = objDT.Rows[0][conzx_Composition.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_CompositionEN.PaperQCount = TransNullToInt(objDT.Rows[0][conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.SubVCount = TransNullToInt(objDT.Rows[0][conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.TagsCount = TransNullToInt(objDT.Rows[0][conzx_Composition.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.TeaQCount = TransNullToInt(objDT.Rows[0][conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.GroupTextId = objDT.Rows[0][conzx_Composition.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_CompositionDA: Getzx_Composition)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_CompositionEN GetObjByzxPaperId(string strzxPaperId)
{
CheckPrimaryKey(strzxPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from zx_Composition where zxPaperId = " + "'"+ strzxPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
 objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称(字段类型:varchar,字段长度:500,是否可空:False)
 objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_CompositionDA: GetObjByzxPaperId)", objException.Message));
}
return objzx_CompositionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_CompositionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_CompositionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from zx_Composition where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN()
{
zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(), //论文标题
PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(), //主题名称
PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(), //主题内容
Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(), //期刊
Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(), //研究问题
UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(), //备注
Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(), //关键字
LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(), //文献来源
LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(), //文献链接
UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(), //文件地址
IsQuotethesis = TransNullToBool(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()), //是否引用论文
QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(), //引用Id
IsChecked = TransNullToBool(objRow[conzx_Composition.IsChecked].ToString().Trim()), //是否检查
Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(), //审核人
zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(), //作文类型Id
BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.BrowseNumber].ToString().Trim()), //浏览量
IsSubmit = TransNullToBool(objRow[conzx_Composition.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.AppraiseCount].ToString().Trim()), //评论数
AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.AttachmentCount].ToString().Trim()), //附件计数
CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_Composition.CollectionCount].ToString().Trim()), //收藏数量
DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.DownloadCount].ToString().Trim()), //下载数
OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.OkCount].ToString().Trim()), //点赞统计
Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.Pcount].ToString().Trim()), //读写数
Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(), //教学班流水号
PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(), //论文类型Id
zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(), //论文状态Id
VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.VersionCount].ToString().Trim()), //版本统计
IsPublic = TransNullToBool(objRow[conzx_Composition.IsPublic].ToString().Trim()), //是否公开
AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(), //问题提出
ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(), //目前研究的现状
InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(), //创新点
ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(), //研究设计
DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(), //数据处理的维度
ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(), //预期结论
CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(), //建立日期
zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(), //分享Id
UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(), //修改人
PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.PaperQCount].ToString().Trim()), //论文答疑数
SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.SubVCount].ToString().Trim()), //论文子观点数
TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.TagsCount].ToString().Trim()), //论文标注数
TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.TeaQCount].ToString().Trim()), //教师提问数
GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim() //小组Id
};
objzx_CompositionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_CompositionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_CompositionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_CompositionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = TransNullToBool(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = TransNullToBool(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = TransNullToBool(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = TransNullToBool(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_CompositionDA: GetObjByDataRowzx_Composition)", objException.Message));
}
objzx_CompositionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_CompositionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_CompositionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = TransNullToBool(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = TransNullToBool(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = TransNullToBool(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = TransNullToBool(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_CompositionDA: GetObjByDataRow)", objException.Message));
}
objzx_CompositionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_CompositionEN;
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
objSQL = clszx_CompositionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_CompositionEN._CurrTabName, conzx_Composition.zxPaperId, 8, "");
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
objSQL = clszx_CompositionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_CompositionEN._CurrTabName, conzx_Composition.zxPaperId, 8, strPrefix);
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
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxPaperId from zx_Composition where " + strCondition;
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
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxPaperId from zx_Composition where " + strCondition;
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
 /// <param name = "strzxPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxPaperId)
{
CheckPrimaryKey(strzxPaperId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Composition", "zxPaperId = " + "'"+ strzxPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_CompositionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Composition", strCondition))
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
objSQL = clszx_CompositionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_Composition");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_CompositionEN objzx_CompositionEN)
 {
 if (objzx_CompositionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_CompositionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from zx_Composition where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Composition");
objRow = objDS.Tables["zx_Composition"].NewRow();
objRow[conzx_Composition.zxPaperId] = objzx_CompositionEN.zxPaperId; //论文Id
objRow[conzx_Composition.PaperTitle] = objzx_CompositionEN.PaperTitle; //论文标题
 if (objzx_CompositionEN.PaperName !=  "")
 {
objRow[conzx_Composition.PaperName] = objzx_CompositionEN.PaperName; //主题名称
 }
 if (objzx_CompositionEN.PaperContent !=  "")
 {
objRow[conzx_Composition.PaperContent] = objzx_CompositionEN.PaperContent; //主题内容
 }
 if (objzx_CompositionEN.Periodical !=  "")
 {
objRow[conzx_Composition.Periodical] = objzx_CompositionEN.Periodical; //期刊
 }
 if (objzx_CompositionEN.Author !=  "")
 {
objRow[conzx_Composition.Author] = objzx_CompositionEN.Author; //作者
 }
 if (objzx_CompositionEN.ResearchQuestion !=  "")
 {
objRow[conzx_Composition.ResearchQuestion] = objzx_CompositionEN.ResearchQuestion; //研究问题
 }
 if (objzx_CompositionEN.UpdDate !=  "")
 {
objRow[conzx_Composition.UpdDate] = objzx_CompositionEN.UpdDate; //修改日期
 }
 if (objzx_CompositionEN.Memo !=  "")
 {
objRow[conzx_Composition.Memo] = objzx_CompositionEN.Memo; //备注
 }
 if (objzx_CompositionEN.Keyword !=  "")
 {
objRow[conzx_Composition.Keyword] = objzx_CompositionEN.Keyword; //关键字
 }
 if (objzx_CompositionEN.LiteratureSources !=  "")
 {
objRow[conzx_Composition.LiteratureSources] = objzx_CompositionEN.LiteratureSources; //文献来源
 }
 if (objzx_CompositionEN.LiteratureLink !=  "")
 {
objRow[conzx_Composition.LiteratureLink] = objzx_CompositionEN.LiteratureLink; //文献链接
 }
 if (objzx_CompositionEN.UploadfileUrl !=  "")
 {
objRow[conzx_Composition.UploadfileUrl] = objzx_CompositionEN.UploadfileUrl; //文件地址
 }
objRow[conzx_Composition.IsQuotethesis] = objzx_CompositionEN.IsQuotethesis; //是否引用论文
 if (objzx_CompositionEN.QuoteId !=  "")
 {
objRow[conzx_Composition.QuoteId] = objzx_CompositionEN.QuoteId; //引用Id
 }
objRow[conzx_Composition.IsChecked] = objzx_CompositionEN.IsChecked; //是否检查
 if (objzx_CompositionEN.Checker !=  "")
 {
objRow[conzx_Composition.Checker] = objzx_CompositionEN.Checker; //审核人
 }
objRow[conzx_Composition.zxLiteratureTypeId] = objzx_CompositionEN.zxLiteratureTypeId; //作文类型Id
objRow[conzx_Composition.BrowseNumber] = objzx_CompositionEN.BrowseNumber; //浏览量
objRow[conzx_Composition.IsSubmit] = objzx_CompositionEN.IsSubmit; //是否提交
objRow[conzx_Composition.AppraiseCount] = objzx_CompositionEN.AppraiseCount; //评论数
objRow[conzx_Composition.AttachmentCount] = objzx_CompositionEN.AttachmentCount; //附件计数
objRow[conzx_Composition.CollectionCount] = objzx_CompositionEN.CollectionCount; //收藏数量
objRow[conzx_Composition.DownloadCount] = objzx_CompositionEN.DownloadCount; //下载数
objRow[conzx_Composition.OkCount] = objzx_CompositionEN.OkCount; //点赞统计
objRow[conzx_Composition.Pcount] = objzx_CompositionEN.Pcount; //读写数
objRow[conzx_Composition.Score] = objzx_CompositionEN.Score; //评分
objRow[conzx_Composition.StuScore] = objzx_CompositionEN.StuScore; //学生平均分
objRow[conzx_Composition.TeaScore] = objzx_CompositionEN.TeaScore; //教师评分
 if (objzx_CompositionEN.IdCurrEduCls !=  "")
 {
objRow[conzx_Composition.IdCurrEduCls] = objzx_CompositionEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_CompositionEN.PaperTypeId !=  "")
 {
objRow[conzx_Composition.PaperTypeId] = objzx_CompositionEN.PaperTypeId; //论文类型Id
 }
 if (objzx_CompositionEN.zxPaperStatusId !=  "")
 {
objRow[conzx_Composition.zxPaperStatusId] = objzx_CompositionEN.zxPaperStatusId; //论文状态Id
 }
objRow[conzx_Composition.VersionCount] = objzx_CompositionEN.VersionCount; //版本统计
objRow[conzx_Composition.IsPublic] = objzx_CompositionEN.IsPublic; //是否公开
 if (objzx_CompositionEN.AskQuestion !=  "")
 {
objRow[conzx_Composition.AskQuestion] = objzx_CompositionEN.AskQuestion; //问题提出
 }
 if (objzx_CompositionEN.ResearchStatus !=  "")
 {
objRow[conzx_Composition.ResearchStatus] = objzx_CompositionEN.ResearchStatus; //目前研究的现状
 }
 if (objzx_CompositionEN.InnovationPoints !=  "")
 {
objRow[conzx_Composition.InnovationPoints] = objzx_CompositionEN.InnovationPoints; //创新点
 }
 if (objzx_CompositionEN.ResearchDesign !=  "")
 {
objRow[conzx_Composition.ResearchDesign] = objzx_CompositionEN.ResearchDesign; //研究设计
 }
 if (objzx_CompositionEN.DimensionDataProcess !=  "")
 {
objRow[conzx_Composition.DimensionDataProcess] = objzx_CompositionEN.DimensionDataProcess; //数据处理的维度
 }
 if (objzx_CompositionEN.ExpectedConclusion !=  "")
 {
objRow[conzx_Composition.ExpectedConclusion] = objzx_CompositionEN.ExpectedConclusion; //预期结论
 }
 if (objzx_CompositionEN.CreateDate !=  "")
 {
objRow[conzx_Composition.CreateDate] = objzx_CompositionEN.CreateDate; //建立日期
 }
 if (objzx_CompositionEN.zxShareId !=  "")
 {
objRow[conzx_Composition.zxShareId] = objzx_CompositionEN.zxShareId; //分享Id
 }
 if (objzx_CompositionEN.UpdUser !=  "")
 {
objRow[conzx_Composition.UpdUser] = objzx_CompositionEN.UpdUser; //修改人
 }
objRow[conzx_Composition.PaperQCount] = objzx_CompositionEN.PaperQCount; //论文答疑数
objRow[conzx_Composition.SubVCount] = objzx_CompositionEN.SubVCount; //论文子观点数
objRow[conzx_Composition.TagsCount] = objzx_CompositionEN.TagsCount; //论文标注数
objRow[conzx_Composition.TeaQCount] = objzx_CompositionEN.TeaQCount; //教师提问数
objRow[conzx_Composition.GroupTextId] = objzx_CompositionEN.GroupTextId; //小组Id
objDS.Tables[clszx_CompositionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_CompositionEN._CurrTabName);
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
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_CompositionEN objzx_CompositionEN)
{
 if (objzx_CompositionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_CompositionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_CompositionEN.zxPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxPaperId);
 var strzxPaperId = objzx_CompositionEN.zxPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperId + "'");
 }
 
 if (objzx_CompositionEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperTitle);
 var strPaperTitle = objzx_CompositionEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objzx_CompositionEN.PaperName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperName);
 var strPaperName = objzx_CompositionEN.PaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperName + "'");
 }
 
 if (objzx_CompositionEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperContent);
 var strPaperContent = objzx_CompositionEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objzx_CompositionEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Periodical);
 var strPeriodical = objzx_CompositionEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objzx_CompositionEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Author);
 var strAuthor = objzx_CompositionEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_CompositionEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchQuestion);
 var strResearchQuestion = objzx_CompositionEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objzx_CompositionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UpdDate);
 var strUpdDate = objzx_CompositionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_CompositionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Memo);
 var strMemo = objzx_CompositionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_CompositionEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Keyword);
 var strKeyword = objzx_CompositionEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objzx_CompositionEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.LiteratureSources);
 var strLiteratureSources = objzx_CompositionEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objzx_CompositionEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.LiteratureLink);
 var strLiteratureLink = objzx_CompositionEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objzx_CompositionEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UploadfileUrl);
 var strUploadfileUrl = objzx_CompositionEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.QuoteId);
 var strQuoteId = objzx_CompositionEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsChecked);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Checker);
 var strChecker = objzx_CompositionEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objzx_CompositionEN.zxLiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxLiteratureTypeId);
 var strzxLiteratureTypeId = objzx_CompositionEN.zxLiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLiteratureTypeId + "'");
 }
 
 if (objzx_CompositionEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.BrowseNumber);
 arrValueListForInsert.Add(objzx_CompositionEN.BrowseNumber.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AppraiseCount);
 arrValueListForInsert.Add(objzx_CompositionEN.AppraiseCount.ToString());
 }
 
 if (objzx_CompositionEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AttachmentCount);
 arrValueListForInsert.Add(objzx_CompositionEN.AttachmentCount.ToString());
 }
 
 if (objzx_CompositionEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.CollectionCount);
 arrValueListForInsert.Add(objzx_CompositionEN.CollectionCount.ToString());
 }
 
 if (objzx_CompositionEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.DownloadCount);
 arrValueListForInsert.Add(objzx_CompositionEN.DownloadCount.ToString());
 }
 
 if (objzx_CompositionEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.OkCount);
 arrValueListForInsert.Add(objzx_CompositionEN.OkCount.ToString());
 }
 
 if (objzx_CompositionEN.Pcount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Pcount);
 arrValueListForInsert.Add(objzx_CompositionEN.Pcount.ToString());
 }
 
 if (objzx_CompositionEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Score);
 arrValueListForInsert.Add(objzx_CompositionEN.Score.ToString());
 }
 
 if (objzx_CompositionEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.StuScore);
 arrValueListForInsert.Add(objzx_CompositionEN.StuScore.ToString());
 }
 
 if (objzx_CompositionEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TeaScore);
 arrValueListForInsert.Add(objzx_CompositionEN.TeaScore.ToString());
 }
 
 if (objzx_CompositionEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.IdCurrEduCls);
 var strIdCurrEduCls = objzx_CompositionEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_CompositionEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperTypeId);
 var strPaperTypeId = objzx_CompositionEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objzx_CompositionEN.zxPaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxPaperStatusId);
 var strzxPaperStatusId = objzx_CompositionEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperStatusId + "'");
 }
 
 if (objzx_CompositionEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.VersionCount);
 arrValueListForInsert.Add(objzx_CompositionEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.AskQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AskQuestion);
 var strAskQuestion = objzx_CompositionEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAskQuestion + "'");
 }
 
 if (objzx_CompositionEN.ResearchStatus !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchStatus);
 var strResearchStatus = objzx_CompositionEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchStatus + "'");
 }
 
 if (objzx_CompositionEN.InnovationPoints !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.InnovationPoints);
 var strInnovationPoints = objzx_CompositionEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInnovationPoints + "'");
 }
 
 if (objzx_CompositionEN.ResearchDesign !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchDesign);
 var strResearchDesign = objzx_CompositionEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchDesign + "'");
 }
 
 if (objzx_CompositionEN.DimensionDataProcess !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.DimensionDataProcess);
 var strDimensionDataProcess = objzx_CompositionEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDimensionDataProcess + "'");
 }
 
 if (objzx_CompositionEN.ExpectedConclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ExpectedConclusion);
 var strExpectedConclusion = objzx_CompositionEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExpectedConclusion + "'");
 }
 
 if (objzx_CompositionEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.CreateDate);
 var strCreateDate = objzx_CompositionEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_CompositionEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxShareId);
 var strzxShareId = objzx_CompositionEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_CompositionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UpdUser);
 var strUpdUser = objzx_CompositionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_CompositionEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperQCount);
 arrValueListForInsert.Add(objzx_CompositionEN.PaperQCount.ToString());
 }
 
 if (objzx_CompositionEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.SubVCount);
 arrValueListForInsert.Add(objzx_CompositionEN.SubVCount.ToString());
 }
 
 if (objzx_CompositionEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TagsCount);
 arrValueListForInsert.Add(objzx_CompositionEN.TagsCount.ToString());
 }
 
 if (objzx_CompositionEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TeaQCount);
 arrValueListForInsert.Add(objzx_CompositionEN.TeaQCount.ToString());
 }
 
 if (objzx_CompositionEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.GroupTextId);
 var strGroupTextId = objzx_CompositionEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Composition");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_CompositionEN objzx_CompositionEN)
{
 if (objzx_CompositionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_CompositionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_CompositionEN.zxPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxPaperId);
 var strzxPaperId = objzx_CompositionEN.zxPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperId + "'");
 }
 
 if (objzx_CompositionEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperTitle);
 var strPaperTitle = objzx_CompositionEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objzx_CompositionEN.PaperName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperName);
 var strPaperName = objzx_CompositionEN.PaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperName + "'");
 }
 
 if (objzx_CompositionEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperContent);
 var strPaperContent = objzx_CompositionEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objzx_CompositionEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Periodical);
 var strPeriodical = objzx_CompositionEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objzx_CompositionEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Author);
 var strAuthor = objzx_CompositionEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_CompositionEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchQuestion);
 var strResearchQuestion = objzx_CompositionEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objzx_CompositionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UpdDate);
 var strUpdDate = objzx_CompositionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_CompositionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Memo);
 var strMemo = objzx_CompositionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_CompositionEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Keyword);
 var strKeyword = objzx_CompositionEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objzx_CompositionEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.LiteratureSources);
 var strLiteratureSources = objzx_CompositionEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objzx_CompositionEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.LiteratureLink);
 var strLiteratureLink = objzx_CompositionEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objzx_CompositionEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UploadfileUrl);
 var strUploadfileUrl = objzx_CompositionEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.QuoteId);
 var strQuoteId = objzx_CompositionEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsChecked);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Checker);
 var strChecker = objzx_CompositionEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objzx_CompositionEN.zxLiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxLiteratureTypeId);
 var strzxLiteratureTypeId = objzx_CompositionEN.zxLiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLiteratureTypeId + "'");
 }
 
 if (objzx_CompositionEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.BrowseNumber);
 arrValueListForInsert.Add(objzx_CompositionEN.BrowseNumber.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AppraiseCount);
 arrValueListForInsert.Add(objzx_CompositionEN.AppraiseCount.ToString());
 }
 
 if (objzx_CompositionEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AttachmentCount);
 arrValueListForInsert.Add(objzx_CompositionEN.AttachmentCount.ToString());
 }
 
 if (objzx_CompositionEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.CollectionCount);
 arrValueListForInsert.Add(objzx_CompositionEN.CollectionCount.ToString());
 }
 
 if (objzx_CompositionEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.DownloadCount);
 arrValueListForInsert.Add(objzx_CompositionEN.DownloadCount.ToString());
 }
 
 if (objzx_CompositionEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.OkCount);
 arrValueListForInsert.Add(objzx_CompositionEN.OkCount.ToString());
 }
 
 if (objzx_CompositionEN.Pcount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Pcount);
 arrValueListForInsert.Add(objzx_CompositionEN.Pcount.ToString());
 }
 
 if (objzx_CompositionEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Score);
 arrValueListForInsert.Add(objzx_CompositionEN.Score.ToString());
 }
 
 if (objzx_CompositionEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.StuScore);
 arrValueListForInsert.Add(objzx_CompositionEN.StuScore.ToString());
 }
 
 if (objzx_CompositionEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TeaScore);
 arrValueListForInsert.Add(objzx_CompositionEN.TeaScore.ToString());
 }
 
 if (objzx_CompositionEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.IdCurrEduCls);
 var strIdCurrEduCls = objzx_CompositionEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_CompositionEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperTypeId);
 var strPaperTypeId = objzx_CompositionEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objzx_CompositionEN.zxPaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxPaperStatusId);
 var strzxPaperStatusId = objzx_CompositionEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperStatusId + "'");
 }
 
 if (objzx_CompositionEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.VersionCount);
 arrValueListForInsert.Add(objzx_CompositionEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.AskQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AskQuestion);
 var strAskQuestion = objzx_CompositionEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAskQuestion + "'");
 }
 
 if (objzx_CompositionEN.ResearchStatus !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchStatus);
 var strResearchStatus = objzx_CompositionEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchStatus + "'");
 }
 
 if (objzx_CompositionEN.InnovationPoints !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.InnovationPoints);
 var strInnovationPoints = objzx_CompositionEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInnovationPoints + "'");
 }
 
 if (objzx_CompositionEN.ResearchDesign !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchDesign);
 var strResearchDesign = objzx_CompositionEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchDesign + "'");
 }
 
 if (objzx_CompositionEN.DimensionDataProcess !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.DimensionDataProcess);
 var strDimensionDataProcess = objzx_CompositionEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDimensionDataProcess + "'");
 }
 
 if (objzx_CompositionEN.ExpectedConclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ExpectedConclusion);
 var strExpectedConclusion = objzx_CompositionEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExpectedConclusion + "'");
 }
 
 if (objzx_CompositionEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.CreateDate);
 var strCreateDate = objzx_CompositionEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_CompositionEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxShareId);
 var strzxShareId = objzx_CompositionEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_CompositionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UpdUser);
 var strUpdUser = objzx_CompositionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_CompositionEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperQCount);
 arrValueListForInsert.Add(objzx_CompositionEN.PaperQCount.ToString());
 }
 
 if (objzx_CompositionEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.SubVCount);
 arrValueListForInsert.Add(objzx_CompositionEN.SubVCount.ToString());
 }
 
 if (objzx_CompositionEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TagsCount);
 arrValueListForInsert.Add(objzx_CompositionEN.TagsCount.ToString());
 }
 
 if (objzx_CompositionEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TeaQCount);
 arrValueListForInsert.Add(objzx_CompositionEN.TeaQCount.ToString());
 }
 
 if (objzx_CompositionEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.GroupTextId);
 var strGroupTextId = objzx_CompositionEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Composition");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_CompositionEN.zxPaperId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_CompositionEN objzx_CompositionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_CompositionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_CompositionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_CompositionEN.zxPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxPaperId);
 var strzxPaperId = objzx_CompositionEN.zxPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperId + "'");
 }
 
 if (objzx_CompositionEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperTitle);
 var strPaperTitle = objzx_CompositionEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objzx_CompositionEN.PaperName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperName);
 var strPaperName = objzx_CompositionEN.PaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperName + "'");
 }
 
 if (objzx_CompositionEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperContent);
 var strPaperContent = objzx_CompositionEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objzx_CompositionEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Periodical);
 var strPeriodical = objzx_CompositionEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objzx_CompositionEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Author);
 var strAuthor = objzx_CompositionEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_CompositionEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchQuestion);
 var strResearchQuestion = objzx_CompositionEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objzx_CompositionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UpdDate);
 var strUpdDate = objzx_CompositionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_CompositionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Memo);
 var strMemo = objzx_CompositionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_CompositionEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Keyword);
 var strKeyword = objzx_CompositionEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objzx_CompositionEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.LiteratureSources);
 var strLiteratureSources = objzx_CompositionEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objzx_CompositionEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.LiteratureLink);
 var strLiteratureLink = objzx_CompositionEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objzx_CompositionEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UploadfileUrl);
 var strUploadfileUrl = objzx_CompositionEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.QuoteId);
 var strQuoteId = objzx_CompositionEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsChecked);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Checker);
 var strChecker = objzx_CompositionEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objzx_CompositionEN.zxLiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxLiteratureTypeId);
 var strzxLiteratureTypeId = objzx_CompositionEN.zxLiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLiteratureTypeId + "'");
 }
 
 if (objzx_CompositionEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.BrowseNumber);
 arrValueListForInsert.Add(objzx_CompositionEN.BrowseNumber.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AppraiseCount);
 arrValueListForInsert.Add(objzx_CompositionEN.AppraiseCount.ToString());
 }
 
 if (objzx_CompositionEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AttachmentCount);
 arrValueListForInsert.Add(objzx_CompositionEN.AttachmentCount.ToString());
 }
 
 if (objzx_CompositionEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.CollectionCount);
 arrValueListForInsert.Add(objzx_CompositionEN.CollectionCount.ToString());
 }
 
 if (objzx_CompositionEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.DownloadCount);
 arrValueListForInsert.Add(objzx_CompositionEN.DownloadCount.ToString());
 }
 
 if (objzx_CompositionEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.OkCount);
 arrValueListForInsert.Add(objzx_CompositionEN.OkCount.ToString());
 }
 
 if (objzx_CompositionEN.Pcount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Pcount);
 arrValueListForInsert.Add(objzx_CompositionEN.Pcount.ToString());
 }
 
 if (objzx_CompositionEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Score);
 arrValueListForInsert.Add(objzx_CompositionEN.Score.ToString());
 }
 
 if (objzx_CompositionEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.StuScore);
 arrValueListForInsert.Add(objzx_CompositionEN.StuScore.ToString());
 }
 
 if (objzx_CompositionEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TeaScore);
 arrValueListForInsert.Add(objzx_CompositionEN.TeaScore.ToString());
 }
 
 if (objzx_CompositionEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.IdCurrEduCls);
 var strIdCurrEduCls = objzx_CompositionEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_CompositionEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperTypeId);
 var strPaperTypeId = objzx_CompositionEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objzx_CompositionEN.zxPaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxPaperStatusId);
 var strzxPaperStatusId = objzx_CompositionEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperStatusId + "'");
 }
 
 if (objzx_CompositionEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.VersionCount);
 arrValueListForInsert.Add(objzx_CompositionEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.AskQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AskQuestion);
 var strAskQuestion = objzx_CompositionEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAskQuestion + "'");
 }
 
 if (objzx_CompositionEN.ResearchStatus !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchStatus);
 var strResearchStatus = objzx_CompositionEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchStatus + "'");
 }
 
 if (objzx_CompositionEN.InnovationPoints !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.InnovationPoints);
 var strInnovationPoints = objzx_CompositionEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInnovationPoints + "'");
 }
 
 if (objzx_CompositionEN.ResearchDesign !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchDesign);
 var strResearchDesign = objzx_CompositionEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchDesign + "'");
 }
 
 if (objzx_CompositionEN.DimensionDataProcess !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.DimensionDataProcess);
 var strDimensionDataProcess = objzx_CompositionEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDimensionDataProcess + "'");
 }
 
 if (objzx_CompositionEN.ExpectedConclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ExpectedConclusion);
 var strExpectedConclusion = objzx_CompositionEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExpectedConclusion + "'");
 }
 
 if (objzx_CompositionEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.CreateDate);
 var strCreateDate = objzx_CompositionEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_CompositionEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxShareId);
 var strzxShareId = objzx_CompositionEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_CompositionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UpdUser);
 var strUpdUser = objzx_CompositionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_CompositionEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperQCount);
 arrValueListForInsert.Add(objzx_CompositionEN.PaperQCount.ToString());
 }
 
 if (objzx_CompositionEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.SubVCount);
 arrValueListForInsert.Add(objzx_CompositionEN.SubVCount.ToString());
 }
 
 if (objzx_CompositionEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TagsCount);
 arrValueListForInsert.Add(objzx_CompositionEN.TagsCount.ToString());
 }
 
 if (objzx_CompositionEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TeaQCount);
 arrValueListForInsert.Add(objzx_CompositionEN.TeaQCount.ToString());
 }
 
 if (objzx_CompositionEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.GroupTextId);
 var strGroupTextId = objzx_CompositionEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Composition");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_CompositionEN.zxPaperId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_CompositionEN objzx_CompositionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_CompositionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_CompositionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_CompositionEN.zxPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxPaperId);
 var strzxPaperId = objzx_CompositionEN.zxPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperId + "'");
 }
 
 if (objzx_CompositionEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperTitle);
 var strPaperTitle = objzx_CompositionEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objzx_CompositionEN.PaperName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperName);
 var strPaperName = objzx_CompositionEN.PaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperName + "'");
 }
 
 if (objzx_CompositionEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperContent);
 var strPaperContent = objzx_CompositionEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objzx_CompositionEN.Periodical !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Periodical);
 var strPeriodical = objzx_CompositionEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPeriodical + "'");
 }
 
 if (objzx_CompositionEN.Author !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Author);
 var strAuthor = objzx_CompositionEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objzx_CompositionEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchQuestion);
 var strResearchQuestion = objzx_CompositionEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objzx_CompositionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UpdDate);
 var strUpdDate = objzx_CompositionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_CompositionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Memo);
 var strMemo = objzx_CompositionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_CompositionEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Keyword);
 var strKeyword = objzx_CompositionEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objzx_CompositionEN.LiteratureSources !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.LiteratureSources);
 var strLiteratureSources = objzx_CompositionEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSources + "'");
 }
 
 if (objzx_CompositionEN.LiteratureLink !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.LiteratureLink);
 var strLiteratureLink = objzx_CompositionEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureLink + "'");
 }
 
 if (objzx_CompositionEN.UploadfileUrl !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UploadfileUrl);
 var strUploadfileUrl = objzx_CompositionEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadfileUrl + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsQuotethesis);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsQuotethesis  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.QuoteId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.QuoteId);
 var strQuoteId = objzx_CompositionEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuoteId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsChecked);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.Checker !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Checker);
 var strChecker = objzx_CompositionEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChecker + "'");
 }
 
 if (objzx_CompositionEN.zxLiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxLiteratureTypeId);
 var strzxLiteratureTypeId = objzx_CompositionEN.zxLiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLiteratureTypeId + "'");
 }
 
 if (objzx_CompositionEN.BrowseNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.BrowseNumber);
 arrValueListForInsert.Add(objzx_CompositionEN.BrowseNumber.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AppraiseCount);
 arrValueListForInsert.Add(objzx_CompositionEN.AppraiseCount.ToString());
 }
 
 if (objzx_CompositionEN.AttachmentCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AttachmentCount);
 arrValueListForInsert.Add(objzx_CompositionEN.AttachmentCount.ToString());
 }
 
 if (objzx_CompositionEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.CollectionCount);
 arrValueListForInsert.Add(objzx_CompositionEN.CollectionCount.ToString());
 }
 
 if (objzx_CompositionEN.DownloadCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.DownloadCount);
 arrValueListForInsert.Add(objzx_CompositionEN.DownloadCount.ToString());
 }
 
 if (objzx_CompositionEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.OkCount);
 arrValueListForInsert.Add(objzx_CompositionEN.OkCount.ToString());
 }
 
 if (objzx_CompositionEN.Pcount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Pcount);
 arrValueListForInsert.Add(objzx_CompositionEN.Pcount.ToString());
 }
 
 if (objzx_CompositionEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.Score);
 arrValueListForInsert.Add(objzx_CompositionEN.Score.ToString());
 }
 
 if (objzx_CompositionEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.StuScore);
 arrValueListForInsert.Add(objzx_CompositionEN.StuScore.ToString());
 }
 
 if (objzx_CompositionEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TeaScore);
 arrValueListForInsert.Add(objzx_CompositionEN.TeaScore.ToString());
 }
 
 if (objzx_CompositionEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.IdCurrEduCls);
 var strIdCurrEduCls = objzx_CompositionEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_CompositionEN.PaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperTypeId);
 var strPaperTypeId = objzx_CompositionEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTypeId + "'");
 }
 
 if (objzx_CompositionEN.zxPaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxPaperStatusId);
 var strzxPaperStatusId = objzx_CompositionEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperStatusId + "'");
 }
 
 if (objzx_CompositionEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.VersionCount);
 arrValueListForInsert.Add(objzx_CompositionEN.VersionCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_Composition.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_CompositionEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objzx_CompositionEN.AskQuestion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.AskQuestion);
 var strAskQuestion = objzx_CompositionEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAskQuestion + "'");
 }
 
 if (objzx_CompositionEN.ResearchStatus !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchStatus);
 var strResearchStatus = objzx_CompositionEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchStatus + "'");
 }
 
 if (objzx_CompositionEN.InnovationPoints !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.InnovationPoints);
 var strInnovationPoints = objzx_CompositionEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInnovationPoints + "'");
 }
 
 if (objzx_CompositionEN.ResearchDesign !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ResearchDesign);
 var strResearchDesign = objzx_CompositionEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchDesign + "'");
 }
 
 if (objzx_CompositionEN.DimensionDataProcess !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.DimensionDataProcess);
 var strDimensionDataProcess = objzx_CompositionEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDimensionDataProcess + "'");
 }
 
 if (objzx_CompositionEN.ExpectedConclusion !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.ExpectedConclusion);
 var strExpectedConclusion = objzx_CompositionEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExpectedConclusion + "'");
 }
 
 if (objzx_CompositionEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.CreateDate);
 var strCreateDate = objzx_CompositionEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_CompositionEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.zxShareId);
 var strzxShareId = objzx_CompositionEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_CompositionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.UpdUser);
 var strUpdUser = objzx_CompositionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_CompositionEN.PaperQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.PaperQCount);
 arrValueListForInsert.Add(objzx_CompositionEN.PaperQCount.ToString());
 }
 
 if (objzx_CompositionEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.SubVCount);
 arrValueListForInsert.Add(objzx_CompositionEN.SubVCount.ToString());
 }
 
 if (objzx_CompositionEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TagsCount);
 arrValueListForInsert.Add(objzx_CompositionEN.TagsCount.ToString());
 }
 
 if (objzx_CompositionEN.TeaQCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.TeaQCount);
 arrValueListForInsert.Add(objzx_CompositionEN.TeaQCount.ToString());
 }
 
 if (objzx_CompositionEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Composition.GroupTextId);
 var strGroupTextId = objzx_CompositionEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Composition");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_Compositions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from zx_Composition where zxPaperId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Composition");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxPaperId = oRow[conzx_Composition.zxPaperId].ToString().Trim();
if (IsExist(strzxPaperId))
{
 string strResult = "关键字变量值为:" + string.Format("zxPaperId = {0}", strzxPaperId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_CompositionEN._CurrTabName ].NewRow();
objRow[conzx_Composition.zxPaperId] = oRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objRow[conzx_Composition.PaperTitle] = oRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objRow[conzx_Composition.PaperName] = oRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objRow[conzx_Composition.PaperContent] = oRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objRow[conzx_Composition.Periodical] = oRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objRow[conzx_Composition.Author] = oRow[conzx_Composition.Author].ToString().Trim(); //作者
objRow[conzx_Composition.ResearchQuestion] = oRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objRow[conzx_Composition.UpdDate] = oRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_Composition.Memo] = oRow[conzx_Composition.Memo].ToString().Trim(); //备注
objRow[conzx_Composition.Keyword] = oRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objRow[conzx_Composition.LiteratureSources] = oRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objRow[conzx_Composition.LiteratureLink] = oRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objRow[conzx_Composition.UploadfileUrl] = oRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objRow[conzx_Composition.IsQuotethesis] = oRow[conzx_Composition.IsQuotethesis].ToString().Trim(); //是否引用论文
objRow[conzx_Composition.QuoteId] = oRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objRow[conzx_Composition.IsChecked] = oRow[conzx_Composition.IsChecked].ToString().Trim(); //是否检查
objRow[conzx_Composition.Checker] = oRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objRow[conzx_Composition.zxLiteratureTypeId] = oRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objRow[conzx_Composition.BrowseNumber] = oRow[conzx_Composition.BrowseNumber].ToString().Trim(); //浏览量
objRow[conzx_Composition.IsSubmit] = oRow[conzx_Composition.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_Composition.AppraiseCount] = oRow[conzx_Composition.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_Composition.AttachmentCount] = oRow[conzx_Composition.AttachmentCount].ToString().Trim(); //附件计数
objRow[conzx_Composition.CollectionCount] = oRow[conzx_Composition.CollectionCount].ToString().Trim(); //收藏数量
objRow[conzx_Composition.DownloadCount] = oRow[conzx_Composition.DownloadCount].ToString().Trim(); //下载数
objRow[conzx_Composition.OkCount] = oRow[conzx_Composition.OkCount].ToString().Trim(); //点赞统计
objRow[conzx_Composition.Pcount] = oRow[conzx_Composition.Pcount].ToString().Trim(); //读写数
objRow[conzx_Composition.Score] = oRow[conzx_Composition.Score].ToString().Trim(); //评分
objRow[conzx_Composition.StuScore] = oRow[conzx_Composition.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_Composition.TeaScore] = oRow[conzx_Composition.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_Composition.IdCurrEduCls] = oRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_Composition.PaperTypeId] = oRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objRow[conzx_Composition.zxPaperStatusId] = oRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objRow[conzx_Composition.VersionCount] = oRow[conzx_Composition.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_Composition.IsPublic] = oRow[conzx_Composition.IsPublic].ToString().Trim(); //是否公开
objRow[conzx_Composition.AskQuestion] = oRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objRow[conzx_Composition.ResearchStatus] = oRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objRow[conzx_Composition.InnovationPoints] = oRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objRow[conzx_Composition.ResearchDesign] = oRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objRow[conzx_Composition.DimensionDataProcess] = oRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objRow[conzx_Composition.ExpectedConclusion] = oRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objRow[conzx_Composition.CreateDate] = oRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_Composition.zxShareId] = oRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_Composition.UpdUser] = oRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objRow[conzx_Composition.PaperQCount] = oRow[conzx_Composition.PaperQCount].ToString().Trim(); //论文答疑数
objRow[conzx_Composition.SubVCount] = oRow[conzx_Composition.SubVCount].ToString().Trim(); //论文子观点数
objRow[conzx_Composition.TagsCount] = oRow[conzx_Composition.TagsCount].ToString().Trim(); //论文标注数
objRow[conzx_Composition.TeaQCount] = oRow[conzx_Composition.TeaQCount].ToString().Trim(); //教师提问数
objRow[conzx_Composition.GroupTextId] = oRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_CompositionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_CompositionEN._CurrTabName);
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
 /// <param name = "objzx_CompositionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_CompositionEN objzx_CompositionEN)
{
 if (objzx_CompositionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_CompositionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from zx_Composition where zxPaperId = " + "'"+ objzx_CompositionEN.zxPaperId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_CompositionEN._CurrTabName);
if (objDS.Tables[clszx_CompositionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxPaperId = " + "'"+ objzx_CompositionEN.zxPaperId+"'");
return false;
}
objRow = objDS.Tables[clszx_CompositionEN._CurrTabName].Rows[0];
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxPaperId))
 {
objRow[conzx_Composition.zxPaperId] = objzx_CompositionEN.zxPaperId; //论文Id
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperTitle))
 {
objRow[conzx_Composition.PaperTitle] = objzx_CompositionEN.PaperTitle; //论文标题
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperName))
 {
objRow[conzx_Composition.PaperName] = objzx_CompositionEN.PaperName; //主题名称
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperContent))
 {
objRow[conzx_Composition.PaperContent] = objzx_CompositionEN.PaperContent; //主题内容
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Periodical))
 {
objRow[conzx_Composition.Periodical] = objzx_CompositionEN.Periodical; //期刊
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Author))
 {
objRow[conzx_Composition.Author] = objzx_CompositionEN.Author; //作者
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchQuestion))
 {
objRow[conzx_Composition.ResearchQuestion] = objzx_CompositionEN.ResearchQuestion; //研究问题
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UpdDate))
 {
objRow[conzx_Composition.UpdDate] = objzx_CompositionEN.UpdDate; //修改日期
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Memo))
 {
objRow[conzx_Composition.Memo] = objzx_CompositionEN.Memo; //备注
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Keyword))
 {
objRow[conzx_Composition.Keyword] = objzx_CompositionEN.Keyword; //关键字
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.LiteratureSources))
 {
objRow[conzx_Composition.LiteratureSources] = objzx_CompositionEN.LiteratureSources; //文献来源
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.LiteratureLink))
 {
objRow[conzx_Composition.LiteratureLink] = objzx_CompositionEN.LiteratureLink; //文献链接
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UploadfileUrl))
 {
objRow[conzx_Composition.UploadfileUrl] = objzx_CompositionEN.UploadfileUrl; //文件地址
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsQuotethesis))
 {
objRow[conzx_Composition.IsQuotethesis] = objzx_CompositionEN.IsQuotethesis; //是否引用论文
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.QuoteId))
 {
objRow[conzx_Composition.QuoteId] = objzx_CompositionEN.QuoteId; //引用Id
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsChecked))
 {
objRow[conzx_Composition.IsChecked] = objzx_CompositionEN.IsChecked; //是否检查
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Checker))
 {
objRow[conzx_Composition.Checker] = objzx_CompositionEN.Checker; //审核人
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxLiteratureTypeId))
 {
objRow[conzx_Composition.zxLiteratureTypeId] = objzx_CompositionEN.zxLiteratureTypeId; //作文类型Id
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.BrowseNumber))
 {
objRow[conzx_Composition.BrowseNumber] = objzx_CompositionEN.BrowseNumber; //浏览量
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsSubmit))
 {
objRow[conzx_Composition.IsSubmit] = objzx_CompositionEN.IsSubmit; //是否提交
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AppraiseCount))
 {
objRow[conzx_Composition.AppraiseCount] = objzx_CompositionEN.AppraiseCount; //评论数
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AttachmentCount))
 {
objRow[conzx_Composition.AttachmentCount] = objzx_CompositionEN.AttachmentCount; //附件计数
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.CollectionCount))
 {
objRow[conzx_Composition.CollectionCount] = objzx_CompositionEN.CollectionCount; //收藏数量
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.DownloadCount))
 {
objRow[conzx_Composition.DownloadCount] = objzx_CompositionEN.DownloadCount; //下载数
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.OkCount))
 {
objRow[conzx_Composition.OkCount] = objzx_CompositionEN.OkCount; //点赞统计
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Pcount))
 {
objRow[conzx_Composition.Pcount] = objzx_CompositionEN.Pcount; //读写数
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Score))
 {
objRow[conzx_Composition.Score] = objzx_CompositionEN.Score; //评分
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.StuScore))
 {
objRow[conzx_Composition.StuScore] = objzx_CompositionEN.StuScore; //学生平均分
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TeaScore))
 {
objRow[conzx_Composition.TeaScore] = objzx_CompositionEN.TeaScore; //教师评分
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IdCurrEduCls))
 {
objRow[conzx_Composition.IdCurrEduCls] = objzx_CompositionEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperTypeId))
 {
objRow[conzx_Composition.PaperTypeId] = objzx_CompositionEN.PaperTypeId; //论文类型Id
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxPaperStatusId))
 {
objRow[conzx_Composition.zxPaperStatusId] = objzx_CompositionEN.zxPaperStatusId; //论文状态Id
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.VersionCount))
 {
objRow[conzx_Composition.VersionCount] = objzx_CompositionEN.VersionCount; //版本统计
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsPublic))
 {
objRow[conzx_Composition.IsPublic] = objzx_CompositionEN.IsPublic; //是否公开
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AskQuestion))
 {
objRow[conzx_Composition.AskQuestion] = objzx_CompositionEN.AskQuestion; //问题提出
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchStatus))
 {
objRow[conzx_Composition.ResearchStatus] = objzx_CompositionEN.ResearchStatus; //目前研究的现状
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.InnovationPoints))
 {
objRow[conzx_Composition.InnovationPoints] = objzx_CompositionEN.InnovationPoints; //创新点
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchDesign))
 {
objRow[conzx_Composition.ResearchDesign] = objzx_CompositionEN.ResearchDesign; //研究设计
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.DimensionDataProcess))
 {
objRow[conzx_Composition.DimensionDataProcess] = objzx_CompositionEN.DimensionDataProcess; //数据处理的维度
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ExpectedConclusion))
 {
objRow[conzx_Composition.ExpectedConclusion] = objzx_CompositionEN.ExpectedConclusion; //预期结论
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.CreateDate))
 {
objRow[conzx_Composition.CreateDate] = objzx_CompositionEN.CreateDate; //建立日期
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxShareId))
 {
objRow[conzx_Composition.zxShareId] = objzx_CompositionEN.zxShareId; //分享Id
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UpdUser))
 {
objRow[conzx_Composition.UpdUser] = objzx_CompositionEN.UpdUser; //修改人
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperQCount))
 {
objRow[conzx_Composition.PaperQCount] = objzx_CompositionEN.PaperQCount; //论文答疑数
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.SubVCount))
 {
objRow[conzx_Composition.SubVCount] = objzx_CompositionEN.SubVCount; //论文子观点数
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TagsCount))
 {
objRow[conzx_Composition.TagsCount] = objzx_CompositionEN.TagsCount; //论文标注数
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TeaQCount))
 {
objRow[conzx_Composition.TeaQCount] = objzx_CompositionEN.TeaQCount; //教师提问数
 }
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.GroupTextId))
 {
objRow[conzx_Composition.GroupTextId] = objzx_CompositionEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_CompositionEN._CurrTabName);
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
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_CompositionEN objzx_CompositionEN)
{
 if (objzx_CompositionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_CompositionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_Composition Set ");
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperTitle))
 {
 if (objzx_CompositionEN.PaperTitle !=  null)
 {
 var strPaperTitle = objzx_CompositionEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTitle, conzx_Composition.PaperTitle); //论文标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperTitle); //论文标题
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperName))
 {
 if (objzx_CompositionEN.PaperName !=  null)
 {
 var strPaperName = objzx_CompositionEN.PaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperName, conzx_Composition.PaperName); //主题名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperName); //主题名称
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperContent))
 {
 if (objzx_CompositionEN.PaperContent !=  null)
 {
 var strPaperContent = objzx_CompositionEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperContent, conzx_Composition.PaperContent); //主题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperContent); //主题内容
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Periodical))
 {
 if (objzx_CompositionEN.Periodical !=  null)
 {
 var strPeriodical = objzx_CompositionEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPeriodical, conzx_Composition.Periodical); //期刊
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Periodical); //期刊
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Author))
 {
 if (objzx_CompositionEN.Author !=  null)
 {
 var strAuthor = objzx_CompositionEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, conzx_Composition.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Author); //作者
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchQuestion))
 {
 if (objzx_CompositionEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objzx_CompositionEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchQuestion, conzx_Composition.ResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.ResearchQuestion); //研究问题
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UpdDate))
 {
 if (objzx_CompositionEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_CompositionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Composition.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.UpdDate); //修改日期
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Memo))
 {
 if (objzx_CompositionEN.Memo !=  null)
 {
 var strMemo = objzx_CompositionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Composition.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Memo); //备注
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Keyword))
 {
 if (objzx_CompositionEN.Keyword !=  null)
 {
 var strKeyword = objzx_CompositionEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conzx_Composition.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Keyword); //关键字
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.LiteratureSources))
 {
 if (objzx_CompositionEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objzx_CompositionEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureSources, conzx_Composition.LiteratureSources); //文献来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.LiteratureSources); //文献来源
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.LiteratureLink))
 {
 if (objzx_CompositionEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objzx_CompositionEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureLink, conzx_Composition.LiteratureLink); //文献链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.LiteratureLink); //文献链接
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UploadfileUrl))
 {
 if (objzx_CompositionEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objzx_CompositionEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadfileUrl, conzx_Composition.UploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.UploadfileUrl); //文件地址
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsQuotethesis))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_CompositionEN.IsQuotethesis == true?"1":"0", conzx_Composition.IsQuotethesis); //是否引用论文
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.QuoteId))
 {
 if (objzx_CompositionEN.QuoteId !=  null)
 {
 var strQuoteId = objzx_CompositionEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuoteId, conzx_Composition.QuoteId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.QuoteId); //引用Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_CompositionEN.IsChecked == true?"1":"0", conzx_Composition.IsChecked); //是否检查
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Checker))
 {
 if (objzx_CompositionEN.Checker !=  null)
 {
 var strChecker = objzx_CompositionEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChecker, conzx_Composition.Checker); //审核人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Checker); //审核人
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxLiteratureTypeId))
 {
 if (objzx_CompositionEN.zxLiteratureTypeId !=  null)
 {
 var strzxLiteratureTypeId = objzx_CompositionEN.zxLiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxLiteratureTypeId, conzx_Composition.zxLiteratureTypeId); //作文类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.zxLiteratureTypeId); //作文类型Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.BrowseNumber))
 {
 if (objzx_CompositionEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.BrowseNumber, conzx_Composition.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.BrowseNumber); //浏览量
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_CompositionEN.IsSubmit == true?"1":"0", conzx_Composition.IsSubmit); //是否提交
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AppraiseCount))
 {
 if (objzx_CompositionEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.AppraiseCount, conzx_Composition.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.AppraiseCount); //评论数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AttachmentCount))
 {
 if (objzx_CompositionEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.AttachmentCount, conzx_Composition.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.CollectionCount))
 {
 if (objzx_CompositionEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.CollectionCount, conzx_Composition.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.DownloadCount))
 {
 if (objzx_CompositionEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.DownloadCount, conzx_Composition.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.DownloadCount); //下载数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.OkCount))
 {
 if (objzx_CompositionEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.OkCount, conzx_Composition.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.OkCount); //点赞统计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Pcount))
 {
 if (objzx_CompositionEN.Pcount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.Pcount, conzx_Composition.Pcount); //读写数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Pcount); //读写数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Score))
 {
 if (objzx_CompositionEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.Score, conzx_Composition.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Score); //评分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.StuScore))
 {
 if (objzx_CompositionEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.StuScore, conzx_Composition.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.StuScore); //学生平均分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TeaScore))
 {
 if (objzx_CompositionEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TeaScore, conzx_Composition.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TeaScore); //教师评分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IdCurrEduCls))
 {
 if (objzx_CompositionEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_CompositionEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Composition.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperTypeId))
 {
 if (objzx_CompositionEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objzx_CompositionEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTypeId, conzx_Composition.PaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperTypeId); //论文类型Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxPaperStatusId))
 {
 if (objzx_CompositionEN.zxPaperStatusId !=  null)
 {
 var strzxPaperStatusId = objzx_CompositionEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxPaperStatusId, conzx_Composition.zxPaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.zxPaperStatusId); //论文状态Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.VersionCount))
 {
 if (objzx_CompositionEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.VersionCount, conzx_Composition.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.VersionCount); //版本统计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_CompositionEN.IsPublic == true?"1":"0", conzx_Composition.IsPublic); //是否公开
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AskQuestion))
 {
 if (objzx_CompositionEN.AskQuestion !=  null)
 {
 var strAskQuestion = objzx_CompositionEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAskQuestion, conzx_Composition.AskQuestion); //问题提出
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.AskQuestion); //问题提出
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchStatus))
 {
 if (objzx_CompositionEN.ResearchStatus !=  null)
 {
 var strResearchStatus = objzx_CompositionEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchStatus, conzx_Composition.ResearchStatus); //目前研究的现状
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.ResearchStatus); //目前研究的现状
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.InnovationPoints))
 {
 if (objzx_CompositionEN.InnovationPoints !=  null)
 {
 var strInnovationPoints = objzx_CompositionEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInnovationPoints, conzx_Composition.InnovationPoints); //创新点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.InnovationPoints); //创新点
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchDesign))
 {
 if (objzx_CompositionEN.ResearchDesign !=  null)
 {
 var strResearchDesign = objzx_CompositionEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchDesign, conzx_Composition.ResearchDesign); //研究设计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.ResearchDesign); //研究设计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.DimensionDataProcess))
 {
 if (objzx_CompositionEN.DimensionDataProcess !=  null)
 {
 var strDimensionDataProcess = objzx_CompositionEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDimensionDataProcess, conzx_Composition.DimensionDataProcess); //数据处理的维度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.DimensionDataProcess); //数据处理的维度
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ExpectedConclusion))
 {
 if (objzx_CompositionEN.ExpectedConclusion !=  null)
 {
 var strExpectedConclusion = objzx_CompositionEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExpectedConclusion, conzx_Composition.ExpectedConclusion); //预期结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.ExpectedConclusion); //预期结论
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.CreateDate))
 {
 if (objzx_CompositionEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_CompositionEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Composition.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.CreateDate); //建立日期
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxShareId))
 {
 if (objzx_CompositionEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_CompositionEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Composition.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.zxShareId); //分享Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UpdUser))
 {
 if (objzx_CompositionEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_CompositionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Composition.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.UpdUser); //修改人
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperQCount))
 {
 if (objzx_CompositionEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.PaperQCount, conzx_Composition.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperQCount); //论文答疑数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.SubVCount))
 {
 if (objzx_CompositionEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.SubVCount, conzx_Composition.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.SubVCount); //论文子观点数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TagsCount))
 {
 if (objzx_CompositionEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TagsCount, conzx_Composition.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TagsCount); //论文标注数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TeaQCount))
 {
 if (objzx_CompositionEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TeaQCount, conzx_Composition.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TeaQCount); //教师提问数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.GroupTextId))
 {
 if (objzx_CompositionEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_CompositionEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_Composition.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxPaperId = '{0}'", objzx_CompositionEN.zxPaperId); 
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
 /// <param name = "objzx_CompositionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_CompositionEN objzx_CompositionEN, string strCondition)
{
 if (objzx_CompositionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_CompositionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Composition Set ");
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperTitle))
 {
 if (objzx_CompositionEN.PaperTitle !=  null)
 {
 var strPaperTitle = objzx_CompositionEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTitle = '{0}',", strPaperTitle); //论文标题
 }
 else
 {
 sbSQL.Append(" PaperTitle = null,"); //论文标题
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperName))
 {
 if (objzx_CompositionEN.PaperName !=  null)
 {
 var strPaperName = objzx_CompositionEN.PaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperName = '{0}',", strPaperName); //主题名称
 }
 else
 {
 sbSQL.Append(" PaperName = null,"); //主题名称
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperContent))
 {
 if (objzx_CompositionEN.PaperContent !=  null)
 {
 var strPaperContent = objzx_CompositionEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperContent = '{0}',", strPaperContent); //主题内容
 }
 else
 {
 sbSQL.Append(" PaperContent = null,"); //主题内容
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Periodical))
 {
 if (objzx_CompositionEN.Periodical !=  null)
 {
 var strPeriodical = objzx_CompositionEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Periodical = '{0}',", strPeriodical); //期刊
 }
 else
 {
 sbSQL.Append(" Periodical = null,"); //期刊
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Author))
 {
 if (objzx_CompositionEN.Author !=  null)
 {
 var strAuthor = objzx_CompositionEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchQuestion))
 {
 if (objzx_CompositionEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objzx_CompositionEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchQuestion = '{0}',", strResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.Append(" ResearchQuestion = null,"); //研究问题
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UpdDate))
 {
 if (objzx_CompositionEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_CompositionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Memo))
 {
 if (objzx_CompositionEN.Memo !=  null)
 {
 var strMemo = objzx_CompositionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Keyword))
 {
 if (objzx_CompositionEN.Keyword !=  null)
 {
 var strKeyword = objzx_CompositionEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.LiteratureSources))
 {
 if (objzx_CompositionEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objzx_CompositionEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureSources = '{0}',", strLiteratureSources); //文献来源
 }
 else
 {
 sbSQL.Append(" LiteratureSources = null,"); //文献来源
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.LiteratureLink))
 {
 if (objzx_CompositionEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objzx_CompositionEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureLink = '{0}',", strLiteratureLink); //文献链接
 }
 else
 {
 sbSQL.Append(" LiteratureLink = null,"); //文献链接
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UploadfileUrl))
 {
 if (objzx_CompositionEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objzx_CompositionEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadfileUrl = '{0}',", strUploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.Append(" UploadfileUrl = null,"); //文件地址
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsQuotethesis))
 {
 sbSQL.AppendFormat(" IsQuotethesis = '{0}',", objzx_CompositionEN.IsQuotethesis == true?"1":"0"); //是否引用论文
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.QuoteId))
 {
 if (objzx_CompositionEN.QuoteId !=  null)
 {
 var strQuoteId = objzx_CompositionEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuoteId = '{0}',", strQuoteId); //引用Id
 }
 else
 {
 sbSQL.Append(" QuoteId = null,"); //引用Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objzx_CompositionEN.IsChecked == true?"1":"0"); //是否检查
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Checker))
 {
 if (objzx_CompositionEN.Checker !=  null)
 {
 var strChecker = objzx_CompositionEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Checker = '{0}',", strChecker); //审核人
 }
 else
 {
 sbSQL.Append(" Checker = null,"); //审核人
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxLiteratureTypeId))
 {
 if (objzx_CompositionEN.zxLiteratureTypeId !=  null)
 {
 var strzxLiteratureTypeId = objzx_CompositionEN.zxLiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxLiteratureTypeId = '{0}',", strzxLiteratureTypeId); //作文类型Id
 }
 else
 {
 sbSQL.Append(" zxLiteratureTypeId = null,"); //作文类型Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.BrowseNumber))
 {
 if (objzx_CompositionEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.BrowseNumber, conzx_Composition.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.BrowseNumber); //浏览量
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_CompositionEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AppraiseCount))
 {
 if (objzx_CompositionEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.AppraiseCount, conzx_Composition.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.AppraiseCount); //评论数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AttachmentCount))
 {
 if (objzx_CompositionEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.AttachmentCount, conzx_Composition.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.CollectionCount))
 {
 if (objzx_CompositionEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.CollectionCount, conzx_Composition.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.DownloadCount))
 {
 if (objzx_CompositionEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.DownloadCount, conzx_Composition.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.DownloadCount); //下载数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.OkCount))
 {
 if (objzx_CompositionEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.OkCount, conzx_Composition.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.OkCount); //点赞统计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Pcount))
 {
 if (objzx_CompositionEN.Pcount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.Pcount, conzx_Composition.Pcount); //读写数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Pcount); //读写数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Score))
 {
 if (objzx_CompositionEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.Score, conzx_Composition.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Score); //评分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.StuScore))
 {
 if (objzx_CompositionEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.StuScore, conzx_Composition.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.StuScore); //学生平均分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TeaScore))
 {
 if (objzx_CompositionEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TeaScore, conzx_Composition.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TeaScore); //教师评分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IdCurrEduCls))
 {
 if (objzx_CompositionEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_CompositionEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperTypeId))
 {
 if (objzx_CompositionEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objzx_CompositionEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTypeId = '{0}',", strPaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.Append(" PaperTypeId = null,"); //论文类型Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxPaperStatusId))
 {
 if (objzx_CompositionEN.zxPaperStatusId !=  null)
 {
 var strzxPaperStatusId = objzx_CompositionEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxPaperStatusId = '{0}',", strzxPaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.Append(" zxPaperStatusId = null,"); //论文状态Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.VersionCount))
 {
 if (objzx_CompositionEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.VersionCount, conzx_Composition.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.VersionCount); //版本统计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_CompositionEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AskQuestion))
 {
 if (objzx_CompositionEN.AskQuestion !=  null)
 {
 var strAskQuestion = objzx_CompositionEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AskQuestion = '{0}',", strAskQuestion); //问题提出
 }
 else
 {
 sbSQL.Append(" AskQuestion = null,"); //问题提出
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchStatus))
 {
 if (objzx_CompositionEN.ResearchStatus !=  null)
 {
 var strResearchStatus = objzx_CompositionEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchStatus = '{0}',", strResearchStatus); //目前研究的现状
 }
 else
 {
 sbSQL.Append(" ResearchStatus = null,"); //目前研究的现状
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.InnovationPoints))
 {
 if (objzx_CompositionEN.InnovationPoints !=  null)
 {
 var strInnovationPoints = objzx_CompositionEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InnovationPoints = '{0}',", strInnovationPoints); //创新点
 }
 else
 {
 sbSQL.Append(" InnovationPoints = null,"); //创新点
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchDesign))
 {
 if (objzx_CompositionEN.ResearchDesign !=  null)
 {
 var strResearchDesign = objzx_CompositionEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchDesign = '{0}',", strResearchDesign); //研究设计
 }
 else
 {
 sbSQL.Append(" ResearchDesign = null,"); //研究设计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.DimensionDataProcess))
 {
 if (objzx_CompositionEN.DimensionDataProcess !=  null)
 {
 var strDimensionDataProcess = objzx_CompositionEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DimensionDataProcess = '{0}',", strDimensionDataProcess); //数据处理的维度
 }
 else
 {
 sbSQL.Append(" DimensionDataProcess = null,"); //数据处理的维度
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ExpectedConclusion))
 {
 if (objzx_CompositionEN.ExpectedConclusion !=  null)
 {
 var strExpectedConclusion = objzx_CompositionEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExpectedConclusion = '{0}',", strExpectedConclusion); //预期结论
 }
 else
 {
 sbSQL.Append(" ExpectedConclusion = null,"); //预期结论
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.CreateDate))
 {
 if (objzx_CompositionEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_CompositionEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxShareId))
 {
 if (objzx_CompositionEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_CompositionEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UpdUser))
 {
 if (objzx_CompositionEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_CompositionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperQCount))
 {
 if (objzx_CompositionEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.PaperQCount, conzx_Composition.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperQCount); //论文答疑数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.SubVCount))
 {
 if (objzx_CompositionEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.SubVCount, conzx_Composition.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.SubVCount); //论文子观点数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TagsCount))
 {
 if (objzx_CompositionEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TagsCount, conzx_Composition.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TagsCount); //论文标注数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TeaQCount))
 {
 if (objzx_CompositionEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TeaQCount, conzx_Composition.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TeaQCount); //教师提问数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.GroupTextId))
 {
 if (objzx_CompositionEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_CompositionEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_CompositionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_CompositionEN objzx_CompositionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_CompositionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_CompositionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Composition Set ");
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperTitle))
 {
 if (objzx_CompositionEN.PaperTitle !=  null)
 {
 var strPaperTitle = objzx_CompositionEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTitle = '{0}',", strPaperTitle); //论文标题
 }
 else
 {
 sbSQL.Append(" PaperTitle = null,"); //论文标题
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperName))
 {
 if (objzx_CompositionEN.PaperName !=  null)
 {
 var strPaperName = objzx_CompositionEN.PaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperName = '{0}',", strPaperName); //主题名称
 }
 else
 {
 sbSQL.Append(" PaperName = null,"); //主题名称
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperContent))
 {
 if (objzx_CompositionEN.PaperContent !=  null)
 {
 var strPaperContent = objzx_CompositionEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperContent = '{0}',", strPaperContent); //主题内容
 }
 else
 {
 sbSQL.Append(" PaperContent = null,"); //主题内容
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Periodical))
 {
 if (objzx_CompositionEN.Periodical !=  null)
 {
 var strPeriodical = objzx_CompositionEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Periodical = '{0}',", strPeriodical); //期刊
 }
 else
 {
 sbSQL.Append(" Periodical = null,"); //期刊
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Author))
 {
 if (objzx_CompositionEN.Author !=  null)
 {
 var strAuthor = objzx_CompositionEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchQuestion))
 {
 if (objzx_CompositionEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objzx_CompositionEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchQuestion = '{0}',", strResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.Append(" ResearchQuestion = null,"); //研究问题
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UpdDate))
 {
 if (objzx_CompositionEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_CompositionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Memo))
 {
 if (objzx_CompositionEN.Memo !=  null)
 {
 var strMemo = objzx_CompositionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Keyword))
 {
 if (objzx_CompositionEN.Keyword !=  null)
 {
 var strKeyword = objzx_CompositionEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.LiteratureSources))
 {
 if (objzx_CompositionEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objzx_CompositionEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureSources = '{0}',", strLiteratureSources); //文献来源
 }
 else
 {
 sbSQL.Append(" LiteratureSources = null,"); //文献来源
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.LiteratureLink))
 {
 if (objzx_CompositionEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objzx_CompositionEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureLink = '{0}',", strLiteratureLink); //文献链接
 }
 else
 {
 sbSQL.Append(" LiteratureLink = null,"); //文献链接
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UploadfileUrl))
 {
 if (objzx_CompositionEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objzx_CompositionEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadfileUrl = '{0}',", strUploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.Append(" UploadfileUrl = null,"); //文件地址
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsQuotethesis))
 {
 sbSQL.AppendFormat(" IsQuotethesis = '{0}',", objzx_CompositionEN.IsQuotethesis == true?"1":"0"); //是否引用论文
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.QuoteId))
 {
 if (objzx_CompositionEN.QuoteId !=  null)
 {
 var strQuoteId = objzx_CompositionEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuoteId = '{0}',", strQuoteId); //引用Id
 }
 else
 {
 sbSQL.Append(" QuoteId = null,"); //引用Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objzx_CompositionEN.IsChecked == true?"1":"0"); //是否检查
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Checker))
 {
 if (objzx_CompositionEN.Checker !=  null)
 {
 var strChecker = objzx_CompositionEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Checker = '{0}',", strChecker); //审核人
 }
 else
 {
 sbSQL.Append(" Checker = null,"); //审核人
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxLiteratureTypeId))
 {
 if (objzx_CompositionEN.zxLiteratureTypeId !=  null)
 {
 var strzxLiteratureTypeId = objzx_CompositionEN.zxLiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxLiteratureTypeId = '{0}',", strzxLiteratureTypeId); //作文类型Id
 }
 else
 {
 sbSQL.Append(" zxLiteratureTypeId = null,"); //作文类型Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.BrowseNumber))
 {
 if (objzx_CompositionEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.BrowseNumber, conzx_Composition.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.BrowseNumber); //浏览量
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_CompositionEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AppraiseCount))
 {
 if (objzx_CompositionEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.AppraiseCount, conzx_Composition.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.AppraiseCount); //评论数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AttachmentCount))
 {
 if (objzx_CompositionEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.AttachmentCount, conzx_Composition.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.CollectionCount))
 {
 if (objzx_CompositionEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.CollectionCount, conzx_Composition.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.DownloadCount))
 {
 if (objzx_CompositionEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.DownloadCount, conzx_Composition.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.DownloadCount); //下载数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.OkCount))
 {
 if (objzx_CompositionEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.OkCount, conzx_Composition.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.OkCount); //点赞统计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Pcount))
 {
 if (objzx_CompositionEN.Pcount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.Pcount, conzx_Composition.Pcount); //读写数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Pcount); //读写数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Score))
 {
 if (objzx_CompositionEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.Score, conzx_Composition.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Score); //评分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.StuScore))
 {
 if (objzx_CompositionEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.StuScore, conzx_Composition.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.StuScore); //学生平均分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TeaScore))
 {
 if (objzx_CompositionEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TeaScore, conzx_Composition.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TeaScore); //教师评分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IdCurrEduCls))
 {
 if (objzx_CompositionEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_CompositionEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperTypeId))
 {
 if (objzx_CompositionEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objzx_CompositionEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTypeId = '{0}',", strPaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.Append(" PaperTypeId = null,"); //论文类型Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxPaperStatusId))
 {
 if (objzx_CompositionEN.zxPaperStatusId !=  null)
 {
 var strzxPaperStatusId = objzx_CompositionEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxPaperStatusId = '{0}',", strzxPaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.Append(" zxPaperStatusId = null,"); //论文状态Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.VersionCount))
 {
 if (objzx_CompositionEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.VersionCount, conzx_Composition.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.VersionCount); //版本统计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_CompositionEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AskQuestion))
 {
 if (objzx_CompositionEN.AskQuestion !=  null)
 {
 var strAskQuestion = objzx_CompositionEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AskQuestion = '{0}',", strAskQuestion); //问题提出
 }
 else
 {
 sbSQL.Append(" AskQuestion = null,"); //问题提出
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchStatus))
 {
 if (objzx_CompositionEN.ResearchStatus !=  null)
 {
 var strResearchStatus = objzx_CompositionEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchStatus = '{0}',", strResearchStatus); //目前研究的现状
 }
 else
 {
 sbSQL.Append(" ResearchStatus = null,"); //目前研究的现状
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.InnovationPoints))
 {
 if (objzx_CompositionEN.InnovationPoints !=  null)
 {
 var strInnovationPoints = objzx_CompositionEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InnovationPoints = '{0}',", strInnovationPoints); //创新点
 }
 else
 {
 sbSQL.Append(" InnovationPoints = null,"); //创新点
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchDesign))
 {
 if (objzx_CompositionEN.ResearchDesign !=  null)
 {
 var strResearchDesign = objzx_CompositionEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchDesign = '{0}',", strResearchDesign); //研究设计
 }
 else
 {
 sbSQL.Append(" ResearchDesign = null,"); //研究设计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.DimensionDataProcess))
 {
 if (objzx_CompositionEN.DimensionDataProcess !=  null)
 {
 var strDimensionDataProcess = objzx_CompositionEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DimensionDataProcess = '{0}',", strDimensionDataProcess); //数据处理的维度
 }
 else
 {
 sbSQL.Append(" DimensionDataProcess = null,"); //数据处理的维度
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ExpectedConclusion))
 {
 if (objzx_CompositionEN.ExpectedConclusion !=  null)
 {
 var strExpectedConclusion = objzx_CompositionEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExpectedConclusion = '{0}',", strExpectedConclusion); //预期结论
 }
 else
 {
 sbSQL.Append(" ExpectedConclusion = null,"); //预期结论
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.CreateDate))
 {
 if (objzx_CompositionEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_CompositionEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxShareId))
 {
 if (objzx_CompositionEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_CompositionEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UpdUser))
 {
 if (objzx_CompositionEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_CompositionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperQCount))
 {
 if (objzx_CompositionEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.PaperQCount, conzx_Composition.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperQCount); //论文答疑数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.SubVCount))
 {
 if (objzx_CompositionEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.SubVCount, conzx_Composition.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.SubVCount); //论文子观点数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TagsCount))
 {
 if (objzx_CompositionEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TagsCount, conzx_Composition.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TagsCount); //论文标注数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TeaQCount))
 {
 if (objzx_CompositionEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TeaQCount, conzx_Composition.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TeaQCount); //教师提问数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.GroupTextId))
 {
 if (objzx_CompositionEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_CompositionEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_CompositionEN objzx_CompositionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_CompositionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_CompositionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Composition Set ");
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperTitle))
 {
 if (objzx_CompositionEN.PaperTitle !=  null)
 {
 var strPaperTitle = objzx_CompositionEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTitle, conzx_Composition.PaperTitle); //论文标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperTitle); //论文标题
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperName))
 {
 if (objzx_CompositionEN.PaperName !=  null)
 {
 var strPaperName = objzx_CompositionEN.PaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperName, conzx_Composition.PaperName); //主题名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperName); //主题名称
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperContent))
 {
 if (objzx_CompositionEN.PaperContent !=  null)
 {
 var strPaperContent = objzx_CompositionEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperContent, conzx_Composition.PaperContent); //主题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperContent); //主题内容
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Periodical))
 {
 if (objzx_CompositionEN.Periodical !=  null)
 {
 var strPeriodical = objzx_CompositionEN.Periodical.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPeriodical, conzx_Composition.Periodical); //期刊
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Periodical); //期刊
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Author))
 {
 if (objzx_CompositionEN.Author !=  null)
 {
 var strAuthor = objzx_CompositionEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, conzx_Composition.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Author); //作者
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchQuestion))
 {
 if (objzx_CompositionEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objzx_CompositionEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchQuestion, conzx_Composition.ResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.ResearchQuestion); //研究问题
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UpdDate))
 {
 if (objzx_CompositionEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_CompositionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Composition.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.UpdDate); //修改日期
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Memo))
 {
 if (objzx_CompositionEN.Memo !=  null)
 {
 var strMemo = objzx_CompositionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Composition.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Memo); //备注
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Keyword))
 {
 if (objzx_CompositionEN.Keyword !=  null)
 {
 var strKeyword = objzx_CompositionEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conzx_Composition.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Keyword); //关键字
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.LiteratureSources))
 {
 if (objzx_CompositionEN.LiteratureSources !=  null)
 {
 var strLiteratureSources = objzx_CompositionEN.LiteratureSources.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureSources, conzx_Composition.LiteratureSources); //文献来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.LiteratureSources); //文献来源
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.LiteratureLink))
 {
 if (objzx_CompositionEN.LiteratureLink !=  null)
 {
 var strLiteratureLink = objzx_CompositionEN.LiteratureLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureLink, conzx_Composition.LiteratureLink); //文献链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.LiteratureLink); //文献链接
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UploadfileUrl))
 {
 if (objzx_CompositionEN.UploadfileUrl !=  null)
 {
 var strUploadfileUrl = objzx_CompositionEN.UploadfileUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadfileUrl, conzx_Composition.UploadfileUrl); //文件地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.UploadfileUrl); //文件地址
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsQuotethesis))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_CompositionEN.IsQuotethesis == true?"1":"0", conzx_Composition.IsQuotethesis); //是否引用论文
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.QuoteId))
 {
 if (objzx_CompositionEN.QuoteId !=  null)
 {
 var strQuoteId = objzx_CompositionEN.QuoteId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuoteId, conzx_Composition.QuoteId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.QuoteId); //引用Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_CompositionEN.IsChecked == true?"1":"0", conzx_Composition.IsChecked); //是否检查
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Checker))
 {
 if (objzx_CompositionEN.Checker !=  null)
 {
 var strChecker = objzx_CompositionEN.Checker.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChecker, conzx_Composition.Checker); //审核人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Checker); //审核人
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxLiteratureTypeId))
 {
 if (objzx_CompositionEN.zxLiteratureTypeId !=  null)
 {
 var strzxLiteratureTypeId = objzx_CompositionEN.zxLiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxLiteratureTypeId, conzx_Composition.zxLiteratureTypeId); //作文类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.zxLiteratureTypeId); //作文类型Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.BrowseNumber))
 {
 if (objzx_CompositionEN.BrowseNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.BrowseNumber, conzx_Composition.BrowseNumber); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.BrowseNumber); //浏览量
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_CompositionEN.IsSubmit == true?"1":"0", conzx_Composition.IsSubmit); //是否提交
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AppraiseCount))
 {
 if (objzx_CompositionEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.AppraiseCount, conzx_Composition.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.AppraiseCount); //评论数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AttachmentCount))
 {
 if (objzx_CompositionEN.AttachmentCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.AttachmentCount, conzx_Composition.AttachmentCount); //附件计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.AttachmentCount); //附件计数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.CollectionCount))
 {
 if (objzx_CompositionEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.CollectionCount, conzx_Composition.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.CollectionCount); //收藏数量
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.DownloadCount))
 {
 if (objzx_CompositionEN.DownloadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.DownloadCount, conzx_Composition.DownloadCount); //下载数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.DownloadCount); //下载数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.OkCount))
 {
 if (objzx_CompositionEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.OkCount, conzx_Composition.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.OkCount); //点赞统计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Pcount))
 {
 if (objzx_CompositionEN.Pcount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.Pcount, conzx_Composition.Pcount); //读写数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Pcount); //读写数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.Score))
 {
 if (objzx_CompositionEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.Score, conzx_Composition.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.Score); //评分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.StuScore))
 {
 if (objzx_CompositionEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.StuScore, conzx_Composition.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.StuScore); //学生平均分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TeaScore))
 {
 if (objzx_CompositionEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TeaScore, conzx_Composition.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TeaScore); //教师评分
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IdCurrEduCls))
 {
 if (objzx_CompositionEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_CompositionEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Composition.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperTypeId))
 {
 if (objzx_CompositionEN.PaperTypeId !=  null)
 {
 var strPaperTypeId = objzx_CompositionEN.PaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTypeId, conzx_Composition.PaperTypeId); //论文类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperTypeId); //论文类型Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxPaperStatusId))
 {
 if (objzx_CompositionEN.zxPaperStatusId !=  null)
 {
 var strzxPaperStatusId = objzx_CompositionEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxPaperStatusId, conzx_Composition.zxPaperStatusId); //论文状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.zxPaperStatusId); //论文状态Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.VersionCount))
 {
 if (objzx_CompositionEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.VersionCount, conzx_Composition.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.VersionCount); //版本统计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_CompositionEN.IsPublic == true?"1":"0", conzx_Composition.IsPublic); //是否公开
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.AskQuestion))
 {
 if (objzx_CompositionEN.AskQuestion !=  null)
 {
 var strAskQuestion = objzx_CompositionEN.AskQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAskQuestion, conzx_Composition.AskQuestion); //问题提出
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.AskQuestion); //问题提出
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchStatus))
 {
 if (objzx_CompositionEN.ResearchStatus !=  null)
 {
 var strResearchStatus = objzx_CompositionEN.ResearchStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchStatus, conzx_Composition.ResearchStatus); //目前研究的现状
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.ResearchStatus); //目前研究的现状
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.InnovationPoints))
 {
 if (objzx_CompositionEN.InnovationPoints !=  null)
 {
 var strInnovationPoints = objzx_CompositionEN.InnovationPoints.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInnovationPoints, conzx_Composition.InnovationPoints); //创新点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.InnovationPoints); //创新点
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ResearchDesign))
 {
 if (objzx_CompositionEN.ResearchDesign !=  null)
 {
 var strResearchDesign = objzx_CompositionEN.ResearchDesign.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchDesign, conzx_Composition.ResearchDesign); //研究设计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.ResearchDesign); //研究设计
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.DimensionDataProcess))
 {
 if (objzx_CompositionEN.DimensionDataProcess !=  null)
 {
 var strDimensionDataProcess = objzx_CompositionEN.DimensionDataProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDimensionDataProcess, conzx_Composition.DimensionDataProcess); //数据处理的维度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.DimensionDataProcess); //数据处理的维度
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.ExpectedConclusion))
 {
 if (objzx_CompositionEN.ExpectedConclusion !=  null)
 {
 var strExpectedConclusion = objzx_CompositionEN.ExpectedConclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExpectedConclusion, conzx_Composition.ExpectedConclusion); //预期结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.ExpectedConclusion); //预期结论
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.CreateDate))
 {
 if (objzx_CompositionEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_CompositionEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Composition.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.CreateDate); //建立日期
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.zxShareId))
 {
 if (objzx_CompositionEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_CompositionEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Composition.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.zxShareId); //分享Id
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.UpdUser))
 {
 if (objzx_CompositionEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_CompositionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Composition.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.UpdUser); //修改人
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.PaperQCount))
 {
 if (objzx_CompositionEN.PaperQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.PaperQCount, conzx_Composition.PaperQCount); //论文答疑数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.PaperQCount); //论文答疑数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.SubVCount))
 {
 if (objzx_CompositionEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.SubVCount, conzx_Composition.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.SubVCount); //论文子观点数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TagsCount))
 {
 if (objzx_CompositionEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TagsCount, conzx_Composition.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TagsCount); //论文标注数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.TeaQCount))
 {
 if (objzx_CompositionEN.TeaQCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_CompositionEN.TeaQCount, conzx_Composition.TeaQCount); //教师提问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.TeaQCount); //教师提问数
 }
 }
 
 if (objzx_CompositionEN.IsUpdated(conzx_Composition.GroupTextId))
 {
 if (objzx_CompositionEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_CompositionEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_Composition.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Composition.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxPaperId = '{0}'", objzx_CompositionEN.zxPaperId); 
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
 /// <param name = "strzxPaperId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxPaperId) 
{
CheckPrimaryKey(strzxPaperId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxPaperId,
};
 objSQL.ExecSP("zx_Composition_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxPaperId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxPaperId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxPaperId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
//删除zx_Composition本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Composition where zxPaperId = " + "'"+ strzxPaperId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_Composition(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
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
//删除zx_Composition本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Composition where zxPaperId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxPaperId) 
{
CheckPrimaryKey(strzxPaperId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
//删除zx_Composition本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Composition where zxPaperId = " + "'"+ strzxPaperId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_Composition(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_CompositionDA: Delzx_Composition)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Composition where " + strCondition ;
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
public bool Delzx_CompositionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_CompositionDA: Delzx_CompositionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Composition where " + strCondition ;
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
 /// <param name = "objzx_CompositionENS">源对象</param>
 /// <param name = "objzx_CompositionENT">目标对象</param>
public void CopyTo(clszx_CompositionEN objzx_CompositionENS, clszx_CompositionEN objzx_CompositionENT)
{
objzx_CompositionENT.zxPaperId = objzx_CompositionENS.zxPaperId; //论文Id
objzx_CompositionENT.PaperTitle = objzx_CompositionENS.PaperTitle; //论文标题
objzx_CompositionENT.PaperName = objzx_CompositionENS.PaperName; //主题名称
objzx_CompositionENT.PaperContent = objzx_CompositionENS.PaperContent; //主题内容
objzx_CompositionENT.Periodical = objzx_CompositionENS.Periodical; //期刊
objzx_CompositionENT.Author = objzx_CompositionENS.Author; //作者
objzx_CompositionENT.ResearchQuestion = objzx_CompositionENS.ResearchQuestion; //研究问题
objzx_CompositionENT.UpdDate = objzx_CompositionENS.UpdDate; //修改日期
objzx_CompositionENT.Memo = objzx_CompositionENS.Memo; //备注
objzx_CompositionENT.Keyword = objzx_CompositionENS.Keyword; //关键字
objzx_CompositionENT.LiteratureSources = objzx_CompositionENS.LiteratureSources; //文献来源
objzx_CompositionENT.LiteratureLink = objzx_CompositionENS.LiteratureLink; //文献链接
objzx_CompositionENT.UploadfileUrl = objzx_CompositionENS.UploadfileUrl; //文件地址
objzx_CompositionENT.IsQuotethesis = objzx_CompositionENS.IsQuotethesis; //是否引用论文
objzx_CompositionENT.QuoteId = objzx_CompositionENS.QuoteId; //引用Id
objzx_CompositionENT.IsChecked = objzx_CompositionENS.IsChecked; //是否检查
objzx_CompositionENT.Checker = objzx_CompositionENS.Checker; //审核人
objzx_CompositionENT.zxLiteratureTypeId = objzx_CompositionENS.zxLiteratureTypeId; //作文类型Id
objzx_CompositionENT.BrowseNumber = objzx_CompositionENS.BrowseNumber; //浏览量
objzx_CompositionENT.IsSubmit = objzx_CompositionENS.IsSubmit; //是否提交
objzx_CompositionENT.AppraiseCount = objzx_CompositionENS.AppraiseCount; //评论数
objzx_CompositionENT.AttachmentCount = objzx_CompositionENS.AttachmentCount; //附件计数
objzx_CompositionENT.CollectionCount = objzx_CompositionENS.CollectionCount; //收藏数量
objzx_CompositionENT.DownloadCount = objzx_CompositionENS.DownloadCount; //下载数
objzx_CompositionENT.OkCount = objzx_CompositionENS.OkCount; //点赞统计
objzx_CompositionENT.Pcount = objzx_CompositionENS.Pcount; //读写数
objzx_CompositionENT.Score = objzx_CompositionENS.Score; //评分
objzx_CompositionENT.StuScore = objzx_CompositionENS.StuScore; //学生平均分
objzx_CompositionENT.TeaScore = objzx_CompositionENS.TeaScore; //教师评分
objzx_CompositionENT.IdCurrEduCls = objzx_CompositionENS.IdCurrEduCls; //教学班流水号
objzx_CompositionENT.PaperTypeId = objzx_CompositionENS.PaperTypeId; //论文类型Id
objzx_CompositionENT.zxPaperStatusId = objzx_CompositionENS.zxPaperStatusId; //论文状态Id
objzx_CompositionENT.VersionCount = objzx_CompositionENS.VersionCount; //版本统计
objzx_CompositionENT.IsPublic = objzx_CompositionENS.IsPublic; //是否公开
objzx_CompositionENT.AskQuestion = objzx_CompositionENS.AskQuestion; //问题提出
objzx_CompositionENT.ResearchStatus = objzx_CompositionENS.ResearchStatus; //目前研究的现状
objzx_CompositionENT.InnovationPoints = objzx_CompositionENS.InnovationPoints; //创新点
objzx_CompositionENT.ResearchDesign = objzx_CompositionENS.ResearchDesign; //研究设计
objzx_CompositionENT.DimensionDataProcess = objzx_CompositionENS.DimensionDataProcess; //数据处理的维度
objzx_CompositionENT.ExpectedConclusion = objzx_CompositionENS.ExpectedConclusion; //预期结论
objzx_CompositionENT.CreateDate = objzx_CompositionENS.CreateDate; //建立日期
objzx_CompositionENT.zxShareId = objzx_CompositionENS.zxShareId; //分享Id
objzx_CompositionENT.UpdUser = objzx_CompositionENS.UpdUser; //修改人
objzx_CompositionENT.PaperQCount = objzx_CompositionENS.PaperQCount; //论文答疑数
objzx_CompositionENT.SubVCount = objzx_CompositionENS.SubVCount; //论文子观点数
objzx_CompositionENT.TagsCount = objzx_CompositionENS.TagsCount; //论文标注数
objzx_CompositionENT.TeaQCount = objzx_CompositionENS.TeaQCount; //教师提问数
objzx_CompositionENT.GroupTextId = objzx_CompositionENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_CompositionEN objzx_CompositionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_CompositionEN.PaperTitle, conzx_Composition.PaperTitle);
clsCheckSql.CheckFieldNotNull(objzx_CompositionEN.zxLiteratureTypeId, conzx_Composition.zxLiteratureTypeId);
clsCheckSql.CheckFieldNotNull(objzx_CompositionEN.GroupTextId, conzx_Composition.GroupTextId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_CompositionEN.zxPaperId, 8, conzx_Composition.zxPaperId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.PaperTitle, 500, conzx_Composition.PaperTitle);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.PaperName, 500, conzx_Composition.PaperName);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Periodical, 100, conzx_Composition.Periodical);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Author, 200, conzx_Composition.Author);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ResearchQuestion, 2000, conzx_Composition.ResearchQuestion);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.UpdDate, 20, conzx_Composition.UpdDate);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Memo, 1000, conzx_Composition.Memo);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Keyword, 1000, conzx_Composition.Keyword);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.LiteratureSources, 1000, conzx_Composition.LiteratureSources);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.LiteratureLink, 1000, conzx_Composition.LiteratureLink);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.UploadfileUrl, 1000, conzx_Composition.UploadfileUrl);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.QuoteId, 8, conzx_Composition.QuoteId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Checker, 20, conzx_Composition.Checker);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.zxLiteratureTypeId, 2, conzx_Composition.zxLiteratureTypeId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.IdCurrEduCls, 8, conzx_Composition.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.PaperTypeId, 2, conzx_Composition.PaperTypeId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.zxPaperStatusId, 2, conzx_Composition.zxPaperStatusId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.AskQuestion, 5000, conzx_Composition.AskQuestion);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ResearchStatus, 5000, conzx_Composition.ResearchStatus);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.InnovationPoints, 5000, conzx_Composition.InnovationPoints);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ResearchDesign, 5000, conzx_Composition.ResearchDesign);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.DimensionDataProcess, 5000, conzx_Composition.DimensionDataProcess);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ExpectedConclusion, 5000, conzx_Composition.ExpectedConclusion);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.CreateDate, 20, conzx_Composition.CreateDate);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.zxShareId, 2, conzx_Composition.zxShareId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.UpdUser, 20, conzx_Composition.UpdUser);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.GroupTextId, 8, conzx_Composition.GroupTextId);
//检查字段外键固定长度
 objzx_CompositionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_CompositionEN objzx_CompositionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_CompositionEN.PaperTitle, 500, conzx_Composition.PaperTitle);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.PaperName, 500, conzx_Composition.PaperName);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Periodical, 100, conzx_Composition.Periodical);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Author, 200, conzx_Composition.Author);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ResearchQuestion, 2000, conzx_Composition.ResearchQuestion);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.UpdDate, 20, conzx_Composition.UpdDate);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Memo, 1000, conzx_Composition.Memo);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Keyword, 1000, conzx_Composition.Keyword);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.LiteratureSources, 1000, conzx_Composition.LiteratureSources);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.LiteratureLink, 1000, conzx_Composition.LiteratureLink);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.UploadfileUrl, 1000, conzx_Composition.UploadfileUrl);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.QuoteId, 8, conzx_Composition.QuoteId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Checker, 20, conzx_Composition.Checker);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.zxLiteratureTypeId, 2, conzx_Composition.zxLiteratureTypeId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.IdCurrEduCls, 8, conzx_Composition.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.PaperTypeId, 2, conzx_Composition.PaperTypeId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.zxPaperStatusId, 2, conzx_Composition.zxPaperStatusId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.AskQuestion, 5000, conzx_Composition.AskQuestion);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ResearchStatus, 5000, conzx_Composition.ResearchStatus);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.InnovationPoints, 5000, conzx_Composition.InnovationPoints);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ResearchDesign, 5000, conzx_Composition.ResearchDesign);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.DimensionDataProcess, 5000, conzx_Composition.DimensionDataProcess);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ExpectedConclusion, 5000, conzx_Composition.ExpectedConclusion);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.CreateDate, 20, conzx_Composition.CreateDate);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.zxShareId, 2, conzx_Composition.zxShareId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.UpdUser, 20, conzx_Composition.UpdUser);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.GroupTextId, 8, conzx_Composition.GroupTextId);
//检查外键字段长度
 objzx_CompositionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_CompositionEN objzx_CompositionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_CompositionEN.zxPaperId, 8, conzx_Composition.zxPaperId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.PaperTitle, 500, conzx_Composition.PaperTitle);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.PaperName, 500, conzx_Composition.PaperName);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Periodical, 100, conzx_Composition.Periodical);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Author, 200, conzx_Composition.Author);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ResearchQuestion, 2000, conzx_Composition.ResearchQuestion);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.UpdDate, 20, conzx_Composition.UpdDate);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Memo, 1000, conzx_Composition.Memo);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Keyword, 1000, conzx_Composition.Keyword);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.LiteratureSources, 1000, conzx_Composition.LiteratureSources);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.LiteratureLink, 1000, conzx_Composition.LiteratureLink);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.UploadfileUrl, 1000, conzx_Composition.UploadfileUrl);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.QuoteId, 8, conzx_Composition.QuoteId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.Checker, 20, conzx_Composition.Checker);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.zxLiteratureTypeId, 2, conzx_Composition.zxLiteratureTypeId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.IdCurrEduCls, 8, conzx_Composition.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.PaperTypeId, 2, conzx_Composition.PaperTypeId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.zxPaperStatusId, 2, conzx_Composition.zxPaperStatusId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.AskQuestion, 5000, conzx_Composition.AskQuestion);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ResearchStatus, 5000, conzx_Composition.ResearchStatus);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.InnovationPoints, 5000, conzx_Composition.InnovationPoints);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ResearchDesign, 5000, conzx_Composition.ResearchDesign);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.DimensionDataProcess, 5000, conzx_Composition.DimensionDataProcess);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.ExpectedConclusion, 5000, conzx_Composition.ExpectedConclusion);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.CreateDate, 20, conzx_Composition.CreateDate);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.zxShareId, 2, conzx_Composition.zxShareId);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.UpdUser, 20, conzx_Composition.UpdUser);
clsCheckSql.CheckFieldLen(objzx_CompositionEN.GroupTextId, 8, conzx_Composition.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.zxPaperId, conzx_Composition.zxPaperId);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.PaperTitle, conzx_Composition.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.PaperName, conzx_Composition.PaperName);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.Periodical, conzx_Composition.Periodical);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.Author, conzx_Composition.Author);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.ResearchQuestion, conzx_Composition.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.UpdDate, conzx_Composition.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.Memo, conzx_Composition.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.Keyword, conzx_Composition.Keyword);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.LiteratureSources, conzx_Composition.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.LiteratureLink, conzx_Composition.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.UploadfileUrl, conzx_Composition.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.QuoteId, conzx_Composition.QuoteId);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.Checker, conzx_Composition.Checker);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.zxLiteratureTypeId, conzx_Composition.zxLiteratureTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.IdCurrEduCls, conzx_Composition.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.PaperTypeId, conzx_Composition.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.zxPaperStatusId, conzx_Composition.zxPaperStatusId);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.AskQuestion, conzx_Composition.AskQuestion);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.ResearchStatus, conzx_Composition.ResearchStatus);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.InnovationPoints, conzx_Composition.InnovationPoints);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.ResearchDesign, conzx_Composition.ResearchDesign);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.DimensionDataProcess, conzx_Composition.DimensionDataProcess);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.ExpectedConclusion, conzx_Composition.ExpectedConclusion);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.CreateDate, conzx_Composition.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.zxShareId, conzx_Composition.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.UpdUser, conzx_Composition.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_CompositionEN.GroupTextId, conzx_Composition.GroupTextId);
//检查外键字段长度
 objzx_CompositionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetzxPaperId()
{
//获取某学院所有专业信息
string strSQL = "select zxPaperId, PaperName from zx_Composition ";
 clsSpecSQLforSql mySql = clszx_CompositionDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_Composition(作文表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_CompositionEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_CompositionEN objzx_CompositionEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxPaperId = '{0}'", objzx_CompositionEN.zxPaperId);
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
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
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
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
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
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_CompositionEN._CurrTabName);
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
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_CompositionEN._CurrTabName, strCondition);
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
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
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
 objSQL = clszx_CompositionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}