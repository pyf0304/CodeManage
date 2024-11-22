
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ParagraphTypeDA
 表名:zx_ParagraphType(01120821)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:58:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 中学段落类型(zx_ParagraphType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_ParagraphTypeDA : clsCommBase4DA
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
 return clszx_ParagraphTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_ParagraphTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ParagraphTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_ParagraphTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_ParagraphTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxParagraphTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxParagraphTypeId)
{
strzxParagraphTypeId = strzxParagraphTypeId.Replace("'", "''");
if (strzxParagraphTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:zx_ParagraphType中,检查关键字,长度不正确!(clszx_ParagraphTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxParagraphTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_ParagraphType中,关键字不能为空 或 null!(clszx_ParagraphTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxParagraphTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_ParagraphTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
strSQL = "Select * from zx_ParagraphType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_ParagraphType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: GetDataTable_zx_ParagraphType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
strSQL = "Select * from zx_ParagraphType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
strSQL = "Select * from zx_ParagraphType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ParagraphType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ParagraphType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_ParagraphType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ParagraphType.* from zx_ParagraphType Left Join {1} on {2} where {3} and zx_ParagraphType.zxParagraphTypeId not in (Select top {5} zx_ParagraphType.zxParagraphTypeId from zx_ParagraphType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ParagraphType where {1} and zxParagraphTypeId not in (Select top {2} zxParagraphTypeId from zx_ParagraphType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ParagraphType where {1} and zxParagraphTypeId not in (Select top {3} zxParagraphTypeId from zx_ParagraphType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ParagraphType.* from zx_ParagraphType Left Join {1} on {2} where {3} and zx_ParagraphType.zxParagraphTypeId not in (Select top {5} zx_ParagraphType.zxParagraphTypeId from zx_ParagraphType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ParagraphType where {1} and zxParagraphTypeId not in (Select top {2} zxParagraphTypeId from zx_ParagraphType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ParagraphType where {1} and zxParagraphTypeId not in (Select top {3} zxParagraphTypeId from zx_ParagraphType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_ParagraphTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA:GetObjLst)", objException.Message));
}
List<clszx_ParagraphTypeEN> arrObjLst = new List<clszx_ParagraphTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
strSQL = "Select * from zx_ParagraphType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ParagraphTypeEN objzx_ParagraphTypeEN = new clszx_ParagraphTypeEN();
try
{
objzx_ParagraphTypeEN.zxParagraphTypeId = objRow[conzx_ParagraphType.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_ParagraphTypeEN.ParagraphTypeName = objRow[conzx_ParagraphType.ParagraphTypeName] == DBNull.Value ? null : objRow[conzx_ParagraphType.ParagraphTypeName].ToString().Trim(); //段落类型
objzx_ParagraphTypeEN.Memo = objRow[conzx_ParagraphType.Memo] == DBNull.Value ? null : objRow[conzx_ParagraphType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ParagraphTypeDA: GetObjLst)", objException.Message));
}
objzx_ParagraphTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ParagraphTypeEN);
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
public List<clszx_ParagraphTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_ParagraphTypeEN> arrObjLst = new List<clszx_ParagraphTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ParagraphTypeEN objzx_ParagraphTypeEN = new clszx_ParagraphTypeEN();
try
{
objzx_ParagraphTypeEN.zxParagraphTypeId = objRow[conzx_ParagraphType.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_ParagraphTypeEN.ParagraphTypeName = objRow[conzx_ParagraphType.ParagraphTypeName] == DBNull.Value ? null : objRow[conzx_ParagraphType.ParagraphTypeName].ToString().Trim(); //段落类型
objzx_ParagraphTypeEN.Memo = objRow[conzx_ParagraphType.Memo] == DBNull.Value ? null : objRow[conzx_ParagraphType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ParagraphTypeDA: GetObjLst)", objException.Message));
}
objzx_ParagraphTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ParagraphTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_ParagraphTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_ParagraphType(ref clszx_ParagraphTypeEN objzx_ParagraphTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
strSQL = "Select * from zx_ParagraphType where zxParagraphTypeId = " + "'"+ objzx_ParagraphTypeEN.zxParagraphTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_ParagraphTypeEN.zxParagraphTypeId = objDT.Rows[0][conzx_ParagraphType.zxParagraphTypeId].ToString().Trim(); //段落类型Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ParagraphTypeEN.ParagraphTypeName = objDT.Rows[0][conzx_ParagraphType.ParagraphTypeName].ToString().Trim(); //段落类型(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_ParagraphTypeEN.Memo = objDT.Rows[0][conzx_ParagraphType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_ParagraphTypeDA: Getzx_ParagraphType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxParagraphTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_ParagraphTypeEN GetObjByzxParagraphTypeId(string strzxParagraphTypeId)
{
CheckPrimaryKey(strzxParagraphTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
strSQL = "Select * from zx_ParagraphType where zxParagraphTypeId = " + "'"+ strzxParagraphTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_ParagraphTypeEN objzx_ParagraphTypeEN = new clszx_ParagraphTypeEN();
try
{
 objzx_ParagraphTypeEN.zxParagraphTypeId = objRow[conzx_ParagraphType.zxParagraphTypeId].ToString().Trim(); //段落类型Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ParagraphTypeEN.ParagraphTypeName = objRow[conzx_ParagraphType.ParagraphTypeName] == DBNull.Value ? null : objRow[conzx_ParagraphType.ParagraphTypeName].ToString().Trim(); //段落类型(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_ParagraphTypeEN.Memo = objRow[conzx_ParagraphType.Memo] == DBNull.Value ? null : objRow[conzx_ParagraphType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_ParagraphTypeDA: GetObjByzxParagraphTypeId)", objException.Message));
}
return objzx_ParagraphTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_ParagraphTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
strSQL = "Select * from zx_ParagraphType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_ParagraphTypeEN objzx_ParagraphTypeEN = new clszx_ParagraphTypeEN()
{
zxParagraphTypeId = objRow[conzx_ParagraphType.zxParagraphTypeId].ToString().Trim(), //段落类型Id
ParagraphTypeName = objRow[conzx_ParagraphType.ParagraphTypeName] == DBNull.Value ? null : objRow[conzx_ParagraphType.ParagraphTypeName].ToString().Trim(), //段落类型
Memo = objRow[conzx_ParagraphType.Memo] == DBNull.Value ? null : objRow[conzx_ParagraphType.Memo].ToString().Trim() //备注
};
objzx_ParagraphTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ParagraphTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_ParagraphTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_ParagraphTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ParagraphTypeEN objzx_ParagraphTypeEN = new clszx_ParagraphTypeEN();
try
{
objzx_ParagraphTypeEN.zxParagraphTypeId = objRow[conzx_ParagraphType.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_ParagraphTypeEN.ParagraphTypeName = objRow[conzx_ParagraphType.ParagraphTypeName] == DBNull.Value ? null : objRow[conzx_ParagraphType.ParagraphTypeName].ToString().Trim(); //段落类型
objzx_ParagraphTypeEN.Memo = objRow[conzx_ParagraphType.Memo] == DBNull.Value ? null : objRow[conzx_ParagraphType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_ParagraphTypeDA: GetObjByDataRowzx_ParagraphType)", objException.Message));
}
objzx_ParagraphTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ParagraphTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_ParagraphTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ParagraphTypeEN objzx_ParagraphTypeEN = new clszx_ParagraphTypeEN();
try
{
objzx_ParagraphTypeEN.zxParagraphTypeId = objRow[conzx_ParagraphType.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_ParagraphTypeEN.ParagraphTypeName = objRow[conzx_ParagraphType.ParagraphTypeName] == DBNull.Value ? null : objRow[conzx_ParagraphType.ParagraphTypeName].ToString().Trim(); //段落类型
objzx_ParagraphTypeEN.Memo = objRow[conzx_ParagraphType.Memo] == DBNull.Value ? null : objRow[conzx_ParagraphType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_ParagraphTypeDA: GetObjByDataRow)", objException.Message));
}
objzx_ParagraphTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ParagraphTypeEN;
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
objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ParagraphTypeEN._CurrTabName, conzx_ParagraphType.zxParagraphTypeId, 2, "");
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
objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ParagraphTypeEN._CurrTabName, conzx_ParagraphType.zxParagraphTypeId, 2, strPrefix);
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
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxParagraphTypeId from zx_ParagraphType where " + strCondition;
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
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxParagraphTypeId from zx_ParagraphType where " + strCondition;
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
 /// <param name = "strzxParagraphTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxParagraphTypeId)
{
CheckPrimaryKey(strzxParagraphTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ParagraphType", "zxParagraphTypeId = " + "'"+ strzxParagraphTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ParagraphType", strCondition))
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
objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_ParagraphType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_ParagraphTypeEN objzx_ParagraphTypeEN)
 {
 if (objzx_ParagraphTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ParagraphTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
strSQL = "Select * from zx_ParagraphType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ParagraphType");
objRow = objDS.Tables["zx_ParagraphType"].NewRow();
objRow[conzx_ParagraphType.zxParagraphTypeId] = objzx_ParagraphTypeEN.zxParagraphTypeId; //段落类型Id
 if (objzx_ParagraphTypeEN.ParagraphTypeName !=  "")
 {
objRow[conzx_ParagraphType.ParagraphTypeName] = objzx_ParagraphTypeEN.ParagraphTypeName; //段落类型
 }
 if (objzx_ParagraphTypeEN.Memo !=  "")
 {
objRow[conzx_ParagraphType.Memo] = objzx_ParagraphTypeEN.Memo; //备注
 }
objDS.Tables[clszx_ParagraphTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_ParagraphTypeEN._CurrTabName);
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
 /// <param name = "objzx_ParagraphTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ParagraphTypeEN objzx_ParagraphTypeEN)
{
 if (objzx_ParagraphTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ParagraphTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ParagraphTypeEN.zxParagraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.zxParagraphTypeId);
 var strzxParagraphTypeId = objzx_ParagraphTypeEN.zxParagraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxParagraphTypeId + "'");
 }
 
 if (objzx_ParagraphTypeEN.ParagraphTypeName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.ParagraphTypeName);
 var strParagraphTypeName = objzx_ParagraphTypeEN.ParagraphTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParagraphTypeName + "'");
 }
 
 if (objzx_ParagraphTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.Memo);
 var strMemo = objzx_ParagraphTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ParagraphType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_ParagraphTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ParagraphTypeEN objzx_ParagraphTypeEN)
{
 if (objzx_ParagraphTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ParagraphTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ParagraphTypeEN.zxParagraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.zxParagraphTypeId);
 var strzxParagraphTypeId = objzx_ParagraphTypeEN.zxParagraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxParagraphTypeId + "'");
 }
 
 if (objzx_ParagraphTypeEN.ParagraphTypeName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.ParagraphTypeName);
 var strParagraphTypeName = objzx_ParagraphTypeEN.ParagraphTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParagraphTypeName + "'");
 }
 
 if (objzx_ParagraphTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.Memo);
 var strMemo = objzx_ParagraphTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ParagraphType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_ParagraphTypeEN.zxParagraphTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_ParagraphTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ParagraphTypeEN objzx_ParagraphTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ParagraphTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ParagraphTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ParagraphTypeEN.zxParagraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.zxParagraphTypeId);
 var strzxParagraphTypeId = objzx_ParagraphTypeEN.zxParagraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxParagraphTypeId + "'");
 }
 
 if (objzx_ParagraphTypeEN.ParagraphTypeName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.ParagraphTypeName);
 var strParagraphTypeName = objzx_ParagraphTypeEN.ParagraphTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParagraphTypeName + "'");
 }
 
 if (objzx_ParagraphTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.Memo);
 var strMemo = objzx_ParagraphTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ParagraphType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_ParagraphTypeEN.zxParagraphTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_ParagraphTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ParagraphTypeEN objzx_ParagraphTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ParagraphTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ParagraphTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ParagraphTypeEN.zxParagraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.zxParagraphTypeId);
 var strzxParagraphTypeId = objzx_ParagraphTypeEN.zxParagraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxParagraphTypeId + "'");
 }
 
 if (objzx_ParagraphTypeEN.ParagraphTypeName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.ParagraphTypeName);
 var strParagraphTypeName = objzx_ParagraphTypeEN.ParagraphTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParagraphTypeName + "'");
 }
 
 if (objzx_ParagraphTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ParagraphType.Memo);
 var strMemo = objzx_ParagraphTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ParagraphType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_ParagraphTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
strSQL = "Select * from zx_ParagraphType where zxParagraphTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ParagraphType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxParagraphTypeId = oRow[conzx_ParagraphType.zxParagraphTypeId].ToString().Trim();
if (IsExist(strzxParagraphTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("zxParagraphTypeId = {0}", strzxParagraphTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_ParagraphTypeEN._CurrTabName ].NewRow();
objRow[conzx_ParagraphType.zxParagraphTypeId] = oRow[conzx_ParagraphType.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objRow[conzx_ParagraphType.ParagraphTypeName] = oRow[conzx_ParagraphType.ParagraphTypeName].ToString().Trim(); //段落类型
objRow[conzx_ParagraphType.Memo] = oRow[conzx_ParagraphType.Memo].ToString().Trim(); //备注
 objDS.Tables[clszx_ParagraphTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_ParagraphTypeEN._CurrTabName);
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
 /// <param name = "objzx_ParagraphTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_ParagraphTypeEN objzx_ParagraphTypeEN)
{
 if (objzx_ParagraphTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ParagraphTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
strSQL = "Select * from zx_ParagraphType where zxParagraphTypeId = " + "'"+ objzx_ParagraphTypeEN.zxParagraphTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_ParagraphTypeEN._CurrTabName);
if (objDS.Tables[clszx_ParagraphTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxParagraphTypeId = " + "'"+ objzx_ParagraphTypeEN.zxParagraphTypeId+"'");
return false;
}
objRow = objDS.Tables[clszx_ParagraphTypeEN._CurrTabName].Rows[0];
 if (objzx_ParagraphTypeEN.IsUpdated(conzx_ParagraphType.zxParagraphTypeId))
 {
objRow[conzx_ParagraphType.zxParagraphTypeId] = objzx_ParagraphTypeEN.zxParagraphTypeId; //段落类型Id
 }
 if (objzx_ParagraphTypeEN.IsUpdated(conzx_ParagraphType.ParagraphTypeName))
 {
objRow[conzx_ParagraphType.ParagraphTypeName] = objzx_ParagraphTypeEN.ParagraphTypeName; //段落类型
 }
 if (objzx_ParagraphTypeEN.IsUpdated(conzx_ParagraphType.Memo))
 {
objRow[conzx_ParagraphType.Memo] = objzx_ParagraphTypeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clszx_ParagraphTypeEN._CurrTabName);
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
 /// <param name = "objzx_ParagraphTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ParagraphTypeEN objzx_ParagraphTypeEN)
{
 if (objzx_ParagraphTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ParagraphTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_ParagraphType Set ");
 
 if (objzx_ParagraphTypeEN.IsUpdated(conzx_ParagraphType.ParagraphTypeName))
 {
 if (objzx_ParagraphTypeEN.ParagraphTypeName !=  null)
 {
 var strParagraphTypeName = objzx_ParagraphTypeEN.ParagraphTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParagraphTypeName, conzx_ParagraphType.ParagraphTypeName); //段落类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ParagraphType.ParagraphTypeName); //段落类型
 }
 }
 
 if (objzx_ParagraphTypeEN.IsUpdated(conzx_ParagraphType.Memo))
 {
 if (objzx_ParagraphTypeEN.Memo !=  null)
 {
 var strMemo = objzx_ParagraphTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ParagraphType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ParagraphType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxParagraphTypeId = '{0}'", objzx_ParagraphTypeEN.zxParagraphTypeId); 
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
 /// <param name = "objzx_ParagraphTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_ParagraphTypeEN objzx_ParagraphTypeEN, string strCondition)
{
 if (objzx_ParagraphTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ParagraphTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ParagraphType Set ");
 
 if (objzx_ParagraphTypeEN.IsUpdated(conzx_ParagraphType.ParagraphTypeName))
 {
 if (objzx_ParagraphTypeEN.ParagraphTypeName !=  null)
 {
 var strParagraphTypeName = objzx_ParagraphTypeEN.ParagraphTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParagraphTypeName = '{0}',", strParagraphTypeName); //段落类型
 }
 else
 {
 sbSQL.Append(" ParagraphTypeName = null,"); //段落类型
 }
 }
 
 if (objzx_ParagraphTypeEN.IsUpdated(conzx_ParagraphType.Memo))
 {
 if (objzx_ParagraphTypeEN.Memo !=  null)
 {
 var strMemo = objzx_ParagraphTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_ParagraphTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_ParagraphTypeEN objzx_ParagraphTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ParagraphTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ParagraphTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ParagraphType Set ");
 
 if (objzx_ParagraphTypeEN.IsUpdated(conzx_ParagraphType.ParagraphTypeName))
 {
 if (objzx_ParagraphTypeEN.ParagraphTypeName !=  null)
 {
 var strParagraphTypeName = objzx_ParagraphTypeEN.ParagraphTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParagraphTypeName = '{0}',", strParagraphTypeName); //段落类型
 }
 else
 {
 sbSQL.Append(" ParagraphTypeName = null,"); //段落类型
 }
 }
 
 if (objzx_ParagraphTypeEN.IsUpdated(conzx_ParagraphType.Memo))
 {
 if (objzx_ParagraphTypeEN.Memo !=  null)
 {
 var strMemo = objzx_ParagraphTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_ParagraphTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ParagraphTypeEN objzx_ParagraphTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ParagraphTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ParagraphTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ParagraphType Set ");
 
 if (objzx_ParagraphTypeEN.IsUpdated(conzx_ParagraphType.ParagraphTypeName))
 {
 if (objzx_ParagraphTypeEN.ParagraphTypeName !=  null)
 {
 var strParagraphTypeName = objzx_ParagraphTypeEN.ParagraphTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParagraphTypeName, conzx_ParagraphType.ParagraphTypeName); //段落类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ParagraphType.ParagraphTypeName); //段落类型
 }
 }
 
 if (objzx_ParagraphTypeEN.IsUpdated(conzx_ParagraphType.Memo))
 {
 if (objzx_ParagraphTypeEN.Memo !=  null)
 {
 var strMemo = objzx_ParagraphTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ParagraphType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ParagraphType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxParagraphTypeId = '{0}'", objzx_ParagraphTypeEN.zxParagraphTypeId); 
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
 /// <param name = "strzxParagraphTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxParagraphTypeId) 
{
CheckPrimaryKey(strzxParagraphTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxParagraphTypeId,
};
 objSQL.ExecSP("zx_ParagraphType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxParagraphTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxParagraphTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxParagraphTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
//删除zx_ParagraphType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ParagraphType where zxParagraphTypeId = " + "'"+ strzxParagraphTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_ParagraphType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
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
//删除zx_ParagraphType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ParagraphType where zxParagraphTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxParagraphTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxParagraphTypeId) 
{
CheckPrimaryKey(strzxParagraphTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
//删除zx_ParagraphType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ParagraphType where zxParagraphTypeId = " + "'"+ strzxParagraphTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_ParagraphType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: Delzx_ParagraphType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ParagraphType where " + strCondition ;
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
public bool Delzx_ParagraphTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_ParagraphTypeDA: Delzx_ParagraphTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ParagraphType where " + strCondition ;
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
 /// <param name = "objzx_ParagraphTypeENS">源对象</param>
 /// <param name = "objzx_ParagraphTypeENT">目标对象</param>
public void CopyTo(clszx_ParagraphTypeEN objzx_ParagraphTypeENS, clszx_ParagraphTypeEN objzx_ParagraphTypeENT)
{
objzx_ParagraphTypeENT.zxParagraphTypeId = objzx_ParagraphTypeENS.zxParagraphTypeId; //段落类型Id
objzx_ParagraphTypeENT.ParagraphTypeName = objzx_ParagraphTypeENS.ParagraphTypeName; //段落类型
objzx_ParagraphTypeENT.Memo = objzx_ParagraphTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_ParagraphTypeEN objzx_ParagraphTypeEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ParagraphTypeEN.zxParagraphTypeId, 2, conzx_ParagraphType.zxParagraphTypeId);
clsCheckSql.CheckFieldLen(objzx_ParagraphTypeEN.ParagraphTypeName, 100, conzx_ParagraphType.ParagraphTypeName);
clsCheckSql.CheckFieldLen(objzx_ParagraphTypeEN.Memo, 1000, conzx_ParagraphType.Memo);
//检查字段外键固定长度
 objzx_ParagraphTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_ParagraphTypeEN objzx_ParagraphTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ParagraphTypeEN.ParagraphTypeName, 100, conzx_ParagraphType.ParagraphTypeName);
clsCheckSql.CheckFieldLen(objzx_ParagraphTypeEN.Memo, 1000, conzx_ParagraphType.Memo);
//检查外键字段长度
 objzx_ParagraphTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_ParagraphTypeEN objzx_ParagraphTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ParagraphTypeEN.zxParagraphTypeId, 2, conzx_ParagraphType.zxParagraphTypeId);
clsCheckSql.CheckFieldLen(objzx_ParagraphTypeEN.ParagraphTypeName, 100, conzx_ParagraphType.ParagraphTypeName);
clsCheckSql.CheckFieldLen(objzx_ParagraphTypeEN.Memo, 1000, conzx_ParagraphType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_ParagraphTypeEN.zxParagraphTypeId, conzx_ParagraphType.zxParagraphTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_ParagraphTypeEN.ParagraphTypeName, conzx_ParagraphType.ParagraphTypeName);
clsCheckSql.CheckSqlInjection4Field(objzx_ParagraphTypeEN.Memo, conzx_ParagraphType.Memo);
//检查外键字段长度
 objzx_ParagraphTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetzxParagraphTypeId()
{
//获取某学院所有专业信息
string strSQL = "select zxParagraphTypeId, ParagraphTypeName from zx_ParagraphType ";
 clsSpecSQLforSql mySql = clszx_ParagraphTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_ParagraphType(中学段落类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ParagraphTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_ParagraphTypeEN objzx_ParagraphTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxParagraphTypeId = '{0}'", objzx_ParagraphTypeEN.zxParagraphTypeId);
 if (objzx_ParagraphTypeEN.ParagraphTypeName == null)
{
 sbCondition.AppendFormat(" and ParagraphTypeName is null");
}
else
{
 sbCondition.AppendFormat(" and ParagraphTypeName = '{0}'", objzx_ParagraphTypeEN.ParagraphTypeName);
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
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
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
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
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
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ParagraphTypeEN._CurrTabName);
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
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ParagraphTypeEN._CurrTabName, strCondition);
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
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
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
 objSQL = clszx_ParagraphTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}