using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web;
using System.Diagnostics;
//using TzPubFunction.Properties;

namespace com.taishsoft.common
{
    /// <summary>
    /// 
    /// </summary>
    public class clsString
    {
        public clsString()
        {
        }
        /// <summary>
        /// 组装字符串，
        /// </summary>
        /// <param name="mStr">原来的字符串</param>
        /// <param name="count">该字符串的重复次数</param>
        /// <returns>组装好的字符串</returns>
        public string combineStr(string mStr, int count)
        {
            string strTemp = "";
            for (int i = 0; i < count; i++)
                strTemp += mStr;
            return strTemp;
        }

        /// <summary>
        /// 组装字符串，
        /// </summary>
        /// <param name="mStr">原来的字符串</param>
        /// <param name="count">该字符串的重复次数</param>
        /// <returns>组装好的字符串</returns>
        public static string combineStrS(string mStr, int count)
        {
            string strTemp = "";
            for (int i = 0; i < count; i++)
                strTemp += mStr;
            return strTemp;
        }
        /// <summary>
        /// 功能:使给定的字符串首字母大写
        /// </summary>
        /// <param name="mStr"></param>
        public void FstUcase(ref string mStr)
        {
            if (mStr.Length == 0) return;
            if (mStr.Length > 1)
            {
                mStr = mStr.Substring(0, 1).ToUpper() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                mStr = mStr.Substring(0, 1).ToUpper();
            }
        }
        /// <summary>
        /// 把单词的第一个字母变成大写
        /// </summary>
        /// <param name="mStr"></param>
        public static void FstUcase_S(ref string mStr)
        {
            if (mStr.Length == 0) return;
            if (mStr.Length > 1)
            {
                mStr = mStr.Substring(0, 1).ToUpper() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                mStr = mStr.Substring(0, 1).ToUpper();
            }
        }
        /// <summary>
        /// 把单词的第一个字母变成大写
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public string FirstUcase(string mStr)
        {
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 1)
            {
                strResult = mStr.Substring(0, 1).ToUpper() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                strResult = mStr.Substring(0, 1).ToUpper();
            }
            return strResult;
        }
        /// <summary>
        /// 把单词的第一个字母变成大写
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public static string FirstUcaseS(string mStr)
        {
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 1)
            {
                strResult = mStr.Substring(0, 1).ToUpper() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                strResult = mStr.Substring(0, 1).ToUpper();
            }
            return strResult;
        }
        /// <summary>
        /// 把单词的第一个字母变成小写
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public string FstLcase(string mStr)
        {
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 1)
            {
                strResult = mStr.Substring(0, 1).ToLower() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                strResult = mStr.Substring(0, 1).ToLower();
            }
            return strResult;
        }
        /// <summary>
        /// 把单词的第一个字母变成小写
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public static string FstLcaseS(string mStr)
        {
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 1)
            {
                strResult = mStr.Substring(0, 1).ToLower() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                mStr = mStr.Substring(0, 1).ToLower();
            }
            return strResult;
        }
        /// <summary>
        /// 把单词的第一个字母变成小写
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public static string FirstLcaseS(string mStr)
        {
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 1)
            {
                strResult = mStr.Substring(0, 1).ToLower() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                mStr = mStr.Substring(0, 1).ToLower();
            }
            return strResult;
        }

        /// <summary>
        /// 把变量名的第一个字母若大写变成小写，若前两个字母大写全变成小写
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public static string Fst2LcaseS(string mStr)
        {
            if (mStr == null) return "";
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 2)
            {
                string strFirstLetter = mStr.Substring(0, 1);
                string strSecondLetter = mStr.Substring(1, 1);
                if (clsString.IsUpper(strFirstLetter))
                {
                    if (clsString.IsUpper(strSecondLetter))
                    {
                        strResult = strFirstLetter.ToLower()
                            + strSecondLetter.ToLower()
                            + mStr.Substring(2, mStr.Length - 2);
                    }
                    else
                    {
                        strResult = mStr.Substring(0, 1).ToLower() + mStr.Substring(1, mStr.Length - 1);
                    }
                }
                else
                {
                    strResult = mStr;
                }
            }
            else if (mStr.Length > 1)
            {                
                strResult = mStr.Substring(0, 1).ToLower() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                mStr = mStr.Substring(0, 1).ToLower();
            }
            return strResult;
        }

        /// <summary>
        /// 把一个整型转换成一个二进制的字符串
        /// </summary>
        public string GetBinaryS(int mInt)
        {
            string s1;
            System.Collections.Stack S = new System.Collections.Stack();
            while (mInt > 0)
            {
                S.Push(mInt % 2);
                mInt = mInt / 2;
            }
            s1 = "";
            while (S.Count > 0)
            {
                s1 = s1 + S.Pop().ToString();
            }
            return s1;
        }


        /// <summary>
        /// 文件备份
        /// </summary>
        /// <param name="fName"></param>
        /// <returns></returns>
        public bool FileBackup(string fName)
        {
            string fNameBak;
            string NewfName;
            if (File.Exists(fName))
            {
                fNameBak = fName + "bak";
                NewfName = fName + "1";
                if (File.Exists(fNameBak)) File.Delete(fNameBak);
                if (File.Exists(NewfName)) File.Delete(NewfName);
                File.Copy(fName, fNameBak);
                File.Copy(fName, NewfName);
            }
            else
            {
                return false;
            }
            return true;
        }

        public string ParentDir(string strPath)
        {
            string pDir;
            int i;
            strPath = strPath.Replace("/", "\\");
            i = strPath.LastIndexOf("\\");
            if (i == 0) return null;
            pDir = strPath.Substring(0, i+1);
            return pDir;
        }
        /// <summary>
        /// 获取目录名
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public static string GetDirName_S(string strPath)
        {
            string pDir;
            int i;
            strPath = strPath.Replace("/", "\\");
            i = strPath.LastIndexOf("\\");

            if (i <= 0) return "";
            pDir = strPath.Substring(0, i+1);
            return pDir;
        }

        /// <summary>
        /// 获取唯一文件名
        /// </summary>
        /// <param name="strFileFullName"></param>
        /// <returns>获取的唯一文件名</returns>
        public static string GetUniqueFileName_S(string strFileFullName)
        {

            string strFileDirName = clsString.GetDirName_S(strFileFullName);
            string strFileName = clsString.GetSimpleFName_S(strFileFullName);
            string strPureFileName = clsString.GetPureFileName(strFileName);
            string strExeName = clsString.GetFileExtName(strFileName);
            string strFileFullName_New = string.Format("{0}{1}_01.{2}", 
                strFileDirName,
                strPureFileName,
                strExeName);
            int intIndex = 2;
            while(true)
            {
                if (File.Exists(strFileFullName_New) == false)
                {
                    return strFileFullName_New;
                }
                string strIndex = intIndex.ToString("00");
                strFileFullName_New = string.Format("{0}{1}_{3}.{2}",
                       strFileDirName,
                       strPureFileName,
                      strExeName,
                      strIndex);
                intIndex++;
            }
                     
            return "";
        }

        /// <summary>
        /// 获取唯一字符串值，如果在已存在的值列表中存在，就在后面加-01,-02,-03等
        /// </summary>
        /// <param name="strValue">需要检查的值</param>
        /// <param name="arrExistValueList">已存在的值列表</param>
        /// <returns>获取的唯一文件名</returns>
        public static string GetUniqueStrValue_S(string strValue, List<string> arrExistValueList)
        {
            if (arrExistValueList.Contains(strValue) == false)
            {
                return strValue;
            }        
            string strValue_New = string.Format("{0}_01",
                strValue);
            int intIndex = 2;
            while (true)
            {
                if (arrExistValueList.Contains(strValue_New) == false)
                {
                    return strValue_New;
                }
                string strIndex = intIndex.ToString("00");
                strValue_New = string.Format("{0}_{1}",
                       strValue,
                      strIndex);
                intIndex++;
            }
//            return "";
        }
        /// <summary>
        /// 父目录
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public static string ParentDir_S(string strPath)
        {
            string pDir;
            int i;
            strPath = strPath.Replace("/", "\\");
            i = strPath.LastIndexOf("\\");
            if (i <= 0) return "";
            pDir = strPath.Substring(0, i+1);
            return pDir;
        }

        /// <summary>
        /// 为文件名添加扩展名
        /// </summary>
        /// <param name="strFileName"></param>
        /// <param name="strExeName"></param>
        /// <returns></returns>
        public bool AddExeName(ref string strFileName, string strExeName)
        {
            int i;
            i = strFileName.LastIndexOf(strExeName);
            if (i == 0) strFileName += strExeName;
            return true;
        }
        /// <summary>
        /// 从带有目录的文件名中获取简单的文件名
        /// </summary>
        /// <param name="strFileName">带有目录的文件名</param>
        /// <returns>不带目录的简单的文件名</returns>
        public string GetSimpleFName(string strFileName)
        {
            string sFName;
            int i;
            strFileName = strFileName.Replace("/", "\\");
            i = strFileName.LastIndexOf("\\");
            if (i == 0) return null;
            sFName = strFileName.Substring(i + 1);
            return sFName;
        }
        /// <summary>
        /// 从带有目录的文件名中获取简单的文件名
        /// </summary>
        /// <param name="strFileName">带有目录的文件名</param>
        /// <returns>不带目录的简单的文件名</returns>
        public static string GetSimpleFName_S(string strFileName)
        {
            string sFName;
            int i;
            strFileName = strFileName.Replace("/", "\\");
            i = strFileName.LastIndexOf("\\");
            if (i == 0) return null;
            sFName = strFileName.Substring(i + 1);
            return sFName;
        }

        /// <summary>
        /// 从多级目录中获取最后一层目录名
        /// </summary>
        /// <param name="strFileName">带有目录的文件名</param>
        /// <returns>不带目录的简单的文件名</returns>
        public static string GetSimplePath(string strFilePath)
        {
            string strSimplePath;
            int i, j;
            i = strFilePath.LastIndexOf("\\");
            j = strFilePath.LastIndexOf("/");
            int ii = i > j ? i : j;
            if (ii <= 0)
            {
                return strFilePath;
            }
            strSimplePath = strFilePath.Substring(ii + 1);
            return strSimplePath;
        }
        /// <summary>
        /// 根据文件名，获取该文件的扩展名
        /// </summary>
        /// <param name="strFileName">给定的文件名</param>
        /// <returns></returns>
        public static string GetFileExtName(string strFileName)
        {
            string strFileExtName;
            int i;
            i = strFileName.LastIndexOf(".");
            if (i == 0) return null;
            strFileExtName = strFileName.Substring(i + 1);
            return strFileExtName;
        }
        /// <summary>
        /// 根据文件名，获取该文件的去除扩展名的纯粹文件名
        /// </summary>
        /// <param name="strFileName">给定的文件名</param>
        /// <returns></returns>
        public static string GetPureFileName(string strFileName)
        {
            if (strFileName == "")
                return null;
            string strPureFileName;
            int i;
            i = strFileName.LastIndexOf(".");
            if (i == 0) return strFileName;
            strPureFileName = strFileName.Substring(0, i);
            return strPureFileName;
        }
        /// <summary>
        /// 判断给定字符串是否是日期型数据
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public static bool IsDate(string strValue)
        {
            string strDate = "";
            if (strValue == "") return true;
            if (strValue.Length < 8)
            {
                return false;
            }
            if (strValue.Length == 8)
            {
                strDate = strValue.Substring(0, 4) + "-" + strValue.Substring(4, 2) + "-" + strValue.Substring(6, 2);
            }
            strDate = strValue;
            try
            {
                DateTime dt = DateTime.Parse(strDate);
            }
            catch (Exception expt)
            {
                string ss = expt.Message;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 判断给定字符串是否是布尔型数据
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public static bool IsBoolean(string strValue)
        {
            if (strValue == "") return false;
            strValue = strValue.ToLower();
            if (strValue == "false" || strValue == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 判断给定字符串是否是Bit型数据
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public static bool IsBit(string strValue)
        {
            if (strValue == "") return false;
            if (strValue == "0" || strValue == "1" || strValue == "False" || strValue == "True")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 判断是否是数字
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public static bool IsDigit(string strValue)
        {
            if (string.IsNullOrEmpty(strValue) == true) return false;
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 判断是否是字母
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public static bool IsLetter(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsLetter(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// 判断是否是大写字母,
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public static bool IsUpper(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsUpper(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 判断是否是小写字母,
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public static bool IsLower(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsLower(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 判断是否是浮点型数值
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public static bool IsFloat(string strValue)
        {
            if (string.IsNullOrEmpty(strValue) == true) return false;
            int intPointNum = 0;
            //用于处理负数的情况
            if (strValue.Substring(0, 1) == "-") strValue = strValue.Substring(1);
            if (strValue.Substring(0, 1) == "+") strValue = strValue.Substring(1);

            char[] arrChar = strValue.ToCharArray();
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
                {
                }
                else
                {
                    return false;
                }
                if (arrChar[i] == '.') intPointNum++;
            }
            //检查总共有几个小数点，如果有多于1个小数点，就不正确
            if (intPointNum > 1) return false;
            return true;
        }
        /// <summary>
        /// 判断是否是整型数值
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public static bool IsNumeric(string strValue)
        {

            int intLen = strValue.Length;
            if (intLen == 0) return false;
            //用于处理负数的情况
            if (strValue.Substring(0, 1) == "-") strValue = strValue.Substring(1);
            if (strValue.Substring(0, 1) == "+") strValue = strValue.Substring(1);
            intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 功能：获取当前日期的字符串
        /// 日期格式：
        ///    日期的字符串的格式有三种：
        ///		1、YYYYMMDD。	例如20050120
        ///		2、YYYY-MM-DD	例如2005-01-20
        ///		3、YYYY/MM/DD	例如2005/01/20
        ///		4、YYYY年MM月DD日
        ///		5、YYYY年MM月DD日 星期X
        /// </summary>
        /// <param name="intFormat">日期格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的日期格式
        ///	</param>
        /// <returns>返回当前日期的字符串</returns>
        public string getTodayStr(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay, strWeek;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            strWeek = TransWeekFromEngToChs(System.DateTime.Today.DayOfWeek.ToString());
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
                case 3:
                    strToday = strYear + "年" + strMonth + "月" + strDay + "日";
                    break;
                case 4:
                    strToday = strYear + "年" + strMonth + "月" + strDay + "日 " + strWeek;
                    break;

            }
            return strToday;
        }
        /// <summary>
        /// 功能：获取当前月的字符串
        /// 月的格式：
        ///    月的字符串的格式有三种：
        ///		1、YYYYMM。	例如200501
        ///		2、YYYY-MM-DD	例如2005-01
        ///		3、YYYY/MM/DD	例如2005/01
        ///		4、YYYY年MM月DD日
        ///		5、YYYY年MM月DD日 星期X
        /// </summary>
        /// <param name="intFormat">月的格式，共有3种，传入参数0,1，2，3,4
        ///							参数不同，函数返回值就不同，
        ///							参见上面的月的格式
        ///	</param>
        /// <returns>返回当前月的字符串</returns>
        public string getCurrMonth(int intFormat)
        {
            string strCurrMonth;
            string strYear, strMonth;
            int intYear, intMonth;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;

            }
            return strCurrMonth;
        }

        /// <summary>
        /// 功能：获取当前日期的字符串
        /// 日期格式：
        ///    日期的字符串的格式有三种：
        ///		1、YYYYMMDD。	例如20050120
        ///		2、YYYY-MM-DD	例如2005-01-20
        ///		3、YYYY/MM/DD	例如2005/01/20
        /// </summary>
        /// <param name="intFormat">日期格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的日期格式
        ///	</param>
        /// <returns>返回当前日期的字符串</returns>
        public static string getTodayStr_S(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay, strWeek;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            strWeek = TransWeekFromEngToChs(System.DateTime.Today.DayOfWeek.ToString());

            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
                case 3:
                    strToday = strYear + "年" + strMonth + "月" + strDay + "日";
                    break;
                case 4:
                    strToday = strYear + "年" + strMonth + "月" + strDay + "日 " + strWeek;
                    break;

            }
            return strToday;
        }
        /// <summary>
        /// 功能：获取当前月的字符串
        /// 月的格式：
        ///    月的字符串的格式有三种：
        ///		1、YYYYMM。	例如200501
        ///		2、YYYY-MM-DD	例如2005-01
        ///		3、YYYY/MM/DD	例如2005/01
        /// </summary>
        /// <param name="intFormat">月的格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的月的格式
        ///	</param>
        /// <returns>返回当前月的字符串</returns>
        public static string getCurrMonth_S(int intFormat)
        {
            string strCurrMonth;
            string strYear, strMonth;
            int intYear, intMonth;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;
            }
            return strCurrMonth;
        }
        private static string TransWeekFromEngToChs(string strEndWeek)
        {
            if (strEndWeek == "Friday") return "星期五";
            else if (strEndWeek == "Monday") return "星期一";
            else if (strEndWeek == "Saturday") return "星期六";
            else if (strEndWeek == "Sunday") return "星期日";
            else if (strEndWeek == "Thursday") return "星期四";
            else if (strEndWeek == "Tuesday") return "星期二";
            else if (strEndWeek == "Wednesday") return "星期三";
            else return "星期数据非法!";
        }
        public static string GetHostIpAddress()
        {
            System.Net.IPAddress[] addressList = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList;
            if (addressList.Length > 1)
            {
                return addressList[0].ToString();
            }
            else
            {
                return addressList[0].ToString();
            }
            //			{ 
            //			
            //			if ( addressList.Length>1)
            //			{ 
            //				nativeIP.Text = addressList[0].ToString();
            //				serverIP.Text = addressList[1].ToString();
            //			}
            //			else
            //			{
            //				nativeIP.Text = addressList[0].ToString();
            //				serverIP.Text = "Break the line...";
            //			}
        }
        /**/
        /// <summary>
        /// 转全角的函数(SBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>全角字符串</returns>
        ///<remarks>
        ///全角空格为12288，半角空格为32
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        ///</remarks>        
        public string ToSBC(string input)
        {
            //半角转全角：
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32)
                {
                    c[i] = (char)12288;
                    continue;
                }
                if (c[i] < 127)
                    c[i] = (char)(c[i] + 65248);
            }
            return new string(c);
        }


        /**/
        /// <summary>
        /// 转半角的函数(DBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>半角字符串</returns>
        ///<remarks>
        ///全角空格为12288，半角空格为32
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        ///</remarks>
        public string ToDBC(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }
        /**/
        /// <summary>
        /// 转半角的函数(DBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>半角字符串</returns>
        ///<remarks>
        ///全角空格为12288，半角空格为32
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        ///</remarks>
        public static string ToDBC_S(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }
        /// <summary>
        /// 转半角的函数(DBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>半角字符串</returns>
        ///<remarks>
        ///全角空格为12288，半角空格为32
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        ///</remarks>
        public static string ToDBC_S160(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 160)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }
        /// <summary>
        /// 获取字符串的实际字节长度，其中汉字是2个字节，字母是一个字节
        /// </summary>
        /// <param name="strTemp">提供的字符串</param>
        /// <returns>返回的字节长度</returns>
        public static int getStrLenS(string strTemp)
        {
            int len;
            byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
            len = sarr.Length;//will output as 3+3*2=9
            return len;
        }

      /// <summary>
      /// 分子串，根据分隔标志列表来分
      /// </summary>
      /// <param name="strSourceStr">源串</param>
      /// <param name="lstSplitFlag">分隔标志列表</param>
      /// <returns>返回字符串列表，分隔子串的列表</returns>
        public static List<string> SplitStringBySplitFlagLst(string strSourceStr, List<string> lstSplitFlag)
        {
            //if (clsDebugBase_Pub.IsDebug == true)
            //{
            //    StackTrace trace = new StackTrace();
            //    int intCurrLevel = 0;
            //    foreach (StackFrame frame in trace.GetFrames())
            //    {
                    
            //        string strFileName = frame.GetFileName();
            //        string strMothodName = frame.GetMethod().Name;
            //        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
            //        clsDebugBase_Pub.WriteLog(strDeclaringType + ":" + strMothodName);
            //        if (intCurrLevel > clsDebugBase_Pub.TraceLevel) break;
            //    }
            //}
            strSourceStr += "  ";
            List<int> lstPos = new List<int>();
            lstPos.Add(0);
            foreach (string strSplitFlag in lstSplitFlag)
            {
                int intPos = -1;
                while (true)
                {
                    intPos = strSourceStr.IndexOf(strSplitFlag, intPos + 1, StringComparison.InvariantCultureIgnoreCase);
                    if (intPos >= 0)
                    {
                        if (lstPos.Contains(intPos) == false) lstPos.Add(intPos);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            lstPos.Add(strSourceStr.Length - 1);
            lstPos.Sort();
            List<string> lstItem = new List<string>();
            for (int i = 0; i < lstPos.Count - 1; i++)
            {
                int intPos_Start = lstPos[i];
                int intPos_End = lstPos[i + 1];
                string strItem = strSourceStr.Substring(intPos_Start, intPos_End - intPos_Start);
                if (string.IsNullOrEmpty(strItem) == false)
                {
                    lstItem.Add(strItem);
                }
            }
            return lstItem;
        }
  

        public static List<string> SplitCondition(string strConditionStr)
        {
            if (string.IsNullOrEmpty(strConditionStr) == true)
            {
                return null;
            }
            int[] iCondPos = new int[20];   //记录"And","Or"的位置
            int iIndex = 0;
            iCondPos[iIndex++] = 0;
            string strChar = "";
            int intLength = strConditionStr.Length;
            string strConditionStr_L = strConditionStr.ToLower();
            for (int iPos = 0; iPos < intLength; iPos++)
            {
                strChar = strConditionStr_L.Substring(iPos, 1);
                switch (strChar)
                {
                    case "(":
                        //打相应的右括号
                        int intTempPos = FindRelaRightBrackets(strConditionStr_L, iPos + 1);
                        if (intTempPos == -1)
                        {
                            StringBuilder sbMsg = new StringBuilder();
                            sbMsg.AppendFormat("在字符串：{0}的位置：{1}处左括号没有配对的右括号。", iPos);
                            throw new Exception(sbMsg.ToString());
                        }
                        iPos = intTempPos;
                        break;
                    case "a":
                        if (strConditionStr_L.Substring(iPos + 1, 2) == "nd")
                        {
                            iCondPos[iIndex++] = iPos;
                        }
                        break;
                    case "o":
                        if (strConditionStr_L.Substring(iPos + 1, 1) == "r")
                        {
                            iCondPos[iIndex++] = iPos;
                        }
                        break;
                    default:
                        break;
                }
            }
            List<string> arrCond = new List<string>();
            string strCond = "";
            for (int i = 0; i < iIndex - 1; i++)
            {
                strCond = strConditionStr.Substring(iCondPos[i], iCondPos[i + 1] - iCondPos[i]);
                arrCond.Add(strCond);
            }
            strCond = strConditionStr.Substring(iCondPos[iIndex - 1]);
            arrCond.Add(strCond);
            return arrCond;
        }
        /// <summary>
        /// 找相应的右括号（Brackets：括号）
        /// </summary>
        /// <param name="strValue">字符串值</param>
        /// <param name="iStartPos">起始位置</param>
        /// <returns></returns>
        public static int FindRelaRightBrackets(string strValue, int iStartPos)
        {
            string strChar = "";
            int intLength = strValue.Length;
            for (int iPos = iStartPos; iPos < intLength; iPos++)
            {
                strChar = strValue.Substring(iPos, 1);
                switch (strChar)
                {
                    case "(":
                        //打相应的右括号
                        int intTempPos = FindRelaRightBrackets(strValue, iPos + 1);
                        if (intTempPos == -1) return -1;
                        if (intTempPos >= intLength) return -1;
                        iPos = intTempPos;
                        break;
                    case ")":
                        return iPos;
                    default:
                        break;

                }
            }
            return -1; //超界，未找到
        }
        /// <summary>
        /// 去除两端（Ends）的括号（Brackets）
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public static string RemoveEndsBrackets(string strValue)
        {
            string strNewValue = "";
            strValue = strValue.Trim();
            int intLength = strValue.Length;
            if (strValue.Substring(0, 1) == "(")
            {
                if (strValue.Substring(intLength - 1, 1) == ")")
                {
                    strNewValue = strValue.Substring(1, intLength - 2);
                    return strNewValue;
                }
                else
                {
                    return strValue;
                }
            }
            else
            {
                return strValue;
            }
        }
        public static string IntToStr(int intValue, int intStrLen)
        {
            string strFormat = combineStrS("0", intStrLen);
            string strTemp = string.Format(strFormat, intValue);
            return strTemp;
        }

        public static Encoding GetEncodingObjByCharEncodingId(string strCharEncodingId)
        {
            string strCharEncodingId_Lower = strCharEncodingId.ToLower();
            Encoding myEncoding = null;
//ANSI	ANSI字符集	ANSI字符集定义：ASCII字符集，以及由此派生并兼容的字符集，如：GB2312，正式的名称为MBCS(Multi-Byte Chactacter System，多字节字符系统)，通常也称为ANSI字符集。	NULL
//ASCII	ASCII-美国信息互换标准代码	ASCII（American Standard Code for Information Interchange，美国信息互换标准代码）是基于罗马字母表的一套电脑编码系统。	NULL
//BIG5	BIG5-大五码或五大码	BIG5又称大五码或五大码，1984年由台湾财团法人信息工业策进会和五间软件公司宏碁 (Acer)、神通 (MiTAC)、佳佳、零壹 (Zero One)、大众 (FIC)创立，故称大五码。
//Big5码使用了双字节储存方法，一个字符占2个字节。第一个字节称为“高位字节”，第二个字节称为“低位字节”。高位字节的编码范围0xA1-0xF9，低位字节的编码范围0x40-0x7E及0xA1-0xFE。	NULL
//GB18030	GB18030-信息交换用汉字编码字符集基本集的扩充	GB18030的全称是GB18030-2000《信息交换用汉字编码字符集基本集的扩充》，是我国政府于2000年3月17日发布的新的汉字编码国家标准，2001年8月31日后在中国市场上发布的软件必须符合本标准。GB18030字符集标准的出台经过广泛参与和论证，来自国内外知名信息技术行业的公司，信息产业部和原国家质量技术监督局联合实施。	NULL
//GB2312	GB2312-简体中文字符集		NULL
//GBK	GBK-GB2312的扩展	GBK字符集是GB2312的扩展(K)，向下完全兼容GB2312，GBK1.0收录了21886个符号，它分为汉字区和图形符号区，汉字区包括21003个字符。GBK字符集主要扩展了繁体中文字的支持及GB2312不包含的汉字部首符号、竖排标点符号等字符。	NULL
//Unicode	Unicode-通用多八位编码字符集	Unicode字符集编码是（Universal Multiple-Octet Coded Character Set ）通用多八位编码字符集的简称，是由一个名为 Unicode 学术学会(Unicode Consortium)的机构制订的字符编码系统，支持现今世界各种不同语言的书面文本的交换、处理及显示。该编码于1990年开始研发，1994年正式公布，最新版本是2005年3月31日的Unicode 4.1.0。它为每种语言中的每个字符设定了统一并且唯一的二进制编码，以满足跨语言、跨平台进行文本转换、处理的要求。	NULL
//UTF-16	UTF-16--标准的 Unicode 称为UTF-16(UTF:UCS Transformation Format )	标准的 Unicode 称为UTF-16(UTF:UCS Transformation Format )	NULL
//UTF-8	UTF-8--Unicode Translation Format，即把Unicode转做某种格式的意思	UTF是 Unicode Translation Format，即把Unicode转做某种格式的意思。所以UTF-8是Unicode的其中一个使用方式。UTF-8以字节为编码单元，没有字节序的问题。它使用可变长度字节来储存 Unicode字符，ASCII字母继续使用1字节储存，重音文字、希腊字母或西里尔字母等使用2字节来储存，而常用的汉字就要使用3字节，辅助平面字符则使用4字节。（UTF-8编码的最大长度是4个字节）	True
            switch (strCharEncodingId_Lower)
            {
                case "ansi":
                    myEncoding = Encoding.Default;
                    break;
                case "ascii":
                    myEncoding = Encoding.ASCII;
                    break;
                case "utf-8":
                    myEncoding = Encoding.UTF8;
                    break;
                case "utf-8withoutbom":
                    myEncoding = new UTF8Encoding(false);
                    break;
                case "big5":
                    myEncoding = Encoding.BigEndianUnicode;
                    break;
                case "gb18030":
                    myEncoding = Encoding.Default;
                    break;
                case "gb2312":
                    myEncoding = Encoding.Default;
                    break;
                case "gbk":
                    myEncoding = Encoding.Default;
                    break;
                case "unicode":
                    myEncoding = Encoding.Unicode;
                    break;
                case "utf-16":
                    myEncoding = Encoding.UTF32;
                    break;
                default:
                    myEncoding = Encoding.Unicode;
                    break;
            }
            return myEncoding;
        }
        public static string Utf8ToAscII(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.UTF8;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns></returns>
        public static string Utf8ToUnicode(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.Unicode;
            Encoding unicode = Encoding.UTF8;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }

        public static string Utf8ToDefault(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.Default;
            Encoding unicode = Encoding.UTF8;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }

        public static string Utf8ToGB2312(byte[] strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] SourceBytes = strSource;// utf8.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(utf8, gb2312, SourceBytes);
            char[] TargetChars = new char[gb2312.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            gb2312.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string gb2312info = new string(TargetChars);
            return gb2312info;




        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns></returns>
        public static string Utf8ToGB2312(string strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] SourceBytes = utf8.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(utf8, gb2312, SourceBytes);
            char[] TargetChars = new char[gb2312.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            gb2312.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string gb2312info = new string(TargetChars);
            return gb2312info;

        }
        /// <summary>
        /// 把gb2312的字符串转换成UTF8的字符串
        /// </summary>
        /// <param name="strSource">源字符串</param>
        /// <returns>转换成的目标字符串</returns>
        public static string GB2312ToUtf8(string strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] SourceBytes = gb2312.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(gb2312, utf8, SourceBytes);
            char[] TargetChars = new char[utf8.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            utf8.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string gb2312info = new string(TargetChars);
            return gb2312info;

        }
        /// <summary>
        /// 把gb2312的字符串转换成UTF8的字节数组
        /// </summary>
        /// <param name="strSource">源字符串</param>
        /// <returns>目标字节数组</returns>
        public static byte[] GB2312ToUtf8Bytes(string strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] SourceBytes = gb2312.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(gb2312, utf8, SourceBytes);
            return TargetBytes;

        }

        public static string Utf8ToGBK(string strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gbk");
            byte[] SourceBytes = utf8.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(utf8, gb2312, SourceBytes);
            char[] TargetChars = new char[gb2312.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            gb2312.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string gb2312info = new string(TargetChars);
            return gb2312info;



        }

        public static string UnicodeToGB2312(string strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.Unicode;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] SourceBytes = utf8.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(utf8, gb2312, SourceBytes);
            char[] TargetChars = new char[gb2312.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            gb2312.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string gb2312info = new string(TargetChars);
            return gb2312info;




        }

        public static string UnicodeToDefault(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.Default;
            Encoding unicode = Encoding.Unicode;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }

        public static string UnicodeToASCII(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }

        public static string UnicodeToUTF8(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.UTF8;
            Encoding unicode = Encoding.Unicode;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns></returns>
        public static string GB2312TOUtf8(string strSource)
        {
            string strResult = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] bytSources = gb2312.GetBytes(strSource);
            byte[] bytTargets = Encoding.Convert(gb2312, utf8, bytSources);
            char[] chrTargets = new char[gb2312.GetCharCount(bytTargets, 0, bytTargets.Length)];
            utf8.GetChars(bytTargets, 0, bytTargets.Length, chrTargets, 0);
            strResult = new string(chrTargets);
            return strResult;

        }
        /// <summary>
        /// 根据身份证获取出生年月
        /// </summary>
        /// <param name="ID">身份证号</param>
        /// <returns>年月日 如:19990101</returns>
        public static string GetBirthdayByIDNumber(string strIDNumber)
        {
            try
            {
                string Birthday = "";
                if (strIDNumber.Length == 15)
                {
                    string ss = strIDNumber.Substring(6, 6);
                    Birthday = "19" + ss;
                }
                else if (strIDNumber.Length == 18)
                {
                    string ss = strIDNumber.Substring(6, 8);
                    Birthday = ss;
                }
                else
                {
                    throw new Exception("请输入15位或者18位的身份证信息！\r\n");
                }
                string year = Birthday.Substring(0, 4);
                string month = Birthday.Substring(4, 2);
                string date = Birthday.Substring(6, 2);
                if (int.Parse(year) < 1900)
                {
                    //年份不能大于1900
                    throw new Exception("身份证信息错误, 年份不能大于1900！\r\n");
                }
                else if (int.Parse(year) > DateTime.Now.Year)
                {
                    //年份不能小于现在年份
                    throw new Exception("身份证信息错误, 年份不能超过现在年份！\r\n");
                }
                else if (int.Parse(month) < 1)
                {
                    //月份不能小于1
                    throw new Exception("身份证信息错误,月份不能小于1！\r\n");
                }
                else if (int.Parse(month) > 12)
                {
                    //月份不能大于12
                    throw new Exception("身份证信息错误,月份不能大于12！\r\n");
                }
                else if (int.Parse(date) < 1)
                {
                    //日期不能小于1
                    throw new Exception("身份证信息错误,日期不能小于1！\r\n");
                }
                else if (int.Parse(date) > 31)
                {
                    //日期不能大于31
                    throw new Exception("身份证信息错误,日期不能大于31！\r\n");
                }
                return Birthday;
            }
            catch (Exception objException)
            {
                throw new Exception("获取出生日期出错！\r\n" + objException.Message);
            }
        }

        /// <summary>
        /// 删除在单引号里的字符串值
        /// </summary>
        /// <param name="strSourceStr">源字符串</param>
        /// <returns>删除字符串值后的内容</returns>
        public static string RemoveStringValueInSingleQuotation(string strSourceStr)
        {
            int intPos4FirstQuotation = strSourceStr.IndexOf("'");
            int intPos4SecondQuotation = 0;
            StringBuilder sbTargetStr = new StringBuilder();
            while (true)
            {
                if (intPos4FirstQuotation < 0) break;
                sbTargetStr.Append(strSourceStr.Substring(intPos4SecondQuotation, intPos4FirstQuotation - intPos4SecondQuotation));
                intPos4SecondQuotation = strSourceStr.IndexOf("'", intPos4FirstQuotation + 1);
                if (intPos4SecondQuotation < 0) throw new Exception(string.Format("在条件串：{0}中，单引号不匹配，请检查！", strSourceStr));
                intPos4SecondQuotation++;
                intPos4FirstQuotation = strSourceStr.IndexOf("'", intPos4SecondQuotation);
                if (intPos4FirstQuotation == -1)
                {
                    sbTargetStr.Append(strSourceStr.Substring(intPos4SecondQuotation));
                    break;
                }
            }
            return sbTargetStr.ToString();
        }

        /// <summary>
        /// 获取源字符串的元素值，例如："abcde[ss]111[/ss]", 获取元素"ss"的值，为："111"
        /// </summary>
        /// <param name="strSourceStr">源字符串</param>
        /// <param name="strElementName">元素名</param>
        /// <returns>获取元素值</returns>
        public static string GetElementValue(string strSourceStr, string strElementName)
        {
            string strElementValue;
            int intPos4First = strSourceStr.IndexOf(string.Format("[{0}]", strElementName));
            if (intPos4First >= 0)
            {
                int intPos4FirstEnd = intPos4First + strElementName.Length + 1;// strSourceStr.IndexOf(string.Format("]", strElementName), intPos4First + 1);
                //if (intPos4FirstEnd == -1)
                //{
                //    string strMsg = string.Format("串:{0}中，没有元素：[{1}]", strSourceStr, strElementName);
                //    throw new Exception(strMsg);
                //}
                int intPos4Second = strSourceStr.IndexOf(string.Format("[/{0}]", strElementName), intPos4FirstEnd + 1);
                if (intPos4Second == -1)
                {
                    string strMsg = string.Format("串:{0}中，缺少结束元素标志：[/{1}]", strSourceStr, strElementName);
                    throw new Exception(strMsg);
                }
                strElementValue = strSourceStr.Substring(intPos4FirstEnd + 1, intPos4Second - intPos4FirstEnd - 1);
                return strElementValue;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 从源字符串去除元素值，例如："abcde[ss]111[/ss]44", 去除元素"ss"的值，为："abcde44"
        /// </summary>
        /// <param name="strSourceStr">源字符串</param>
        /// <param name="strElementName">元素名</param>
        /// <returns>获取元素值</returns>
        public static string RemoveElementValue(string strSourceStr, string strElementName)
        {
            StringBuilder sbTargetStr = new StringBuilder();


            int intPos4First = strSourceStr.IndexOf(string.Format("[{0}]", strElementName));
            if (intPos4First < 0) return strSourceStr;
            int intPos4FirstEnd = 0;
            int intPos4Second = 0;
            int intPos4SecordEnd = 0;
            while (true)
            {
                if (intPos4First < 0)
                {
                    sbTargetStr.Append(strSourceStr.Substring(intPos4SecordEnd));
                    break;
                }
                intPos4FirstEnd = intPos4First + strElementName.Length + 1;// strSourceStr.IndexOf(string.Format("]", strElementName), intPos4First + 1);

                sbTargetStr.Append(strSourceStr.Substring(intPos4SecordEnd, intPos4First - intPos4SecordEnd));
                intPos4Second = strSourceStr.IndexOf(string.Format("[/{0}]", strElementName), intPos4FirstEnd + 1);

                if (intPos4Second < 0)
                {
                    string strMsg = string.Format("串:{0}中，缺少结束元素标志：[/{1}]", strSourceStr, strElementName);
                    throw new Exception(strMsg);
                }
                intPos4SecordEnd = intPos4Second + strElementName.Length + 3;
                //intPos4Second++;
                intPos4First = strSourceStr.IndexOf(string.Format("[{0}]", strElementName), intPos4SecordEnd);
            }
            return sbTargetStr.ToString();


        }


        /// <summary>
        /// 随机生成n位字符
        /// </summary>
        /// <returns></returns>
        public static string MakeRandom()
        {
            string randomchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //			int pwdlen=5;
            string tmpstr = "";
            int iRandNum;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                iRandNum = rnd.Next(randomchars.Length);
                tmpstr += randomchars[iRandNum];
            }
            return tmpstr;
        }
        /// <summary>
        /// 随机生成n位字符
        /// </summary>
        /// <param name="intNumOfCharacters">字符数</param>
        /// <param name="intAdditionalSeed">附加种子</param>
        /// <returns>返回n位字符</returns>
        public static string MakeRandom(int intNumOfCharacters, int intAdditionalSeed)
        {
            string randomchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //			int pwdlen=5;
            string tmpstr = "";
            int iRandNum;
            DateTime dbNow = DateTime.Now;
            int intSeed = (int)dbNow.Ticks;
            Random rnd = new Random(intSeed + intAdditionalSeed);
            for (int i = 0; i < intNumOfCharacters; i++)
            {
                iRandNum = rnd.Next(randomchars.Length);
                tmpstr += randomchars[iRandNum];
            }
            return tmpstr;
        }
        /// <summary>
        /// 获得字节块的长度
        /// </summary>
        public static int GetStringLength(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            return bytes.Length;
        }
        /// <summary>
        /// 屏蔽“号
        /// </summary>
        public static string ReplaceBothWord(object strOld)
        {
            return strOld.ToString().Replace("\"", "'");
        }
        /// <summary>
        /// 获得指定字符串的长度字符串
        /// </summary>
        /// <param name="strOld">字符串</param>
        /// <param name="intStart">字符串开始获取的位置，U</param>
        /// <param name="intCount">获得字符的字节数</param>
        /// <param name="bolSign">是否在返回的后面加"..."</param>
        /// <returns>返回指定长度的字符串</returns>
        public static string GetPayStringLength(string strOld, int intStart, int intCount, bool bolSign)
        {
            if (intStart != 0)
            {
                strOld = strOld.Replace(strOld.Substring(0, intStart), "");
            }
            char[] chrSingle = strOld.ToCharArray();
            string strNew = "";
            int intNewCount = 0;
            int intTemp = 0;
            string strNewTemp = "";
            foreach (char chrTemp in chrSingle)
            {
                if (GetStringLength(chrTemp.ToString()) == 1)
                {
                    strNewTemp = strNew;
                    strNew += chrTemp;
                    intNewCount += 1;
                    intTemp = 1;
                }
                else if (GetStringLength(chrTemp.ToString()) == 2)
                {
                    strNewTemp = strNew;
                    strNew += chrTemp;
                    intNewCount += 2;
                    intTemp = 2;
                }
                if (intNewCount > intCount - 1)
                {
                    if (intTemp == 2)
                    {
                        return GetString(strNewTemp, bolSign);
                    }
                    return GetString(strNew, bolSign);
                }
            }
            return GetString(strNew, bolSign);
        }
        /// <summary>
        /// 获取字符串后加省略号
        /// </summary>
        /// <param name="strOld">原字符串</param>
        /// <param name="bolSign"></param>
        /// <returns></returns>
        public static string GetString(string strOld, bool bolSign)
        {
            if (bolSign == true)
            {
                return strOld + "...";
            }
            return strOld;
        }
        /// <summary>
        /// 指定字符串中指定长度的字符串
        /// </summary>
        /// <param name="strOld">原字符串</param>
        /// <param name="strNow">新字符符串</param>
        /// <param name="intCount">获得字符的字节数</param>
        /// <param name="intLength">获取字符串的长度 </param>
        /// <returns>返回指定长度的字符串</returns>
        public static string GetPayStringLength(string strOld, string strNow, int intCount, out int intLength)
        {
            strOld = strOld.Substring(strNow.Length);
            char[] chrSingle = strOld.ToCharArray();
            string strNew = "";
            int intNewCount = 0;
            string strNewTemp = "";
            intLength = 0;
            foreach (char chrTemp in chrSingle)
            {
                if (GetStringLength(chrTemp.ToString()) == 1)
                {
                    strNewTemp = strNew;
                    strNew += chrTemp;
                    intNewCount += 1;
                }
                else if (GetStringLength(chrTemp.ToString()) == 2)
                {
                    strNewTemp = strNew;
                    strNew += chrTemp;
                    intNewCount += 2;
                }
                intLength += 1;
                if (intNewCount > intCount - 1)
                {
                    if (GetStringLength(strNew) - intCount >= 1)
                    {
                        intLength -= 1;
                        return strNewTemp;
                    }
                    return strNew;
                }
            }
            return strNew;
        }
        /// <summary>
        /// 在字符串中指定长度的字符串中加《br》
        /// </summary>
        /// <param name="strBr">字符串</param>
        /// <param name="intSum" >字符串间隔数</param>
        /// <returns>字符串中加《br》</returns>
        public static string getStrBr(string strBr, int intSum)
        {
            int intStrLength = 0;
            string strReulst = String.Empty;
            string strTemp = String.Empty;
            string strTemp1 = String.Empty;
            int intstrBLong = GetStringLength(strBr.ToString());

            for (int i = 0; i <= intstrBLong; i += intSum)
            {
                strTemp1 = GetPayStringLength(strBr, strTemp, intSum, out intStrLength);
                strTemp += strTemp1;
                strReulst += strTemp1 + "<BR>";
            }
            return strReulst.Substring(0, strReulst.Length - 4);
        }
        /// <summary>
        /// 屏蔽“号
        /// </summary>
        public static string GetHostName(string strOld)
        {
            if (strOld.Length <= 2)
            {
                return strOld;
            }
            string strNew = strOld.ToString().Replace("/", "\\").Trim();
            string strTemp = strNew.Substring(2, strNew.Length - 2);
            return "\\\\" + strTemp.Substring(0, strTemp.IndexOf('\\'));
        }
        #region  对指定长度的字符串进行编码（如果长度超出len，则自动会截取）
        /// <summary>
        /// 对指定长度的字符串进行编码（如果长度超出len，则自动会截取）
        /// </summary>
        /// <param name="strSrc">源字符串</param>
        /// <param name="len">长度</param>
        /// <returns></returns>
        public static string GetHtmlFormString(string strSrc, int len)
        {
            string Result = String.Empty;
            //int intlen;
            Result = GetPayStringLength(strSrc, 0, len, false);
            Result = HttpUtility.HtmlEncode(Result);
            return Result.Trim();
        }
        #endregion
        /// <summary>
        /// 把集合合并起来
        /// </summary>
        /// <param name="aryBefore">前一个集合</param>
        /// <param name="aryEnd">后一个集合</param>
        /// <returns></returns>
        public static ArrayList CombineArrayList(ArrayList aryBefore, ArrayList aryEnd)
        {
            ArrayList aryResult = new ArrayList();
            try
            {
                if (aryBefore.Count > 0 && aryEnd.Count > 0)
                {
                    for (int i = 0; i < aryEnd.Count; i++)
                    {
                        aryBefore.Add(aryEnd[i].ToString());
                    }
                    aryResult = aryBefore;
                }
                else if (aryBefore.Count == 0)
                {
                    aryResult = aryEnd;
                }
                else if (aryEnd.Count == 0)
                {
                    aryResult = aryBefore;
                }
            }
            catch
            {
                aryResult = null;
            }
            return aryResult;
        }
        /// <summary>
        /// 把集合合并起来
        /// </summary>
        /// <param name="aryBefore">前一个集合</param>
        /// <param name="aryEnd">后一个集合</param>
        /// <returns></returns>
        public static List<string> CombineArrayList(List<string> aryBefore, List<string> aryEnd)
        {
            List<string> aryResult = new List<string>();
            try
            {
                if (aryBefore.Count > 0 && aryEnd.Count > 0)
                {
                    for (int i = 0; i < aryEnd.Count; i++)
                    {
                        aryBefore.Add(aryEnd[i].ToString());
                    }
                    aryResult = aryBefore;
                }
                else if (aryBefore.Count == 0)
                {
                    aryResult = aryEnd;
                }
                else if (aryEnd.Count == 0)
                {
                    aryResult = aryBefore;
                }
            }
            catch
            {
                aryResult = null;
            }
            return aryResult;
        }


        /// <summary>
        /// 转换字符的格式
        /// </summary>
        /// <param name="SourceDateTime"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static string ConvertDateTimeFormate(string SourceDateTime, int Type)
        {
            string result = SourceDateTime;

            if (Type == 0)
            {
                result = InsertSignOnfixationLengthOfstring(SourceDateTime, "-", 2);
            }
            else if (Type == 1)
            {
                SourceDateTime = SourceDateTime.Trim().Length < 6 ? SourceDateTime.Trim() + "00" : SourceDateTime;
                result = InsertSignOnfixationLengthOfstring(SourceDateTime, ":", 2);
            }
            return result;
        }
        /// <summary>
        /// 要转换的字符串
        /// </summary>
        /// <param name="DataofDateTime">源字符串</param>
        /// <param name="sign">符号 EG:“-”</param>
        /// <param name="length">子串的长度</param>
        /// <returns></returns>
        private static string InsertSignOnfixationLengthOfstring(string DataofDateTime, string sign, int length)
        {
            string Temp = DataofDateTime;
            string result = String.Empty;
            if (DataofDateTime != "")
            {
                for (int i = length; i <= DataofDateTime.Length; i = i + 3)
                    Temp = Temp.Insert(i, sign);
            }
            return Temp;
        }
        /// <summary>
        /// HTML编码
        /// </summary>
        /// <param name="txtstr">源串</param>
        /// <returns>生成不能进行HTML解释的字符串</returns>
        public static string HtmlEncode(string txtstr)
        {
            if (!String.IsNullOrEmpty(txtstr.Trim()))
            {
                txtstr = txtstr.Replace(">", "&gt;");
                txtstr = txtstr.Replace("<", "&lt;");
                txtstr = txtstr.Replace(" ", "&nbsp;");
                txtstr = txtstr.Replace("\"", "&quot;");
                txtstr = txtstr.Replace("\r\n", "<br>");
            }
            return txtstr;
        }
        /// <summary>
        /// Html代码的解码
        /// </summary>
        /// <param name="txtstr">源串</param>
        /// <returns>生成可以解释的HTML代码</returns>
        public static string HtmlDecode(string txtstr)
        {
            if (!String.IsNullOrEmpty(txtstr.Trim()))
            {

                txtstr = txtstr.Replace("&gt;", ">");
                txtstr = txtstr.Replace("&lt;", "<");
                txtstr = txtstr.Replace("&nbsp;", " ");
                txtstr = txtstr.Replace("&quot;", "\"");
                txtstr = txtstr.Replace("<br>", "\r\n");
            }
            return txtstr;
        }
        /// <summary>
        /// 过滤特殊的字符
        /// </summary>
        /// <param name="SourceData">源字符串</param>
        /// <returns></returns>
        public static string FilterSpecilizeString(string SourceData)
        {
            //string[] temp = null;
            string result = String.Empty; ;
            if (!String.IsNullOrEmpty(SourceData))
            {
                result = SourceData.Replace("-", "");
                result = result.Replace("@", "");
                result = result.Replace("~", "");
                result = result.Replace("!", "");
                result = result.Replace("#", "");
                result = result.Replace("$", "");
                result = result.Replace("%", "");
                result = result.Replace("^", "");
                result = result.Replace("&", "");
                result = result.Replace("*", "");
                result = result.Replace("\"", "");
                result = result.Replace("\'", "");
                result = result.Replace("\\", "");
                result = result.Replace("\\\\", "");
                result = result.Replace(";", "");
            }
            return result;
        }
        /// <summary>
        /// 把二进制字符串转换成相应的二进制数组
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static  byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        /// <summary>
        /// 把二进制数组转换成字符串
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }
        /// <summary>
        /// 把一段字符串分成一个个单词
        /// </summary>
        /// <param name="strSourceString"></param>
        /// <returns>单词列表</returns>
        public static List<string> SplitWord(string strSourceString)
        {
            List<string> lstWord = new List<string>();
            List<int> lstSplitPos = new List<int>();
            if (strSourceString.Length == 0) return lstWord;
            int intLen = strSourceString.Length;
            string strLastLetter = " ";
            lstSplitPos.Add(0);
            for (int i = 0; i < intLen; i++)
            {
                string strCurrLetter = strSourceString.Substring(i, 1);
                if (IsSplitChar(strLastLetter) == true && IsSplitChar(strCurrLetter) == false)
                {
                    lstSplitPos.Add(i);
                }
                else if (IsSplitChar(strLastLetter) == true && IsSplitChar(strCurrLetter) == true)
                {
                    if (strLastLetter == " " && strCurrLetter == " ")
                    {
                    }
                    else
                    {
                        lstSplitPos.Add(i);
                    }
                }
                else if (IsSplitChar(strCurrLetter) == true && strCurrLetter != " ")
                {
                     lstSplitPos.Add(i);
                }
                strLastLetter = strCurrLetter;
            }
            if (IsSplitChar(strLastLetter) == true)
            {
                lstSplitPos.Add(intLen - 1);
            }
            lstSplitPos.Add(intLen);

            int intCount4Pos = lstSplitPos.Count;
            int intLastPos = lstSplitPos[0];
            for(int i = 1; i<intCount4Pos; i++)
            {
                int intCurrPos = lstSplitPos[i];
                string strWord = strSourceString.Substring(intLastPos, intCurrPos - intLastPos);
                string strWord_Trim = strWord.Trim();
                if (strWord.Length>strWord_Trim.Length)
                {
                    strWord_Trim += " ";
                }
                if (strWord_Trim == " ")
                {
                    lstWord.Add(strWord_Trim);
                }
                else if (string.IsNullOrEmpty(strWord_Trim.Trim() ) == false)
                {
                    lstWord.Add(strWord_Trim);
                }
                intLastPos = intCurrPos;
            }
            return lstWord;
        }
        /// <summary>
        /// 判断字符是否是分隔符
        /// </summary>
        /// <param name="strChar"></param>
        /// <returns>是返回true, 否则返回false</returns>
        public static bool IsSplitChar(string strChar)
        {
            switch (strChar)
            {
                case " ":
                    return true;
                case ",":
                case ".":
                case ";":
                case "?":
                case "!":
                case "|":
                case "+":
                case "-":
                case "=":
                case "/":
                case "(":
                case ")":
                case "<":
                case ">":

                    return true;
                default:
                    return false;

            }
        }
        /// <summary>
        /// 把字符串列表 组合成一个字符串
        /// </summary>
        /// <param name="lstWord">字符串列表</param>
        /// <returns>组合成的一个字符串</returns>
        public static string CombineListToString(List<string> lstWord)
        {
            StringBuilder sbCombineStr = new StringBuilder();
            foreach(string strWord in lstWord)
            {
                sbCombineStr.Append(strWord);
            }
            return sbCombineStr.ToString();
        }
        /// <summary>
        /// 把文本格式，转换为HTML编码格式
        /// </summary>
        /// <param name="txtstr">源串</param>
        /// <returns>生成不能进行HTML解释的字符串</returns>
        public static string getHtmlEncodeFromTextCode(string txtstr)
        {
            if (!String.IsNullOrEmpty(txtstr.Trim()))
            {
                txtstr = txtstr.Replace(">", "&gt;");
                txtstr = txtstr.Replace("<", "&lt;");
                txtstr = txtstr.Replace(" ", "&nbsp;");
                txtstr = txtstr.Replace("\"", "&quot;");
                txtstr = txtstr.Replace("\r\n", "<br/>");
            }
            return txtstr;
        }
    }
}