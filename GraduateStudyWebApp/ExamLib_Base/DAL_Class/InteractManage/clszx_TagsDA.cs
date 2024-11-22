
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TagsDA
 表名:zx_Tags(01120807)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:03:03
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// zx_Tags(zx_Tags)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_TagsDA : clsCommBase4DA
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
 return clszx_TagsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_TagsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TagsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_TagsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_TagsEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:zx_Tags中,检查关键字,长度不正确!(clszx_TagsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxTagsId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_Tags中,关键字不能为空 或 null!(clszx_TagsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxTagsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_TagsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_Tags(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_TagsDA: GetDataTable_zx_Tags)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Tags where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Tags where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_TagsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Tags where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Tags where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_TagsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_Tags where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_TagsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Tags.* from zx_Tags Left Join {1} on {2} where {3} and zx_Tags.zxTagsId not in (Select top {5} zx_Tags.zxTagsId from zx_Tags Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Tags where {1} and zxTagsId not in (Select top {2} zxTagsId from zx_Tags where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Tags where {1} and zxTagsId not in (Select top {3} zxTagsId from zx_Tags where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_TagsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Tags.* from zx_Tags Left Join {1} on {2} where {3} and zx_Tags.zxTagsId not in (Select top {5} zx_Tags.zxTagsId from zx_Tags Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Tags where {1} and zxTagsId not in (Select top {2} zxTagsId from zx_Tags where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Tags where {1} and zxTagsId not in (Select top {3} zxTagsId from zx_Tags where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_TagsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_TagsDA:GetObjLst)", objException.Message));
}
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TagsDA: GetObjLst)", objException.Message));
}
objzx_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TagsEN);
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
public List<clszx_TagsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_TagsDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_TagsEN> arrObjLst = new List<clszx_TagsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TagsDA: GetObjLst)", objException.Message));
}
objzx_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TagsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_Tags(ref clszx_TagsEN objzx_TagsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Tags where zxTagsId = " + "'"+ objzx_TagsEN.zxTagsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_TagsEN.zxTagsId = objDT.Rows[0][conzx_Tags.zxTagsId].ToString().Trim(); //标注Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_TagsEN.TagsContent = objDT.Rows[0][conzx_Tags.TagsContent].ToString().Trim(); //标注内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TagsEN.PdfContent = objDT.Rows[0][conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_TagsEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_TagsEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_Tags.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TagsEN.OrderNum = TransNullToInt(objDT.Rows[0][conzx_Tags.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objzx_TagsEN.UpdUser = objDT.Rows[0][conzx_Tags.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TagsEN.UpdDate = objDT.Rows[0][conzx_Tags.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TagsEN.PdfLineNum = TransNullToInt(objDT.Rows[0][conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号(字段类型:int,字段长度:4,是否可空:True)
 objzx_TagsEN.PdfX = objDT.Rows[0][conzx_Tags.PdfX].ToString().Trim(); //PdfX(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.PdfY = objDT.Rows[0][conzx_Tags.PdfY].ToString().Trim(); //PdfY(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.Memo = objDT.Rows[0][conzx_Tags.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TagsEN.IdCurrEduCls = objDT.Rows[0][conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TagsEN.TextId = objDT.Rows[0][conzx_Tags.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TagsEN.zxShareId = objDT.Rows[0][conzx_Tags.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_TagsEN.PdfPageNumIn = objDT.Rows[0][conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_TagsEN.PdfDivLet = objDT.Rows[0][conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.PdfDivTop = objDT.Rows[0][conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.PdfZoom = objDT.Rows[0][conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.zxTagsTypeId = objDT.Rows[0][conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_TagsDA: Getzx_Tags)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxTagsId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_TagsEN GetObjByzxTagsId(string strzxTagsId)
{
CheckPrimaryKey(strzxTagsId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Tags where zxTagsId = " + "'"+ strzxTagsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
 objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号(字段类型:int,字段长度:4,是否可空:True)
 objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_TagsDA: GetObjByzxTagsId)", objException.Message));
}
return objzx_TagsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_TagsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_TagsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN()
{
zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(), //标注Id
TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(), //标注内容
PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfPageNum].ToString().Trim()), //Pdf页码
VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.VoteCount].ToString().Trim()), //点赞计数
OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.OrderNum].ToString().Trim()), //序号
UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(), //修改日期
PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfLineNum].ToString().Trim()), //pdf行号
PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(), //PdfX
PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(), //PdfY
Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(), //教学班流水号
TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(), //课件Id
zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(), //分享Id
PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(), //PdfZoom
zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim() //标注类型ID
};
objzx_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TagsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_TagsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_TagsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_TagsDA: GetObjByDataRowzx_Tags)", objException.Message));
}
objzx_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TagsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_TagsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TagsEN objzx_TagsEN = new clszx_TagsEN();
try
{
objzx_TagsEN.zxTagsId = objRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objzx_TagsEN.TagsContent = objRow[conzx_Tags.TagsContent] == DBNull.Value ? null : objRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objzx_TagsEN.PdfContent = objRow[conzx_Tags.PdfContent] == DBNull.Value ? null : objRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objzx_TagsEN.PdfPageNum = objRow[conzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TagsEN.VoteCount = objRow[conzx_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objzx_TagsEN.OrderNum = objRow[conzx_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.OrderNum].ToString().Trim()); //序号
objzx_TagsEN.UpdUser = objRow[conzx_Tags.UpdUser] == DBNull.Value ? null : objRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objzx_TagsEN.UpdDate = objRow[conzx_Tags.UpdDate] == DBNull.Value ? null : objRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objzx_TagsEN.PdfLineNum = objRow[conzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objzx_TagsEN.PdfX = objRow[conzx_Tags.PdfX] == DBNull.Value ? null : objRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objzx_TagsEN.PdfY = objRow[conzx_Tags.PdfY] == DBNull.Value ? null : objRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objzx_TagsEN.Memo = objRow[conzx_Tags.Memo] == DBNull.Value ? null : objRow[conzx_Tags.Memo].ToString().Trim(); //备注
objzx_TagsEN.IdCurrEduCls = objRow[conzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TagsEN.TextId = objRow[conzx_Tags.TextId] == DBNull.Value ? null : objRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objzx_TagsEN.zxShareId = objRow[conzx_Tags.zxShareId] == DBNull.Value ? null : objRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objzx_TagsEN.PdfPageNumIn = objRow[conzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TagsEN.PdfPageTop = objRow[conzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TagsEN.PdfDivLet = objRow[conzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TagsEN.PdfDivTop = objRow[conzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TagsEN.PdfZoom = objRow[conzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TagsEN.zxTagsTypeId = objRow[conzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_TagsDA: GetObjByDataRow)", objException.Message));
}
objzx_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TagsEN;
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
objSQL = clszx_TagsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TagsEN._CurrTabName, conzx_Tags.zxTagsId, 10, "");
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
objSQL = clszx_TagsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TagsEN._CurrTabName, conzx_Tags.zxTagsId, 10, strPrefix);
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
 objSQL = clszx_TagsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxTagsId from zx_Tags where " + strCondition;
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
 objSQL = clszx_TagsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxTagsId from zx_Tags where " + strCondition;
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
 objSQL = clszx_TagsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Tags", "zxTagsId = " + "'"+ strzxTagsId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_TagsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Tags", strCondition))
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
objSQL = clszx_TagsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_Tags");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_TagsEN objzx_TagsEN)
 {
 if (objzx_TagsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TagsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Tags where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Tags");
objRow = objDS.Tables["zx_Tags"].NewRow();
objRow[conzx_Tags.zxTagsId] = objzx_TagsEN.zxTagsId; //标注Id
 if (objzx_TagsEN.TagsContent !=  "")
 {
objRow[conzx_Tags.TagsContent] = objzx_TagsEN.TagsContent; //标注内容
 }
 if (objzx_TagsEN.PdfContent !=  "")
 {
objRow[conzx_Tags.PdfContent] = objzx_TagsEN.PdfContent; //Pdf内容
 }
objRow[conzx_Tags.PdfPageNum] = objzx_TagsEN.PdfPageNum; //Pdf页码
objRow[conzx_Tags.VoteCount] = objzx_TagsEN.VoteCount; //点赞计数
objRow[conzx_Tags.OrderNum] = objzx_TagsEN.OrderNum; //序号
 if (objzx_TagsEN.UpdUser !=  "")
 {
objRow[conzx_Tags.UpdUser] = objzx_TagsEN.UpdUser; //修改人
 }
 if (objzx_TagsEN.UpdDate !=  "")
 {
objRow[conzx_Tags.UpdDate] = objzx_TagsEN.UpdDate; //修改日期
 }
objRow[conzx_Tags.PdfLineNum] = objzx_TagsEN.PdfLineNum; //pdf行号
 if (objzx_TagsEN.PdfX !=  "")
 {
objRow[conzx_Tags.PdfX] = objzx_TagsEN.PdfX; //PdfX
 }
 if (objzx_TagsEN.PdfY !=  "")
 {
objRow[conzx_Tags.PdfY] = objzx_TagsEN.PdfY; //PdfY
 }
 if (objzx_TagsEN.Memo !=  "")
 {
objRow[conzx_Tags.Memo] = objzx_TagsEN.Memo; //备注
 }
 if (objzx_TagsEN.IdCurrEduCls !=  "")
 {
objRow[conzx_Tags.IdCurrEduCls] = objzx_TagsEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_TagsEN.TextId !=  "")
 {
objRow[conzx_Tags.TextId] = objzx_TagsEN.TextId; //课件Id
 }
 if (objzx_TagsEN.zxShareId !=  "")
 {
objRow[conzx_Tags.zxShareId] = objzx_TagsEN.zxShareId; //分享Id
 }
 if (objzx_TagsEN.PdfPageNumIn !=  "")
 {
objRow[conzx_Tags.PdfPageNumIn] = objzx_TagsEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conzx_Tags.PdfPageTop] = objzx_TagsEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_TagsEN.PdfDivLet !=  "")
 {
objRow[conzx_Tags.PdfDivLet] = objzx_TagsEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_TagsEN.PdfDivTop !=  "")
 {
objRow[conzx_Tags.PdfDivTop] = objzx_TagsEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_TagsEN.PdfZoom !=  "")
 {
objRow[conzx_Tags.PdfZoom] = objzx_TagsEN.PdfZoom; //PdfZoom
 }
 if (objzx_TagsEN.zxTagsTypeId !=  "")
 {
objRow[conzx_Tags.zxTagsTypeId] = objzx_TagsEN.zxTagsTypeId; //标注类型ID
 }
objDS.Tables[clszx_TagsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_TagsEN._CurrTabName);
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
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TagsEN objzx_TagsEN)
{
 if (objzx_TagsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TagsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TagsEN.zxTagsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxTagsId);
 var strzxTagsId = objzx_TagsEN.zxTagsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTagsId + "'");
 }
 
 if (objzx_TagsEN.TagsContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.TagsContent);
 var strTagsContent = objzx_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsContent + "'");
 }
 
 if (objzx_TagsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfContent);
 var strPdfContent = objzx_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TagsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageNum);
 arrValueListForInsert.Add(objzx_TagsEN.PdfPageNum.ToString());
 }
 
 if (objzx_TagsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.VoteCount);
 arrValueListForInsert.Add(objzx_TagsEN.VoteCount.ToString());
 }
 
 if (objzx_TagsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.OrderNum);
 arrValueListForInsert.Add(objzx_TagsEN.OrderNum.ToString());
 }
 
 if (objzx_TagsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.UpdUser);
 var strUpdUser = objzx_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TagsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.UpdDate);
 var strUpdDate = objzx_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TagsEN.PdfLineNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfLineNum);
 arrValueListForInsert.Add(objzx_TagsEN.PdfLineNum.ToString());
 }
 
 if (objzx_TagsEN.PdfX !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfX);
 var strPdfX = objzx_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfX + "'");
 }
 
 if (objzx_TagsEN.PdfY !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfY);
 var strPdfY = objzx_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfY + "'");
 }
 
 if (objzx_TagsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.Memo);
 var strMemo = objzx_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TagsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TagsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.TextId);
 var strTextId = objzx_TagsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TagsEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxShareId);
 var strzxShareId = objzx_TagsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TagsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TagsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageTop);
 arrValueListForInsert.Add(objzx_TagsEN.PdfPageTop.ToString());
 }
 
 if (objzx_TagsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfDivLet);
 var strPdfDivLet = objzx_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TagsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfDivTop);
 var strPdfDivTop = objzx_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TagsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfZoom);
 var strPdfZoom = objzx_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TagsEN.zxTagsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxTagsTypeId);
 var strzxTagsTypeId = objzx_TagsEN.zxTagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTagsTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Tags");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TagsEN objzx_TagsEN)
{
 if (objzx_TagsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TagsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TagsEN.zxTagsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxTagsId);
 var strzxTagsId = objzx_TagsEN.zxTagsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTagsId + "'");
 }
 
 if (objzx_TagsEN.TagsContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.TagsContent);
 var strTagsContent = objzx_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsContent + "'");
 }
 
 if (objzx_TagsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfContent);
 var strPdfContent = objzx_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TagsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageNum);
 arrValueListForInsert.Add(objzx_TagsEN.PdfPageNum.ToString());
 }
 
 if (objzx_TagsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.VoteCount);
 arrValueListForInsert.Add(objzx_TagsEN.VoteCount.ToString());
 }
 
 if (objzx_TagsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.OrderNum);
 arrValueListForInsert.Add(objzx_TagsEN.OrderNum.ToString());
 }
 
 if (objzx_TagsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.UpdUser);
 var strUpdUser = objzx_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TagsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.UpdDate);
 var strUpdDate = objzx_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TagsEN.PdfLineNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfLineNum);
 arrValueListForInsert.Add(objzx_TagsEN.PdfLineNum.ToString());
 }
 
 if (objzx_TagsEN.PdfX !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfX);
 var strPdfX = objzx_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfX + "'");
 }
 
 if (objzx_TagsEN.PdfY !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfY);
 var strPdfY = objzx_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfY + "'");
 }
 
 if (objzx_TagsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.Memo);
 var strMemo = objzx_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TagsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TagsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.TextId);
 var strTextId = objzx_TagsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TagsEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxShareId);
 var strzxShareId = objzx_TagsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TagsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TagsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageTop);
 arrValueListForInsert.Add(objzx_TagsEN.PdfPageTop.ToString());
 }
 
 if (objzx_TagsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfDivLet);
 var strPdfDivLet = objzx_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TagsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfDivTop);
 var strPdfDivTop = objzx_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TagsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfZoom);
 var strPdfZoom = objzx_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TagsEN.zxTagsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxTagsTypeId);
 var strzxTagsTypeId = objzx_TagsEN.zxTagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTagsTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Tags");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_TagsEN.zxTagsId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TagsEN objzx_TagsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TagsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TagsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TagsEN.zxTagsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxTagsId);
 var strzxTagsId = objzx_TagsEN.zxTagsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTagsId + "'");
 }
 
 if (objzx_TagsEN.TagsContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.TagsContent);
 var strTagsContent = objzx_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsContent + "'");
 }
 
 if (objzx_TagsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfContent);
 var strPdfContent = objzx_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TagsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageNum);
 arrValueListForInsert.Add(objzx_TagsEN.PdfPageNum.ToString());
 }
 
 if (objzx_TagsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.VoteCount);
 arrValueListForInsert.Add(objzx_TagsEN.VoteCount.ToString());
 }
 
 if (objzx_TagsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.OrderNum);
 arrValueListForInsert.Add(objzx_TagsEN.OrderNum.ToString());
 }
 
 if (objzx_TagsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.UpdUser);
 var strUpdUser = objzx_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TagsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.UpdDate);
 var strUpdDate = objzx_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TagsEN.PdfLineNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfLineNum);
 arrValueListForInsert.Add(objzx_TagsEN.PdfLineNum.ToString());
 }
 
 if (objzx_TagsEN.PdfX !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfX);
 var strPdfX = objzx_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfX + "'");
 }
 
 if (objzx_TagsEN.PdfY !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfY);
 var strPdfY = objzx_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfY + "'");
 }
 
 if (objzx_TagsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.Memo);
 var strMemo = objzx_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TagsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TagsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.TextId);
 var strTextId = objzx_TagsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TagsEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxShareId);
 var strzxShareId = objzx_TagsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TagsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TagsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageTop);
 arrValueListForInsert.Add(objzx_TagsEN.PdfPageTop.ToString());
 }
 
 if (objzx_TagsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfDivLet);
 var strPdfDivLet = objzx_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TagsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfDivTop);
 var strPdfDivTop = objzx_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TagsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfZoom);
 var strPdfZoom = objzx_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TagsEN.zxTagsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxTagsTypeId);
 var strzxTagsTypeId = objzx_TagsEN.zxTagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTagsTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Tags");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_TagsEN.zxTagsId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TagsEN objzx_TagsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TagsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TagsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TagsEN.zxTagsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxTagsId);
 var strzxTagsId = objzx_TagsEN.zxTagsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTagsId + "'");
 }
 
 if (objzx_TagsEN.TagsContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.TagsContent);
 var strTagsContent = objzx_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsContent + "'");
 }
 
 if (objzx_TagsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfContent);
 var strPdfContent = objzx_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_TagsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageNum);
 arrValueListForInsert.Add(objzx_TagsEN.PdfPageNum.ToString());
 }
 
 if (objzx_TagsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.VoteCount);
 arrValueListForInsert.Add(objzx_TagsEN.VoteCount.ToString());
 }
 
 if (objzx_TagsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.OrderNum);
 arrValueListForInsert.Add(objzx_TagsEN.OrderNum.ToString());
 }
 
 if (objzx_TagsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.UpdUser);
 var strUpdUser = objzx_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TagsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.UpdDate);
 var strUpdDate = objzx_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TagsEN.PdfLineNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfLineNum);
 arrValueListForInsert.Add(objzx_TagsEN.PdfLineNum.ToString());
 }
 
 if (objzx_TagsEN.PdfX !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfX);
 var strPdfX = objzx_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfX + "'");
 }
 
 if (objzx_TagsEN.PdfY !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfY);
 var strPdfY = objzx_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfY + "'");
 }
 
 if (objzx_TagsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.Memo);
 var strMemo = objzx_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TagsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TagsEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.TextId);
 var strTextId = objzx_TagsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_TagsEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxShareId);
 var strzxShareId = objzx_TagsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_TagsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageNumIn);
 var strPdfPageNumIn = objzx_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_TagsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfPageTop);
 arrValueListForInsert.Add(objzx_TagsEN.PdfPageTop.ToString());
 }
 
 if (objzx_TagsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfDivLet);
 var strPdfDivLet = objzx_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_TagsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfDivTop);
 var strPdfDivTop = objzx_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_TagsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.PdfZoom);
 var strPdfZoom = objzx_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_TagsEN.zxTagsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Tags.zxTagsTypeId);
 var strzxTagsTypeId = objzx_TagsEN.zxTagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTagsTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Tags");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_Tagss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Tags where zxTagsId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Tags");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxTagsId = oRow[conzx_Tags.zxTagsId].ToString().Trim();
if (IsExist(strzxTagsId))
{
 string strResult = "关键字变量值为:" + string.Format("zxTagsId = {0}", strzxTagsId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_TagsEN._CurrTabName ].NewRow();
objRow[conzx_Tags.zxTagsId] = oRow[conzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objRow[conzx_Tags.TagsContent] = oRow[conzx_Tags.TagsContent].ToString().Trim(); //标注内容
objRow[conzx_Tags.PdfContent] = oRow[conzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_Tags.PdfPageNum] = oRow[conzx_Tags.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_Tags.VoteCount] = oRow[conzx_Tags.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_Tags.OrderNum] = oRow[conzx_Tags.OrderNum].ToString().Trim(); //序号
objRow[conzx_Tags.UpdUser] = oRow[conzx_Tags.UpdUser].ToString().Trim(); //修改人
objRow[conzx_Tags.UpdDate] = oRow[conzx_Tags.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_Tags.PdfLineNum] = oRow[conzx_Tags.PdfLineNum].ToString().Trim(); //pdf行号
objRow[conzx_Tags.PdfX] = oRow[conzx_Tags.PdfX].ToString().Trim(); //PdfX
objRow[conzx_Tags.PdfY] = oRow[conzx_Tags.PdfY].ToString().Trim(); //PdfY
objRow[conzx_Tags.Memo] = oRow[conzx_Tags.Memo].ToString().Trim(); //备注
objRow[conzx_Tags.IdCurrEduCls] = oRow[conzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_Tags.TextId] = oRow[conzx_Tags.TextId].ToString().Trim(); //课件Id
objRow[conzx_Tags.zxShareId] = oRow[conzx_Tags.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_Tags.PdfPageNumIn] = oRow[conzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_Tags.PdfPageTop] = oRow[conzx_Tags.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_Tags.PdfDivLet] = oRow[conzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_Tags.PdfDivTop] = oRow[conzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_Tags.PdfZoom] = oRow[conzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_Tags.zxTagsTypeId] = oRow[conzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
 objDS.Tables[clszx_TagsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_TagsEN._CurrTabName);
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
 /// <param name = "objzx_TagsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_TagsEN objzx_TagsEN)
{
 if (objzx_TagsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TagsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
strSQL = "Select * from zx_Tags where zxTagsId = " + "'"+ objzx_TagsEN.zxTagsId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_TagsEN._CurrTabName);
if (objDS.Tables[clszx_TagsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxTagsId = " + "'"+ objzx_TagsEN.zxTagsId+"'");
return false;
}
objRow = objDS.Tables[clszx_TagsEN._CurrTabName].Rows[0];
 if (objzx_TagsEN.IsUpdated(conzx_Tags.zxTagsId))
 {
objRow[conzx_Tags.zxTagsId] = objzx_TagsEN.zxTagsId; //标注Id
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.TagsContent))
 {
objRow[conzx_Tags.TagsContent] = objzx_TagsEN.TagsContent; //标注内容
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfContent))
 {
objRow[conzx_Tags.PdfContent] = objzx_TagsEN.PdfContent; //Pdf内容
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageNum))
 {
objRow[conzx_Tags.PdfPageNum] = objzx_TagsEN.PdfPageNum; //Pdf页码
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.VoteCount))
 {
objRow[conzx_Tags.VoteCount] = objzx_TagsEN.VoteCount; //点赞计数
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.OrderNum))
 {
objRow[conzx_Tags.OrderNum] = objzx_TagsEN.OrderNum; //序号
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.UpdUser))
 {
objRow[conzx_Tags.UpdUser] = objzx_TagsEN.UpdUser; //修改人
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.UpdDate))
 {
objRow[conzx_Tags.UpdDate] = objzx_TagsEN.UpdDate; //修改日期
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfLineNum))
 {
objRow[conzx_Tags.PdfLineNum] = objzx_TagsEN.PdfLineNum; //pdf行号
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfX))
 {
objRow[conzx_Tags.PdfX] = objzx_TagsEN.PdfX; //PdfX
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfY))
 {
objRow[conzx_Tags.PdfY] = objzx_TagsEN.PdfY; //PdfY
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.Memo))
 {
objRow[conzx_Tags.Memo] = objzx_TagsEN.Memo; //备注
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.IdCurrEduCls))
 {
objRow[conzx_Tags.IdCurrEduCls] = objzx_TagsEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.TextId))
 {
objRow[conzx_Tags.TextId] = objzx_TagsEN.TextId; //课件Id
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.zxShareId))
 {
objRow[conzx_Tags.zxShareId] = objzx_TagsEN.zxShareId; //分享Id
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageNumIn))
 {
objRow[conzx_Tags.PdfPageNumIn] = objzx_TagsEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageTop))
 {
objRow[conzx_Tags.PdfPageTop] = objzx_TagsEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfDivLet))
 {
objRow[conzx_Tags.PdfDivLet] = objzx_TagsEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfDivTop))
 {
objRow[conzx_Tags.PdfDivTop] = objzx_TagsEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfZoom))
 {
objRow[conzx_Tags.PdfZoom] = objzx_TagsEN.PdfZoom; //PdfZoom
 }
 if (objzx_TagsEN.IsUpdated(conzx_Tags.zxTagsTypeId))
 {
objRow[conzx_Tags.zxTagsTypeId] = objzx_TagsEN.zxTagsTypeId; //标注类型ID
 }
try
{
objDA.Update(objDS, clszx_TagsEN._CurrTabName);
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
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TagsEN objzx_TagsEN)
{
 if (objzx_TagsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TagsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_Tags Set ");
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.TagsContent))
 {
 if (objzx_TagsEN.TagsContent !=  null)
 {
 var strTagsContent = objzx_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTagsContent, conzx_Tags.TagsContent); //标注内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.TagsContent); //标注内容
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfContent))
 {
 if (objzx_TagsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_Tags.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageNum))
 {
 if (objzx_TagsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfPageNum, conzx_Tags.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.VoteCount))
 {
 if (objzx_TagsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.VoteCount, conzx_Tags.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.OrderNum))
 {
 if (objzx_TagsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.OrderNum, conzx_Tags.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.OrderNum); //序号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.UpdUser))
 {
 if (objzx_TagsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Tags.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.UpdUser); //修改人
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.UpdDate))
 {
 if (objzx_TagsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Tags.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.UpdDate); //修改日期
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfLineNum))
 {
 if (objzx_TagsEN.PdfLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfLineNum, conzx_Tags.PdfLineNum); //pdf行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfLineNum); //pdf行号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfX))
 {
 if (objzx_TagsEN.PdfX !=  null)
 {
 var strPdfX = objzx_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfX, conzx_Tags.PdfX); //PdfX
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfX); //PdfX
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfY))
 {
 if (objzx_TagsEN.PdfY !=  null)
 {
 var strPdfY = objzx_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfY, conzx_Tags.PdfY); //PdfY
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfY); //PdfY
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.Memo))
 {
 if (objzx_TagsEN.Memo !=  null)
 {
 var strMemo = objzx_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Tags.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.Memo); //备注
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.IdCurrEduCls))
 {
 if (objzx_TagsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Tags.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.TextId))
 {
 if (objzx_TagsEN.TextId !=  null)
 {
 var strTextId = objzx_TagsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Tags.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.TextId); //课件Id
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.zxShareId))
 {
 if (objzx_TagsEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TagsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Tags.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.zxShareId); //分享Id
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageNumIn))
 {
 if (objzx_TagsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_Tags.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageTop))
 {
 if (objzx_TagsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfPageTop, conzx_Tags.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfDivLet))
 {
 if (objzx_TagsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_Tags.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfDivTop))
 {
 if (objzx_TagsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_Tags.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfZoom))
 {
 if (objzx_TagsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_Tags.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.zxTagsTypeId))
 {
 if (objzx_TagsEN.zxTagsTypeId !=  null)
 {
 var strzxTagsTypeId = objzx_TagsEN.zxTagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxTagsTypeId, conzx_Tags.zxTagsTypeId); //标注类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.zxTagsTypeId); //标注类型ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxTagsId = '{0}'", objzx_TagsEN.zxTagsId); 
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
 /// <param name = "objzx_TagsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_TagsEN objzx_TagsEN, string strCondition)
{
 if (objzx_TagsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TagsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Tags Set ");
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.TagsContent))
 {
 if (objzx_TagsEN.TagsContent !=  null)
 {
 var strTagsContent = objzx_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TagsContent = '{0}',", strTagsContent); //标注内容
 }
 else
 {
 sbSQL.Append(" TagsContent = null,"); //标注内容
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfContent))
 {
 if (objzx_TagsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageNum))
 {
 if (objzx_TagsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfPageNum, conzx_Tags.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.VoteCount))
 {
 if (objzx_TagsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.VoteCount, conzx_Tags.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.OrderNum))
 {
 if (objzx_TagsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.OrderNum, conzx_Tags.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.OrderNum); //序号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.UpdUser))
 {
 if (objzx_TagsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.UpdDate))
 {
 if (objzx_TagsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfLineNum))
 {
 if (objzx_TagsEN.PdfLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfLineNum, conzx_Tags.PdfLineNum); //pdf行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfLineNum); //pdf行号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfX))
 {
 if (objzx_TagsEN.PdfX !=  null)
 {
 var strPdfX = objzx_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfX = '{0}',", strPdfX); //PdfX
 }
 else
 {
 sbSQL.Append(" PdfX = null,"); //PdfX
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfY))
 {
 if (objzx_TagsEN.PdfY !=  null)
 {
 var strPdfY = objzx_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfY = '{0}',", strPdfY); //PdfY
 }
 else
 {
 sbSQL.Append(" PdfY = null,"); //PdfY
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.Memo))
 {
 if (objzx_TagsEN.Memo !=  null)
 {
 var strMemo = objzx_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.IdCurrEduCls))
 {
 if (objzx_TagsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.TextId))
 {
 if (objzx_TagsEN.TextId !=  null)
 {
 var strTextId = objzx_TagsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.zxShareId))
 {
 if (objzx_TagsEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TagsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageNumIn))
 {
 if (objzx_TagsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageTop))
 {
 if (objzx_TagsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfPageTop, conzx_Tags.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfDivLet))
 {
 if (objzx_TagsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfDivTop))
 {
 if (objzx_TagsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfZoom))
 {
 if (objzx_TagsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.zxTagsTypeId))
 {
 if (objzx_TagsEN.zxTagsTypeId !=  null)
 {
 var strzxTagsTypeId = objzx_TagsEN.zxTagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxTagsTypeId = '{0}',", strzxTagsTypeId); //标注类型ID
 }
 else
 {
 sbSQL.Append(" zxTagsTypeId = null,"); //标注类型ID
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
 /// <param name = "objzx_TagsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_TagsEN objzx_TagsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TagsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TagsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Tags Set ");
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.TagsContent))
 {
 if (objzx_TagsEN.TagsContent !=  null)
 {
 var strTagsContent = objzx_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TagsContent = '{0}',", strTagsContent); //标注内容
 }
 else
 {
 sbSQL.Append(" TagsContent = null,"); //标注内容
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfContent))
 {
 if (objzx_TagsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageNum))
 {
 if (objzx_TagsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfPageNum, conzx_Tags.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.VoteCount))
 {
 if (objzx_TagsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.VoteCount, conzx_Tags.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.OrderNum))
 {
 if (objzx_TagsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.OrderNum, conzx_Tags.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.OrderNum); //序号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.UpdUser))
 {
 if (objzx_TagsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.UpdDate))
 {
 if (objzx_TagsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfLineNum))
 {
 if (objzx_TagsEN.PdfLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfLineNum, conzx_Tags.PdfLineNum); //pdf行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfLineNum); //pdf行号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfX))
 {
 if (objzx_TagsEN.PdfX !=  null)
 {
 var strPdfX = objzx_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfX = '{0}',", strPdfX); //PdfX
 }
 else
 {
 sbSQL.Append(" PdfX = null,"); //PdfX
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfY))
 {
 if (objzx_TagsEN.PdfY !=  null)
 {
 var strPdfY = objzx_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfY = '{0}',", strPdfY); //PdfY
 }
 else
 {
 sbSQL.Append(" PdfY = null,"); //PdfY
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.Memo))
 {
 if (objzx_TagsEN.Memo !=  null)
 {
 var strMemo = objzx_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.IdCurrEduCls))
 {
 if (objzx_TagsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.TextId))
 {
 if (objzx_TagsEN.TextId !=  null)
 {
 var strTextId = objzx_TagsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.zxShareId))
 {
 if (objzx_TagsEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TagsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageNumIn))
 {
 if (objzx_TagsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageTop))
 {
 if (objzx_TagsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfPageTop, conzx_Tags.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfDivLet))
 {
 if (objzx_TagsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfDivTop))
 {
 if (objzx_TagsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfZoom))
 {
 if (objzx_TagsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.zxTagsTypeId))
 {
 if (objzx_TagsEN.zxTagsTypeId !=  null)
 {
 var strzxTagsTypeId = objzx_TagsEN.zxTagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxTagsTypeId = '{0}',", strzxTagsTypeId); //标注类型ID
 }
 else
 {
 sbSQL.Append(" zxTagsTypeId = null,"); //标注类型ID
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
 /// <param name = "objzx_TagsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TagsEN objzx_TagsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TagsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TagsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Tags Set ");
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.TagsContent))
 {
 if (objzx_TagsEN.TagsContent !=  null)
 {
 var strTagsContent = objzx_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTagsContent, conzx_Tags.TagsContent); //标注内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.TagsContent); //标注内容
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfContent))
 {
 if (objzx_TagsEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_Tags.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageNum))
 {
 if (objzx_TagsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfPageNum, conzx_Tags.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.VoteCount))
 {
 if (objzx_TagsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.VoteCount, conzx_Tags.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.VoteCount); //点赞计数
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.OrderNum))
 {
 if (objzx_TagsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.OrderNum, conzx_Tags.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.OrderNum); //序号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.UpdUser))
 {
 if (objzx_TagsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Tags.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.UpdUser); //修改人
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.UpdDate))
 {
 if (objzx_TagsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Tags.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.UpdDate); //修改日期
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfLineNum))
 {
 if (objzx_TagsEN.PdfLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfLineNum, conzx_Tags.PdfLineNum); //pdf行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfLineNum); //pdf行号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfX))
 {
 if (objzx_TagsEN.PdfX !=  null)
 {
 var strPdfX = objzx_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfX, conzx_Tags.PdfX); //PdfX
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfX); //PdfX
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfY))
 {
 if (objzx_TagsEN.PdfY !=  null)
 {
 var strPdfY = objzx_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfY, conzx_Tags.PdfY); //PdfY
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfY); //PdfY
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.Memo))
 {
 if (objzx_TagsEN.Memo !=  null)
 {
 var strMemo = objzx_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Tags.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.Memo); //备注
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.IdCurrEduCls))
 {
 if (objzx_TagsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Tags.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.TextId))
 {
 if (objzx_TagsEN.TextId !=  null)
 {
 var strTextId = objzx_TagsEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Tags.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.TextId); //课件Id
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.zxShareId))
 {
 if (objzx_TagsEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_TagsEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Tags.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.zxShareId); //分享Id
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageNumIn))
 {
 if (objzx_TagsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_Tags.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfPageTop))
 {
 if (objzx_TagsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TagsEN.PdfPageTop, conzx_Tags.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfDivLet))
 {
 if (objzx_TagsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_Tags.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfDivTop))
 {
 if (objzx_TagsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_Tags.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.PdfZoom))
 {
 if (objzx_TagsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_Tags.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_TagsEN.IsUpdated(conzx_Tags.zxTagsTypeId))
 {
 if (objzx_TagsEN.zxTagsTypeId !=  null)
 {
 var strzxTagsTypeId = objzx_TagsEN.zxTagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxTagsTypeId, conzx_Tags.zxTagsTypeId); //标注类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Tags.zxTagsTypeId); //标注类型ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxTagsId = '{0}'", objzx_TagsEN.zxTagsId); 
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
 /// <param name = "strzxTagsId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxTagsId) 
{
CheckPrimaryKey(strzxTagsId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxTagsId,
};
 objSQL.ExecSP("zx_Tags_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxTagsId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxTagsId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxTagsId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
//删除zx_Tags本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Tags where zxTagsId = " + "'"+ strzxTagsId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_Tags(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
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
//删除zx_Tags本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Tags where zxTagsId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxTagsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxTagsId) 
{
CheckPrimaryKey(strzxTagsId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
//删除zx_Tags本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Tags where zxTagsId = " + "'"+ strzxTagsId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_Tags(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_TagsDA: Delzx_Tags)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Tags where " + strCondition ;
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
public bool Delzx_TagsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_TagsDA: Delzx_TagsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TagsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Tags where " + strCondition ;
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
 /// <param name = "objzx_TagsENS">源对象</param>
 /// <param name = "objzx_TagsENT">目标对象</param>
public void CopyTo(clszx_TagsEN objzx_TagsENS, clszx_TagsEN objzx_TagsENT)
{
objzx_TagsENT.zxTagsId = objzx_TagsENS.zxTagsId; //标注Id
objzx_TagsENT.TagsContent = objzx_TagsENS.TagsContent; //标注内容
objzx_TagsENT.PdfContent = objzx_TagsENS.PdfContent; //Pdf内容
objzx_TagsENT.PdfPageNum = objzx_TagsENS.PdfPageNum; //Pdf页码
objzx_TagsENT.VoteCount = objzx_TagsENS.VoteCount; //点赞计数
objzx_TagsENT.OrderNum = objzx_TagsENS.OrderNum; //序号
objzx_TagsENT.UpdUser = objzx_TagsENS.UpdUser; //修改人
objzx_TagsENT.UpdDate = objzx_TagsENS.UpdDate; //修改日期
objzx_TagsENT.PdfLineNum = objzx_TagsENS.PdfLineNum; //pdf行号
objzx_TagsENT.PdfX = objzx_TagsENS.PdfX; //PdfX
objzx_TagsENT.PdfY = objzx_TagsENS.PdfY; //PdfY
objzx_TagsENT.Memo = objzx_TagsENS.Memo; //备注
objzx_TagsENT.IdCurrEduCls = objzx_TagsENS.IdCurrEduCls; //教学班流水号
objzx_TagsENT.TextId = objzx_TagsENS.TextId; //课件Id
objzx_TagsENT.zxShareId = objzx_TagsENS.zxShareId; //分享Id
objzx_TagsENT.PdfPageNumIn = objzx_TagsENS.PdfPageNumIn; //PdfPageNumIn
objzx_TagsENT.PdfPageTop = objzx_TagsENS.PdfPageTop; //pdf页面顶部位置
objzx_TagsENT.PdfDivLet = objzx_TagsENS.PdfDivLet; //PdfDivLet
objzx_TagsENT.PdfDivTop = objzx_TagsENS.PdfDivTop; //PdfDivTop
objzx_TagsENT.PdfZoom = objzx_TagsENS.PdfZoom; //PdfZoom
objzx_TagsENT.zxTagsTypeId = objzx_TagsENS.zxTagsTypeId; //标注类型ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_TagsEN objzx_TagsEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TagsEN.zxTagsId, 10, conzx_Tags.zxTagsId);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfContent, 2000, conzx_Tags.PdfContent);
clsCheckSql.CheckFieldLen(objzx_TagsEN.UpdUser, 20, conzx_Tags.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TagsEN.UpdDate, 20, conzx_Tags.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfX, 50, conzx_Tags.PdfX);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfY, 50, conzx_Tags.PdfY);
clsCheckSql.CheckFieldLen(objzx_TagsEN.Memo, 1000, conzx_Tags.Memo);
clsCheckSql.CheckFieldLen(objzx_TagsEN.IdCurrEduCls, 8, conzx_Tags.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TagsEN.TextId, 8, conzx_Tags.TextId);
clsCheckSql.CheckFieldLen(objzx_TagsEN.zxShareId, 2, conzx_Tags.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfPageNumIn, 50, conzx_Tags.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfDivLet, 50, conzx_Tags.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfDivTop, 50, conzx_Tags.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfZoom, 50, conzx_Tags.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_TagsEN.zxTagsTypeId, 2, conzx_Tags.zxTagsTypeId);
//检查字段外键固定长度
 objzx_TagsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_TagsEN objzx_TagsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfContent, 2000, conzx_Tags.PdfContent);
clsCheckSql.CheckFieldLen(objzx_TagsEN.UpdUser, 20, conzx_Tags.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TagsEN.UpdDate, 20, conzx_Tags.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfX, 50, conzx_Tags.PdfX);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfY, 50, conzx_Tags.PdfY);
clsCheckSql.CheckFieldLen(objzx_TagsEN.Memo, 1000, conzx_Tags.Memo);
clsCheckSql.CheckFieldLen(objzx_TagsEN.IdCurrEduCls, 8, conzx_Tags.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TagsEN.TextId, 8, conzx_Tags.TextId);
clsCheckSql.CheckFieldLen(objzx_TagsEN.zxShareId, 2, conzx_Tags.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfPageNumIn, 50, conzx_Tags.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfDivLet, 50, conzx_Tags.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfDivTop, 50, conzx_Tags.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfZoom, 50, conzx_Tags.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_TagsEN.zxTagsTypeId, 2, conzx_Tags.zxTagsTypeId);
//检查外键字段长度
 objzx_TagsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_TagsEN objzx_TagsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TagsEN.zxTagsId, 10, conzx_Tags.zxTagsId);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfContent, 2000, conzx_Tags.PdfContent);
clsCheckSql.CheckFieldLen(objzx_TagsEN.UpdUser, 20, conzx_Tags.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TagsEN.UpdDate, 20, conzx_Tags.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfX, 50, conzx_Tags.PdfX);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfY, 50, conzx_Tags.PdfY);
clsCheckSql.CheckFieldLen(objzx_TagsEN.Memo, 1000, conzx_Tags.Memo);
clsCheckSql.CheckFieldLen(objzx_TagsEN.IdCurrEduCls, 8, conzx_Tags.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TagsEN.TextId, 8, conzx_Tags.TextId);
clsCheckSql.CheckFieldLen(objzx_TagsEN.zxShareId, 2, conzx_Tags.zxShareId);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfPageNumIn, 50, conzx_Tags.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfDivLet, 50, conzx_Tags.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfDivTop, 50, conzx_Tags.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_TagsEN.PdfZoom, 50, conzx_Tags.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_TagsEN.zxTagsTypeId, 2, conzx_Tags.zxTagsTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.zxTagsId, conzx_Tags.zxTagsId);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.PdfContent, conzx_Tags.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.UpdUser, conzx_Tags.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.UpdDate, conzx_Tags.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.PdfX, conzx_Tags.PdfX);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.PdfY, conzx_Tags.PdfY);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.Memo, conzx_Tags.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.IdCurrEduCls, conzx_Tags.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.TextId, conzx_Tags.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.zxShareId, conzx_Tags.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.PdfPageNumIn, conzx_Tags.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.PdfDivLet, conzx_Tags.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.PdfDivTop, conzx_Tags.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.PdfZoom, conzx_Tags.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_TagsEN.zxTagsTypeId, conzx_Tags.zxTagsTypeId);
//检查外键字段长度
 objzx_TagsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_Tags(zx_Tags),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TagsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_TagsEN objzx_TagsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxTagsId = '{0}'", objzx_TagsEN.zxTagsId);
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
 objSQL = clszx_TagsDA.GetSpecSQLObj();
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
 objSQL = clszx_TagsDA.GetSpecSQLObj();
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
 objSQL = clszx_TagsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TagsEN._CurrTabName);
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
 objSQL = clszx_TagsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TagsEN._CurrTabName, strCondition);
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
 objSQL = clszx_TagsDA.GetSpecSQLObj();
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
 objSQL = clszx_TagsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}