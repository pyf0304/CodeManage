
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TagsDA
 表名:vzx_Tags(01120854)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// vzx_Tags(vzx_Tags)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_TagsDA : clsCommBase4DA
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
 return clsvzx_TagsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_TagsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TagsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_TagsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_TagsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxTagsId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxTagsId)
{
strzxTagsId = strzxTagsId.Replace("'", "''");
if (strzxTagsId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vzx_Tags中,检查关键字,长度不正确!(clsvzx_TagsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxTagsId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_Tags中,关键字不能为空 或 null!(clsvzx_TagsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxTagsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_TagsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_Tags(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_TagsDA: GetDataTable_vzx_Tags)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Tags where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Tags where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_TagsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Tags where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Tags where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_TagsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_Tags where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_TagsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Tags.* from vzx_Tags Left Join {1} on {2} where {3} and vzx_Tags.zxTagsId not in (Select top {5} vzx_Tags.zxTagsId from vzx_Tags Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Tags where {1} and zxTagsId not in (Select top {2} zxTagsId from vzx_Tags where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Tags where {1} and zxTagsId not in (Select top {3} zxTagsId from vzx_Tags where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_TagsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Tags.* from vzx_Tags Left Join {1} on {2} where {3} and vzx_Tags.zxTagsId not in (Select top {5} vzx_Tags.zxTagsId from vzx_Tags Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Tags where {1} and zxTagsId not in (Select top {2} zxTagsId from vzx_Tags where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Tags where {1} and zxTagsId not in (Select top {3} zxTagsId from vzx_Tags where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_TagsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_TagsDA:GetObjLst)", objException.Message));
}
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TagsDA: GetObjLst)", objException.Message));
}
objvzx_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TagsEN);
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
public List<clsvzx_TagsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_TagsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TagsDA: GetObjLst)", objException.Message));
}
objvzx_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TagsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_Tags(ref clsvzx_TagsEN objvzx_TagsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Tags where zxTagsId = " + "'"+ objvzx_TagsEN.zxTagsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_TagsEN.TextTitle = objDT.Rows[0][convzx_Tags.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_TagsEN.TextContent = objDT.Rows[0][convzx_Tags.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TagsEN.Author = objDT.Rows[0][convzx_Tags.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_TagsEN.Keyword = objDT.Rows[0][convzx_Tags.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TagsEN.zxTagsId = objDT.Rows[0][convzx_Tags.zxTagsId].ToString().Trim(); //标注Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_TagsEN.TagsContent = objDT.Rows[0][convzx_Tags.TagsContent].ToString().Trim(); //标注内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TagsEN.PdfContent = objDT.Rows[0][convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_TagsEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TagsEN.VoteCount = TransNullToInt(objDT.Rows[0][convzx_Tags.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TagsEN.OrderNum = TransNullToInt(objDT.Rows[0][convzx_Tags.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TagsEN.UpdUser = objDT.Rows[0][convzx_Tags.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TagsEN.UpdDate = objDT.Rows[0][convzx_Tags.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TagsEN.PdfLineNum = TransNullToInt(objDT.Rows[0][convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TagsEN.PdfX = objDT.Rows[0][convzx_Tags.PdfX].ToString().Trim(); //PdfX(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.PdfY = objDT.Rows[0][convzx_Tags.PdfY].ToString().Trim(); //PdfY(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.Memo = objDT.Rows[0][convzx_Tags.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TagsEN.IdCurrEduCls = objDT.Rows[0][convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TagsEN.TextId = objDT.Rows[0][convzx_Tags.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TagsEN.zxShareId = objDT.Rows[0][convzx_Tags.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_TagsEN.PdfPageNumIn = objDT.Rows[0][convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.PdfPageTop = TransNullToInt(objDT.Rows[0][convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TagsEN.PdfDivLet = objDT.Rows[0][convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.PdfDivTop = objDT.Rows[0][convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.PdfZoom = objDT.Rows[0][convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.zxTagsTypeId = objDT.Rows[0][convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_TagsDA: Getvzx_Tags)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxTagsId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_TagsEN GetObjByzxTagsId(string strzxTagsId)
{
CheckPrimaryKey(strzxTagsId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Tags where zxTagsId = " + "'"+ strzxTagsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
 objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_TagsDA: GetObjByzxTagsId)", objException.Message));
}
return objvzx_TagsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_TagsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_TagsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN()
{
TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(), //TextTitle
TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(), //TextContent
Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(), //作者
Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(), //关键字
zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(), //标注Id
TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(), //标注内容
PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfPageNum].ToString().Trim()), //Pdf页码
VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.VoteCount].ToString().Trim()), //点赞计数
OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.OrderNum].ToString().Trim()), //序号
UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(), //修改日期
PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfLineNum].ToString().Trim()), //pdf行号
PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(), //PdfX
PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(), //PdfY
Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(), //教学班流水号
TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(), //课件Id
zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(), //分享Id
PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(), //PdfZoom
zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim() //标注类型ID
};
objvzx_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TagsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_TagsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_TagsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_TagsDA: GetObjByDataRowvzx_Tags)", objException.Message));
}
objvzx_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TagsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_TagsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_TagsDA: GetObjByDataRow)", objException.Message));
}
objvzx_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TagsEN;
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
objSQL = clsvzx_TagsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TagsEN._CurrTabName, convzx_Tags.zxTagsId, 10, "");
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
objSQL = clsvzx_TagsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TagsEN._CurrTabName, convzx_Tags.zxTagsId, 10, strPrefix);
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
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxTagsId from vzx_Tags where " + strCondition;
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
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxTagsId from vzx_Tags where " + strCondition;
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
 /// <param name = "strzxTagsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxTagsId)
{
CheckPrimaryKey(strzxTagsId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Tags", "zxTagsId = " + "'"+ strzxTagsId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_TagsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Tags", strCondition))
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
objSQL = clsvzx_TagsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_Tags");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_TagsENS">源对象</param>
 /// <param name = "objvzx_TagsENT">目标对象</param>
public void CopyTo(clsvzx_TagsEN objvzx_TagsENS, clsvzx_TagsEN objvzx_TagsENT)
{
objvzx_TagsENT.TextTitle = objvzx_TagsENS.TextTitle; //TextTitle
objvzx_TagsENT.TextContent = objvzx_TagsENS.TextContent; //TextContent
objvzx_TagsENT.Author = objvzx_TagsENS.Author; //作者
objvzx_TagsENT.Keyword = objvzx_TagsENS.Keyword; //关键字
objvzx_TagsENT.zxTagsId = objvzx_TagsENS.zxTagsId; //标注Id
objvzx_TagsENT.TagsContent = objvzx_TagsENS.TagsContent; //标注内容
objvzx_TagsENT.PdfContent = objvzx_TagsENS.PdfContent; //Pdf内容
objvzx_TagsENT.PdfPageNum = objvzx_TagsENS.PdfPageNum; //Pdf页码
objvzx_TagsENT.VoteCount = objvzx_TagsENS.VoteCount; //点赞计数
objvzx_TagsENT.OrderNum = objvzx_TagsENS.OrderNum; //序号
objvzx_TagsENT.UpdUser = objvzx_TagsENS.UpdUser; //修改人
objvzx_TagsENT.UpdDate = objvzx_TagsENS.UpdDate; //修改日期
objvzx_TagsENT.PdfLineNum = objvzx_TagsENS.PdfLineNum; //pdf行号
objvzx_TagsENT.PdfX = objvzx_TagsENS.PdfX; //PdfX
objvzx_TagsENT.PdfY = objvzx_TagsENS.PdfY; //PdfY
objvzx_TagsENT.Memo = objvzx_TagsENS.Memo; //备注
objvzx_TagsENT.IdCurrEduCls = objvzx_TagsENS.IdCurrEduCls; //教学班流水号
objvzx_TagsENT.TextId = objvzx_TagsENS.TextId; //课件Id
objvzx_TagsENT.zxShareId = objvzx_TagsENS.zxShareId; //分享Id
objvzx_TagsENT.PdfPageNumIn = objvzx_TagsENS.PdfPageNumIn; //PdfPageNumIn
objvzx_TagsENT.PdfPageTop = objvzx_TagsENS.PdfPageTop; //pdf页面顶部位置
objvzx_TagsENT.PdfDivLet = objvzx_TagsENS.PdfDivLet; //PdfDivLet
objvzx_TagsENT.PdfDivTop = objvzx_TagsENS.PdfDivTop; //PdfDivTop
objvzx_TagsENT.PdfZoom = objvzx_TagsENS.PdfZoom; //PdfZoom
objvzx_TagsENT.zxTagsTypeId = objvzx_TagsENS.zxTagsTypeId; //标注类型ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_TagsEN objvzx_TagsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_TagsEN.TextTitle, 500, convzx_Tags.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.Author, 200, convzx_Tags.Author);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.Keyword, 1000, convzx_Tags.Keyword);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.zxTagsId, 10, convzx_Tags.zxTagsId);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.PdfContent, 2000, convzx_Tags.PdfContent);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.UpdUser, 20, convzx_Tags.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.UpdDate, 20, convzx_Tags.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.PdfX, 50, convzx_Tags.PdfX);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.PdfY, 50, convzx_Tags.PdfY);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.Memo, 1000, convzx_Tags.Memo);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.IdCurrEduCls, 8, convzx_Tags.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.TextId, 8, convzx_Tags.TextId);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.zxShareId, 2, convzx_Tags.zxShareId);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.PdfPageNumIn, 50, convzx_Tags.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.PdfDivLet, 50, convzx_Tags.PdfDivLet);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.PdfDivTop, 50, convzx_Tags.PdfDivTop);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.PdfZoom, 50, convzx_Tags.PdfZoom);
clsCheckSql.CheckFieldLen(objvzx_TagsEN.zxTagsTypeId, 2, convzx_Tags.zxTagsTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.TextTitle, convzx_Tags.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.Author, convzx_Tags.Author);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.Keyword, convzx_Tags.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.zxTagsId, convzx_Tags.zxTagsId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.PdfContent, convzx_Tags.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.UpdUser, convzx_Tags.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.UpdDate, convzx_Tags.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.PdfX, convzx_Tags.PdfX);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.PdfY, convzx_Tags.PdfY);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.Memo, convzx_Tags.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.IdCurrEduCls, convzx_Tags.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.TextId, convzx_Tags.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.zxShareId, convzx_Tags.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.PdfPageNumIn, convzx_Tags.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.PdfDivLet, convzx_Tags.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.PdfDivTop, convzx_Tags.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.PdfZoom, convzx_Tags.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objvzx_TagsEN.zxTagsTypeId, convzx_Tags.zxTagsTypeId);
//检查外键字段长度
 objvzx_TagsEN._IsCheckProperty = true;
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
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TagsEN._CurrTabName);
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
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TagsEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_TagsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}