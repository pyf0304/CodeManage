using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.common
{
    public class SqlStatementAC
    {
        /// <summary>
        /// 删除单引号中间的内容。
        /// </summary>
        /// <param name="strSqlStatement"></param>
        /// <returns></returns>
        public static string DelSingleQuoteContent(string strSqlStatement)
        {

            StringBuilder sbSqlStatment_New = new StringBuilder();
//            string test = "good good study day day up";
            string r = strSqlStatement.Replace("'", "");
            int intSingleQuoteNum = (strSqlStatement.Length - r.Length) ;
          
            if (intSingleQuoteNum % 2 != 0)
            {
                string strMsg = String.Format("在Sql语句中，单撇的个数应该为偶数。（个数：{0})({1})",
                    intSingleQuoteNum, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            int iLen = strSqlStatement.Length;
            int intState = 0;

            for (int i = 0; i < iLen; i++)
            {
                string strWord = strSqlStatement.Substring(i, 1);
                if (strWord == "'")
                {
                    if (intState == 0)
                    {
                        sbSqlStatment_New.Append(strWord);
                        intState = 1;
                    }
                    else if (intState == 1)
                    {
                        if (i < iLen - 1)//不是最近一个字符
                        {
                            string strWork_Next = strSqlStatement.Substring(i + 1, 1);
                            if (strWork_Next == "'")//说明是单撇之间的“''”
                            {
                                intState = 2;
                            }
                            else
                            {
                                intState = 0;
                                sbSqlStatment_New.Append(strWord);
                            }
                        }
                        else //最后一个撇'
                        {
                            sbSqlStatment_New.Append(strWord);
                        }
                    }
                    else if (intState == 2)//
                    {
                        intState = 1;
                    }
                }
                else
                {
                    if (intState == 0)
                    {
                        sbSqlStatment_New.Append(strWord);
                    }
                }

            }
            return sbSqlStatment_New.ToString();
        }
        /// <summary>
        /// 分析Sql语句
        /// </summary>
        /// <param name="strSqlStatement"></param>
        /// <returns></returns>
        public static SqlStatement AnalysisSqlStatement(string strSqlStatement)
        {
            if (string.IsNullOrEmpty(strSqlStatement) == true) return null;
            SqlStatement objSqlStatement = new SqlStatement();
            objSqlStatement.SqlStatementText = strSqlStatement;
            string strOperateType = GetSqlOperateType(strSqlStatement);
            if (string.IsNullOrEmpty(strOperateType) == true)
            {
                string strMsg = string.Format("Sql语句类型不正确，请检查！Sql语句:{0}", strSqlStatement);
                throw new Exception(strMsg);
            }
            strSqlStatement = strSqlStatement.Replace("\n\r", " ");
            strSqlStatement = strSqlStatement.Replace("\n", " ");
            strSqlStatement = strSqlStatement.Replace("\r", " ");
            strSqlStatement = strSqlStatement.Replace("\t", " ");
            strSqlStatement = DelSingleQuoteContent( strSqlStatement);

            strSqlStatement = strSqlStatement.Replace("  ", " ");
            strSqlStatement = strSqlStatement.Replace("  ", " ");
            strSqlStatement = strSqlStatement.Trim();
            objSqlStatement.OperateType = strOperateType;
            string strMainTabName = "";
            List<SqlStatementRelaTab> arrSqlStatementRelaTabObjLst = null;
            List<string> lstFlag = null;
            List<string> lstWord = new List<string>();
            List<string> lstWord2 = new List<string>();
            switch (strOperateType)
            {
                case "select":
                    lstFlag = new List<string>();
                    lstFlag.Add("select ");
                    lstFlag.Add("from ");
                    lstFlag.Add("where ");
                    lstFlag.Add("group by ");
                    lstFlag.Add("having ");
                    lstFlag.Add("order by ");

                    lstWord = clsString.SplitStringBySplitFlagLst(strSqlStatement, lstFlag);
                    lstWord2 = GetUnionLst(lstWord, "");

                    objSqlStatement.SelectText = lstWord2[0];
                
                    for (int i = 1; i < lstWord2.Count; i++)
                    {
                        if (lstWord2[i].IndexOf("Where ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            objSqlStatement.WhereCondition = lstWord2[i];
                        }
                        else if (lstWord2[i].IndexOf("From ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            objSqlStatement.FromText = lstWord2[i];
                        }
                        else if (lstWord2[i].IndexOf("Group by ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            objSqlStatement.GROUPBY = lstWord2[i];
                        }
                        else if (lstWord2[i].IndexOf("Having ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            objSqlStatement.HavingStr = lstWord2[i];
                        }
                        else if (lstWord2[i].IndexOf("Order By ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            objSqlStatement.OrderBy = lstWord2[i];
                        }
                    }
                    if (string.IsNullOrEmpty(objSqlStatement.FromText) == false)
                    {
                        arrSqlStatementRelaTabObjLst = FieldAnalysis_From(objSqlStatement.FromText, objSqlStatement.SqlStatementText, "", "", "");
                        strMainTabName = GetMainTabName(arrSqlStatementRelaTabObjLst);
                        if (string.IsNullOrEmpty(strMainTabName) == true)
                        {
                            string strMsg = string.Format("在Sql语句：{1}中, From部分：{0}不合法，不能获取操作主表，请检查！", objSqlStatement.FromText, strSqlStatement);

                            throw new Exception(strMsg);
                        }
                        objSqlStatement.TabName = strMainTabName;
                    }
                    break;
                case "update":
                    lstFlag = new List<string>();
                    lstFlag.Add("update ");
                    lstFlag.Add("set ");
                    lstFlag.Add("from ");
                    lstFlag.Add("where ");

                    lstWord = clsString.SplitStringBySplitFlagLst(strSqlStatement, lstFlag);
                    lstWord2 = GetUnionLst(lstWord, "");

                    objSqlStatement.UpdateText = lstWord2[0];
                    objSqlStatement.SetText = lstWord2[1];

                    for (int i = 2; i < lstWord2.Count; i++)
                    {
                        if (lstWord2[i].IndexOf("Where ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            objSqlStatement.WhereCondition = lstWord2[i];
                        }
                        else if (lstWord2[i].IndexOf("From ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            objSqlStatement.WhereCondition = lstWord2[i];
                        }

                    }
                    if (string.IsNullOrEmpty(objSqlStatement.FromText) == false)
                    {
                        arrSqlStatementRelaTabObjLst = FieldAnalysis_From(objSqlStatement.FromText, objSqlStatement.SqlStatementText, "", "", "");
                        strMainTabName = GetMainTabName(arrSqlStatementRelaTabObjLst);
                        if (string.IsNullOrEmpty(strMainTabName) == true)
                        {
                            string strMsg = string.Format("在Sql语句：{1}中, From部分：{0}不合法，不能获取操作主表，请检查！", objSqlStatement.FromText, strSqlStatement);

                            throw new Exception(strMsg);
                        }
                    }
                    else
                    {
                        string[] sstrParts = objSqlStatement.UpdateText.Split(' ');
                        strMainTabName = sstrParts[1];
                    }
                    objSqlStatement.TabName = strMainTabName;
                    break;
                case "insert":
                    lstFlag = new List<string>();
                    lstFlag.Add("insert ");
                    lstFlag.Add("into ");
                    lstFlag.Add("values ");

                    lstWord = clsString.SplitStringBySplitFlagLst(strSqlStatement, lstFlag);
                    lstWord2 = GetUnionLst(lstWord, "");

                    objSqlStatement.IntoText = lstWord2[1];
                    objSqlStatement.ValuesText = lstWord2[2];

                    string[] sstrParts2 = objSqlStatement.IntoText.Split(' ');
                    strMainTabName = sstrParts2[1];
                    objSqlStatement.TabName = strMainTabName;
                    break;
                case "delete":
                    lstFlag = new List<string>();
                    lstFlag.Add("delete ");
                    lstFlag.Add("from ");
                    lstFlag.Add("where ");

                    lstWord = clsString.SplitStringBySplitFlagLst(strSqlStatement.Trim(), lstFlag);
                    lstWord2 = GetUnionLst(lstWord, "");

                    objSqlStatement.DeleteText = lstWord2[0];


                    for (int i = 1; i < lstWord2.Count; i++)
                    {
                        if (lstWord2[i].IndexOf("Where ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            objSqlStatement.WhereCondition = lstWord2[i];
                        }
                        else if (lstWord2[i].IndexOf("From ", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            objSqlStatement.FromText = lstWord2[i];
                        }
                    }

                    if (string.IsNullOrEmpty(objSqlStatement.FromText) == false)
                    {
                        arrSqlStatementRelaTabObjLst = FieldAnalysis_From(objSqlStatement.FromText, objSqlStatement.SqlStatementText, "", "", "");
                        strMainTabName = GetMainTabName(arrSqlStatementRelaTabObjLst);
                        if (string.IsNullOrEmpty(strMainTabName) == true)
                        {
                            string strMsg = string.Format("在Sql语句：{1}中, From部分：{0}不合法，不能获取操作主表，请检查！", objSqlStatement.FromText, strSqlStatement);

                            throw new Exception(strMsg);
                        }
                    }
                    else
                    {
                        string[] sstrParts = objSqlStatement.DeleteText.Split(' ');
                        strMainTabName = sstrParts[1];
                    }
                    objSqlStatement.TabName = strMainTabName;
                    break;
            }
            //            strSqlStatement
            return objSqlStatement;
        }
        /// <summary>
        /// 从关系表中获取操作主表
        /// </summary>
        /// <param name="arrSqlStatementRelaTabObjLst">关系表对象列表</param>
        /// <returns>返回主表</returns>
        public static string GetMainTabName(List<SqlStatementRelaTab> arrSqlStatementRelaTabObjLst)
        {
            foreach (SqlStatementRelaTab objSqlStatementRelaTabEN in arrSqlStatementRelaTabObjLst)
            {
                if (objSqlStatementRelaTabEN.SV_RelaTabTypeId == "01")
                {
                    return objSqlStatementRelaTabEN.TabName;
                }
            }
            return "";
        }
        /// <summary>
        /// 合并字符串列表（List《string》），经分隔标志分隔后，分成多个字符串列表，把包含在“（”，“）”中的子字符串合并起来
        ///                                 这些不需要合并
        /// </summary>
        /// <param name="lstWord">源字符串列表</param>
        /// <param name="strJoinChar"></param>
        /// <returns>合并后的字符串列表</returns>
        public static List<string> GetUnionLst(List<string> lstWord, string strJoinChar)
        {
            List<string> lstWord2 = new List<string>();
            for (int i = 0; i < lstWord.Count; i++)
            {
                string strWord = lstWord[i];
                int intState = 0;
                if (strWord.IndexOf("(") >= 0)
                {
                    string strWordAll = "";
                    intState = 0;
                    int intPos_left = strWord.IndexOf("(");
                    int intNext_i = 0;
                    for (int j = i; j < lstWord.Count; j++)
                    {
                        strWord = lstWord[j];
                        int intPos_Char = 0;
                        while (intPos_Char < strWord.Length)
                        {
                            if (strWord.Substring(intPos_Char, 1) == "(")
                            {
                                intState++;
                            }
                            else if (strWord.Substring(intPos_Char, 1) == ")")
                            {
                                intState--;
                            }
                            intPos_Char++;
                        }
                        strWordAll += strWord + strJoinChar;
                        if (intState == 0)
                        {
                            intNext_i = j;
                            break;
                        }

                    }//for(int j=i
                    i = intNext_i;
                    if (string.IsNullOrEmpty(strJoinChar) == false)
                    {
                        strWordAll = strWordAll.Remove(strWordAll.Length - strJoinChar.Length);
                    }
                    lstWord2.Add(strWordAll.Trim());
                }
                else
                {
                    lstWord2.Add(strWord.Trim());
                }
            }

            return lstWord2;
        }
        /// <summary>
        /// 获取Sql语句的操作类型。即是Select、Insert、Update、Delete等
        /// </summary>
        /// <param name="strSqlStatement">Sql语句</param>
        /// <returns>获取的操作类型</returns>
        public static string GetSqlOperateType(string strSqlStatement)
        {
            string strSqlStatement_Lower = strSqlStatement.ToLower().Trim();
            if (strSqlStatement_Lower.Substring(0, 6) == "select")
            {
                return "select";
            }
            else if (strSqlStatement_Lower.Substring(0, 6) == "update")
            {
                return "update";
            }
            else if (strSqlStatement_Lower.Substring(0, 6) == "insert")
            {
                return "insert";
            }
            else if (strSqlStatement_Lower.Substring(0, 6) == "delete")
            {
                return "delete";
            }
            else
            {
                return "";
            }
        }
        public static string GetSqlStatementAnalysisInfo(SqlStatement objSqlStatementEN, int intSuccessRecCount)
        {
            StringBuilder sbAnalysisInfo = new StringBuilder();
            switch (objSqlStatementEN.OperateType)
            {
                case "select":

                    sbAnalysisInfo.AppendFormat("类型:[{0}]. ", objSqlStatementEN.OperateType);
                    sbAnalysisInfo.AppendFormat("\r\n主表:[{0}]. ", objSqlStatementEN.TabName);
                    sbAnalysisInfo.AppendFormat("\r\n成功:[{0}]; ", intSuccessRecCount);
                    //sbAnalysisInfo.AppendFormat("\r\nselect:[{0}]; ", objSqlStatementEN.SelectText);
                    //sbAnalysisInfo.AppendFormat("\r\nfrom:[{0}]; ", objSqlStatementEN.FromText);
                    //if (string.IsNullOrEmpty(objSqlStatementEN.WhereCondition) == false)
                    //{
                    //    sbAnalysisInfo.AppendFormat("\r\nwhere:[{0}]; ", objSqlStatementEN.WhereCondition);
                    //}
                    //if (string.IsNullOrEmpty(objSqlStatementEN.GROUPBY) == false)
                    //{
                    //    sbAnalysisInfo.AppendFormat("\r\ngroup by:[{0}]; ", objSqlStatementEN.GROUPBY);

                    //}
                    //if (string.IsNullOrEmpty(objSqlStatementEN.HavingStr) == false)
                    //{
                    //    sbAnalysisInfo.AppendFormat("\r\nhaving:[{0}]; ", objSqlStatementEN.HavingStr);
                    //}
                    //if (string.IsNullOrEmpty(objSqlStatementEN.orderBy) == false)
                    //{
                    //    sbAnalysisInfo.AppendFormat("\r\norder by:[{0}]; ", objSqlStatementEN.orderBy);
                    //}
                    if (string.IsNullOrEmpty(objSqlStatementEN.SqlStatementText) == false)
                    {
                        sbAnalysisInfo.AppendFormat("\r\nSql:[{0}]; ", objSqlStatementEN.SqlStatementText);
                    }

                    break;
                case "update":
                    sbAnalysisInfo.AppendFormat("类型:[{0}]. ", objSqlStatementEN.OperateType);
                    sbAnalysisInfo.AppendFormat("\r\n主表:[{0}]. ", objSqlStatementEN.TabName);
                    sbAnalysisInfo.AppendFormat("\r\n成功:[{0}]; ", intSuccessRecCount);
                    //sbAnalysisInfo.AppendFormat("\r\nupdate:[{0}]; ", objSqlStatementEN.UpdateText);
                    //sbAnalysisInfo.AppendFormat("\r\nset:[{0}]; ", objSqlStatementEN.SetText);
                    //if (string.IsNullOrEmpty(objSqlStatementEN.FromText) == false)
                    //{
                    //    sbAnalysisInfo.AppendFormat("\r\nfrom:[{0}]; ", objSqlStatementEN.FromText);
                    //}
                    //sbAnalysisInfo.AppendFormat("\r\nwhere:[{0}]; ", objSqlStatementEN.WhereCondition);
                    sbAnalysisInfo.AppendFormat("\r\nSql:[{0}]; ", objSqlStatementEN.SqlStatementText);

                    break;
                case "insert":
                    sbAnalysisInfo.AppendFormat("类型:[{0}]. ", objSqlStatementEN.OperateType);
                    sbAnalysisInfo.AppendFormat("\r\n主表:[{0}]. ", objSqlStatementEN.TabName);
                    sbAnalysisInfo.AppendFormat("\r\n成功:[{0}]; ", intSuccessRecCount);
            
                    //sbAnalysisInfo.AppendFormat("\r\ninto:[{0}]; ", objSqlStatementEN.IntoText);
                    //sbAnalysisInfo.AppendFormat("\r\nvalues:[{0}]; ", objSqlStatementEN.ValuesText);
                    sbAnalysisInfo.AppendFormat("\r\nSql:[{0}]; ", objSqlStatementEN.SqlStatementText);

                    break;
                case "delete":
                    sbAnalysisInfo.AppendFormat("类型:[{0}]. ", objSqlStatementEN.OperateType);
                    sbAnalysisInfo.AppendFormat("\r\n主表:[{0}]. ", objSqlStatementEN.TabName);
                    sbAnalysisInfo.AppendFormat("\r\n成功:[{0}]; ", intSuccessRecCount);
                    //sbAnalysisInfo.AppendFormat("\r\ndelete:[{0}]; ", objSqlStatementEN.DeleteText);
                    //sbAnalysisInfo.AppendFormat("\r\nfrom:[{0}]; ", objSqlStatementEN.FromText);
                    //sbAnalysisInfo.AppendFormat("\r\nwhere:[{0}]; ", objSqlStatementEN.WhereCondition);
                    sbAnalysisInfo.AppendFormat("\r\nSql:[{0}]; ", objSqlStatementEN.SqlStatementText);

                    break;
                default:
                    sbAnalysisInfo.AppendFormat("操作类型不正确！操作类型：[{0}].", objSqlStatementEN.OperateType);
                    break;
            }
            return sbAnalysisInfo.ToString().Replace("\r\n", "");

        }

        /// <summary>
        /// 字段分析From部分
        /// </summary>
        /// <param name="strText_From">From部分的文本</param>
        /// <param name="objSqlViewEN">Sql视图对象</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCurrDate14">当前日期</param>
        /// <param name="strUserId">操作用户Id</param>
        /// <returns>是否成功</returns>
        public static List<SqlStatementRelaTab> FieldAnalysis_From(string strText_From, string strSqlStatement, string strPrjId, string strCurrDate14, string strUserId)
        {
            //FROM         dbo.SqlView LEFT OUTER JOIN
            //              dbo.PrjTab ON dbo.SqlView.RelaTabId = dbo.PrjTab.TabId LEFT OUTER JOIN
            //              dbo.Projects ON dbo.SqlView.PrjId = dbo.Projects.PrjId LEFT OUTER JOIN
            //              dbo.TextResourceType ON dbo.SqlView.TextResourceTypeId = dbo.TextResourceType.TextResourceTypeId
            if (strText_From.IndexOf("FROM", StringComparison.InvariantCultureIgnoreCase) < 0)
            {
                string strMsg = string.Format("在Sql语句：{1}中, From部分：{0}不合法，请检查！", strText_From, strSqlStatement);

                throw new Exception(strMsg);
            }

            List<string> lstFlag = new List<string>();
            lstFlag.Add("LEFT OUTER JOIN");
            lstFlag.Add("RIGHT OUTER JOIN");
            lstFlag.Add("FULL OUTER JOIN");
            lstFlag.Add("INNER JOIN");
            lstFlag.Add("from ");
            strText_From = strText_From.Replace("     ", " ");
            strText_From = strText_From.Replace("    ", " ");
            strText_From = strText_From.Replace("   ", " ");
            strText_From = strText_From.Replace("  ", " ");
            //strText_From = strText_From.Replace(" ", " ");


            List<string> lstWord = clsString.SplitStringBySplitFlagLst(strText_From, lstFlag);
            if (lstWord[0].IndexOf("FROM", StringComparison.InvariantCultureIgnoreCase) < 0)
            {
                string strMsg = string.Format("在Sql语句：{1}中, From部分：{0}不合法，请检查！", strText_From, strSqlStatement);

                throw new Exception(strMsg);
            }
            string strMainTabName = "";
            string strMainTabName_Alias = "";
            List<SqlStatementRelaTab> arrSqlStatementRelaTabObjLst = new List<SqlStatementRelaTab>();
            SqlStatementRelaTab objSqlStatementRelaTabEN_Main = null;
            int intOrderNum = 1;
            if (lstWord.Count == 1)
            {
                string strText_From2 = strText_From.Substring(5);
                //int intPos_Comma = 0;//逗号位置
                string[] sstrTabPart = strText_From2.Split(',');
                foreach (string strTabPart in sstrTabPart)
                {
                    string strTabPart2 = strTabPart.Trim();
                    int intPos_Empty2 = strTabPart2.IndexOf(' ');
                    if (intPos_Empty2 < 0)
                    {
                        string strMainTabNamePart2 = strTabPart2;
                        string[] sstrPart2 = strMainTabNamePart2.Split('.');
                        if (sstrPart2.Length == 2)
                        {
                            strMainTabName = sstrPart2[1].Trim();
                        }
                        else
                        {
                            strMainTabName = sstrPart2[0];
                        }
                        strMainTabName_Alias = "";
                        objSqlStatementRelaTabEN_Main = new SqlStatementRelaTab();
                        //objSqlStatementRelaTabEN_Main.SqlStatementId = objSqlViewEN.SqlViewId;// Sql视图Id

                        objSqlStatementRelaTabEN_Main.TabName = strMainTabName;// 表别名
                        if (string.IsNullOrEmpty(strMainTabName_Alias) == false)
                        {
                            objSqlStatementRelaTabEN_Main.TabAliases = strMainTabName_Alias;// 表别名
                        }
                        else
                        {
                            objSqlStatementRelaTabEN_Main.TabAliases = strMainTabName;// 表别名
                        }
                        if (intOrderNum == 1)
                        {
                            objSqlStatementRelaTabEN_Main.SV_RelaTabTypeId = "01";// Sql视图相关表类型Id
                        }
                        else
                        {
                            objSqlStatementRelaTabEN_Main.SV_RelaTabTypeId = "02";// Sql视图相关表类型Id
                        }
                        objSqlStatementRelaTabEN_Main.TabRelationTypeId = "00";// 表关系类型Id
                        objSqlStatementRelaTabEN_Main.TabRelationText = "";// 表关系文本
                        objSqlStatementRelaTabEN_Main.OrderNum = intOrderNum++;// OrderNum
                        objSqlStatementRelaTabEN_Main.PrjId = strPrjId;// 工程ID
                        objSqlStatementRelaTabEN_Main.UpdDate = strCurrDate14;// 修改日期
                        objSqlStatementRelaTabEN_Main.UpdUserId = strUserId;// 修改用户Id
                        objSqlStatementRelaTabEN_Main.Memo = "通过分析！";// 说明

                        arrSqlStatementRelaTabObjLst.Add(objSqlStatementRelaTabEN_Main);
                    }
                    else
                    {
                        string strMainTabNamePart2 = strTabPart2.Substring(0, intPos_Empty2);
                        string[] sstrPart2 = strMainTabNamePart2.Split('.');
                        if (sstrPart2.Length == 2)
                        {
                            strMainTabName = sstrPart2[1].Trim();
                        }
                        else
                        {
                            strMainTabName = sstrPart2[0];
                        }
                        strMainTabName_Alias = strTabPart2.Substring(intPos_Empty2).Trim();
                        objSqlStatementRelaTabEN_Main = new SqlStatementRelaTab();
                        //objSqlStatementRelaTabEN_Main.SqlStatementId = objSqlViewEN.SqlViewId;// Sql视图Id

                        objSqlStatementRelaTabEN_Main.TabName = strMainTabName;// 表别名
                        if (string.IsNullOrEmpty(strMainTabName_Alias) == false)
                        {
                            objSqlStatementRelaTabEN_Main.TabAliases = strMainTabName_Alias;// 表别名
                        }
                        else
                        {
                            objSqlStatementRelaTabEN_Main.TabAliases = strMainTabName;// 表别名
                        }
                        if (intOrderNum == 1)
                        {
                            objSqlStatementRelaTabEN_Main.SV_RelaTabTypeId = "01";// Sql视图相关表类型Id
                        }
                        else
                        {
                            objSqlStatementRelaTabEN_Main.SV_RelaTabTypeId = "02";// Sql视图相关表类型Id
                        }
                        objSqlStatementRelaTabEN_Main.TabRelationTypeId = "00";// 表关系类型Id
                        objSqlStatementRelaTabEN_Main.TabRelationText = "";// 表关系文本
                        objSqlStatementRelaTabEN_Main.OrderNum = intOrderNum++;// OrderNum
                        objSqlStatementRelaTabEN_Main.PrjId = strPrjId;// 工程ID
                        objSqlStatementRelaTabEN_Main.UpdDate = strCurrDate14;// 修改日期
                        objSqlStatementRelaTabEN_Main.UpdUserId = strUserId;// 修改用户Id
                        objSqlStatementRelaTabEN_Main.Memo = "通过分析！";// 说明

                        arrSqlStatementRelaTabObjLst.Add(objSqlStatementRelaTabEN_Main);
                    }
                }
                return arrSqlStatementRelaTabObjLst;
            }


            //获取主表
            int intPos_AS2 = lstWord[0].IndexOf(" AS ");

            if (intPos_AS2 > 0)
            {
                strMainTabName_Alias = lstWord[0].Substring(intPos_AS2 + 4);
                lstWord[0] = lstWord[0].Substring(0, intPos_AS2);
            }
            int intPos_Empty = lstWord[0].IndexOf(' ');
            string strMainTabNamePart = lstWord[0].Substring(intPos_Empty);
            string[] sstrPart = strMainTabNamePart.Split('.');
            if (sstrPart.Length != 2)
            {
                string strMsg = string.Format("在Sql语句：{2}的FROM部分:{0}中，主表：{1}格式不正确，请检查！", strText_From, strMainTabNamePart, strSqlStatement);

                throw new Exception(strMsg);
            }
            strMainTabName = sstrPart[1].Trim();


            objSqlStatementRelaTabEN_Main = new SqlStatementRelaTab();
            //objSqlStatementRelaTabEN_Main.SqlStatementId = objSqlViewEN.SqlViewId;// Sql视图Id

            objSqlStatementRelaTabEN_Main.TabName = strMainTabName;// 表别名
            if (string.IsNullOrEmpty(strMainTabName_Alias) == false)
            {
                objSqlStatementRelaTabEN_Main.TabAliases = strMainTabName_Alias;// 表别名
            }
            else
            {
                objSqlStatementRelaTabEN_Main.TabAliases = strMainTabName;// 表别名
            }
            objSqlStatementRelaTabEN_Main.SV_RelaTabTypeId = "01";// Sql视图相关表类型Id
            objSqlStatementRelaTabEN_Main.TabRelationTypeId = "00";// 表关系类型Id
            objSqlStatementRelaTabEN_Main.TabRelationText = "";// 表关系文本
            objSqlStatementRelaTabEN_Main.OrderNum = intOrderNum++;// OrderNum
            objSqlStatementRelaTabEN_Main.PrjId = strPrjId;// 工程ID
            objSqlStatementRelaTabEN_Main.UpdDate = strCurrDate14;// 修改日期
            objSqlStatementRelaTabEN_Main.UpdUserId = strUserId;// 修改用户Id
            objSqlStatementRelaTabEN_Main.Memo = "通过分析！";// 说明

            arrSqlStatementRelaTabObjLst.Add(objSqlStatementRelaTabEN_Main);
            for (int i = 1; i < lstWord.Count; i++)
            {
                string strWord = lstWord[i].Trim();//去除主表名后的部分
                string strTabRelationTypeId = "";
                string strReleTabName = "";
                List<string> lstFlag2 = new List<string>();
                lstFlag2.Add(" ON ");

                List<string> lstWord2 = clsString.SplitStringBySplitFlagLst(strWord, lstFlag2);

                if (lstWord2[0].IndexOf("LEFT OUTER JOIN", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strTabRelationTypeId = "01"; // 左连接
                    strReleTabName = lstWord2[0].Substring("LEFT OUTER JOIN".Length).Trim();
                }
                else if (lstWord2[0].IndexOf("Right OUTER JOIN", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strTabRelationTypeId = "02"; // 左连接
                    strReleTabName = lstWord2[0].Substring("Right OUTER JOIN".Length).Trim();
                }
                else if (lstWord2[0].IndexOf("FULL OUTER JOIN", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strTabRelationTypeId = "03"; // 左连接
                    strReleTabName = lstWord2[0].Substring("FULL OUTER JOIN".Length).Trim();
                }
                else if (lstWord2[0].IndexOf("INNER JOIN", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    strTabRelationTypeId = "04"; // 左连接
                    strReleTabName = lstWord2[0].Substring("INNER JOIN".Length).Trim();
                }
                int intPos_AS = strReleTabName.IndexOf(" AS ", StringComparison.InvariantCultureIgnoreCase);
                string strTabAliases = "";
                if (intPos_AS > 0)
                {
                    strTabAliases = strReleTabName.Substring(intPos_AS + 3).Trim();
                    strReleTabName = strReleTabName.Substring(0, intPos_AS).Trim();
                }
                else
                {
                    strReleTabName = strReleTabName.Trim();
                    int intPos_Empty2 = strReleTabName.IndexOf(" ");
                    if (intPos_Empty2 > 0)
                    {
                        strTabAliases = strReleTabName.Substring(intPos_Empty2 + 1).Trim();
                        strReleTabName = strReleTabName.Substring(0, intPos_Empty2).Trim();
                    }
                }
                sstrPart = strReleTabName.Split('.');
                if (sstrPart.Length != 2)
                {
                    string strMsg = string.Format("在Sql语句：{2}的FROM部分:{0}中，主表：{1}格式不正确，请检查！", strText_From, strReleTabName, strSqlStatement);

                    throw new Exception(strMsg);
                }
                string strReleTabName2 = sstrPart[1].Trim();

                if (string.IsNullOrEmpty(strTabAliases) == true)
                {
                    strTabAliases = strReleTabName2;
                }
                //if (string.IsNullOrEmpty(strTabAliases) == false)
                //{
                //    if (htTabAliases == null)
                //    {
                //        htTabAliases = new Hashtable();
                //    }
                //    htTabAliases.Add(strTabAliases, strReleTabName2);
                //}

                SqlStatementRelaTab objSqlStatementRelaTabEN = new SqlStatementRelaTab();
                //objSqlStatementRelaTabEN.SqlViewId = objSqlViewEN.SqlViewId;// Sql视图Id

                objSqlStatementRelaTabEN.TabName = strReleTabName;// 表名
                objSqlStatementRelaTabEN.TabAliases = strTabAliases;// 表别名
                objSqlStatementRelaTabEN.SV_RelaTabTypeId = "02";// Sql视图相关表类型Id
                objSqlStatementRelaTabEN.TabRelationTypeId = strTabRelationTypeId;// 表关系类型Id
                if (lstWord2.Count >= 2)
                {
                    objSqlStatementRelaTabEN.TabRelationText = lstWord2[1];// 表关系文本
                }
                else
                {
                    objSqlStatementRelaTabEN.TabRelationText = "";
                }
                objSqlStatementRelaTabEN.OrderNum = intOrderNum++;// OrderNum
                objSqlStatementRelaTabEN.PrjId = strPrjId;// 工程ID
                objSqlStatementRelaTabEN.UpdDate = strCurrDate14;// 修改日期
                objSqlStatementRelaTabEN.UpdUserId = strUserId;// 修改用户Id
                objSqlStatementRelaTabEN.Memo = "通过分析！";// 说明
                arrSqlStatementRelaTabObjLst.Add(objSqlStatementRelaTabEN);
            }

            return arrSqlStatementRelaTabObjLst;
        }

    }
}
