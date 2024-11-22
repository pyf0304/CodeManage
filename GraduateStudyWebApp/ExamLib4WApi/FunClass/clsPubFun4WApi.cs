
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

using com.taishsoft.common;
using com.taishsoft.file;

namespace ExamLib4WApi
{
    /// <summary>
    /// 针对转换类的公共类函数
    /// </summary>
    public class clsPubFun4WApi
    {
        
        /// <summary>
        /// 获取Web服务的地址
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetServiceUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        public static string GetWebApiUrl(string strApiControllerName, string strAction)
        {
            String strServiceUrl = String.Empty;

            if (clsSysPara4WebApi.bolIsLocalHost == false)
            {

                strServiceUrl = String.Format("http://{0}/{1}/api/{2}/{3}",
                    clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strApiControllerName, strAction);

            }
            else
            {
                strServiceUrl = String.Format("http://{0}/api/{1}/{2}",
                    clsSysPara4WebApi.strCurrIPAddressAndPort_Local,
                    strApiControllerName, strAction);

            }
            return strServiceUrl;
        }




        /// <summary>
        /// 生成最终URL
        /// </summary>
        /// <param name="strApiControllerName">基准URL（不含查询串）</param>
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <returns>最终URL</returns>
        public static string GetLastUrl(string strApiControllerName, string strAction, Dictionary<string, string> dictParam)
        {
            //string baseUrl = GetServiceUrl();
            string strWebApiUrl = GetWebApiUrl(strApiControllerName, strAction);
            var sbUrl = new StringBuilder(strWebApiUrl);
            if (dictParam != null && dictParam.Count > 0)
            {
                sbUrl.Append("?");
                int index = 0;
                foreach (var item in dictParam)
                {
                    sbUrl.Append(string.Format("{0}={1}", item.Key,
                        HttpUtility.UrlEncode(item.Value, Encoding.UTF8)));
                    if (index < dictParam.Count - 1)
                    {
                        sbUrl.Append("&");
                    }
                    index++;
                }
            }
            var url = sbUrl.ToString();
            return url;
        }


        /// <summary>
        /// 生成最终URL
        /// </summary>
        /// <param name="strApiControllerName">基准URL（不含查询串）</param>
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <returns>最终URL</returns>
        public static string GetLastUrl4Delete(string strApiControllerName, string strAction, string id)
        {
            //string baseUrl = GetServiceUrl();
            string strWebApiUrl = GetWebApiUrl(strApiControllerName, strAction);
            var sbUrl = new StringBuilder(strWebApiUrl);
            if (string.IsNullOrEmpty(id) == false)
            {
                sbUrl.AppendFormat("/{0}", id);
            }
            else
            {
                throw new Exception("删除WebApi时id不能为空！");
            }
            var url = sbUrl.ToString();
            return url;
        }
        /// <summary>
        /// GET方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>        
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Get(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var tmpResult = client.GetAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {              
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Get)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Get)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);               
                }
            }

        }

        /// <summary>
        /// GET方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Get4WebApi(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var tmpResult = client.GetAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Get)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Get)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);                    
                }
            }

        }

        /// <summary>
        /// GET方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool GetObjLst4WebApi(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var tmpResult = client.GetAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Get)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Get)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);                  
                }
            }

        }

        /// <summary>
        /// POST方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Post(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            var url = GetLastUrl(strApiControllerName, strAction, dictParam);
            StringContent content = null;
      
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
               
                    content = new StringContent(parseData, Encoding.UTF8);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var tmpResult = client.PostAsync(url, content).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Post)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Post)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);                  
                }
              
            }
        }

        /// <summary>
        /// POST方式调用Web Api
        /// </summary>
        /// <param name="baseUrl">基准URL（不含查询串）</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        //public static bool Post(string baseUrl, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg)
        //{
        //    errMsg = string.Empty;
        //    result = string.Empty;
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            var url = GetLastUrl(baseUrl, dictParam);
        //            var content = new StringContent(parseData, Encoding.UTF8);
        //            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //            var tmpResult = client.PostAsJsonAsync(url, content).Result;
        //            tmpResult.EnsureSuccessStatusCode();
        //            result = tmpResult.Content.ReadAsStringAsync().Result;
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        errMsg = ex.Message;
        //        return false;
        //    }
        //}

        /// <summary>
        /// Put方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Put(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var content = new StringContent(parseData, Encoding.UTF8);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var tmpResult = client.PutAsync(url, content).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
            
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Put)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Put)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }

            }
        }


        /// <summary>
        /// POST方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Deletes(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var content = new StringContent(parseData, Encoding.UTF8);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var tmpResult = client.PostAsync(url, content).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
            
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Post)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Post)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }

            }
        }

        /// <summary>
        /// Delete方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Delete(string strApiControllerName, string strAction, string id, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl4Delete(strApiControllerName, strAction, id);
                    var tmpResult = client.DeleteAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {               
                string strMsg = "";
                string strUrl = GetLastUrl4Delete(strApiControllerName, strAction, id);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Delete)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Delete)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }

            }
        }

      
     
        public static bool WriteLogFile(string strLogFName, string strLogContent, Encoding myEncoding)
        {
            string strFolder = clsString.ParentDir_S(strLogFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            clsFile.CreateFileByString(strLogFName, strLogContent, myEncoding);
            return true;
        }
    }
}
