using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace com.taishsoft.json
{
    /// <summary>
    /// 专门用于处理C#的类对象与JSON之间的转换问题
    /// </summary>
    public class clsJSON
    {
        /// <summary>
        /// 把一般对象转换成JSON串
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="t">对象</param>
        /// <returns>生成的JSON串</returns>
        public static string GetJsonFromObj<T>(T t)
        {
            DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            ds.WriteObject(ms, t);

            string strReturn = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return strReturn;
        }

        /// <summary>
        /// 把一般对象转换成JSON串
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="arrObjLst">对象列表</param>
        /// <returns>生成的JSON串</returns>
        public static string GetJsonFromObjLst<T>(List<T> arrObjLst)
        {
            DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(List<T>));
            MemoryStream ms = new MemoryStream();
            try
            {
                ds.WriteObject(ms, arrObjLst);
            }
            catch(Exception objException)
            {
                throw objException;
            }

            string strReturn = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return strReturn;
        }
        //write object 写 object 2 json

        /// <summary>
        /// 把一般对象转换成JSON串--2
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="t">对象</param>
        /// <returns>生成的JSON串</returns>
        public static string GetJsonFromObj2<T>(T t)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, t);
            String result = Encoding.UTF8.GetString(stream.ToArray());
            return result;
        }

        //read object 读取 json 2 object


        /// <summary>
        /// 根据JSON串生成相应的对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="strJson">JSON串</param>
        /// <returns>生成的相应的对象</returns>
        public static T GetObjFromJson<T>(string strJson) where T : class
        {
            DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(strJson));
            return ds.ReadObject(ms) as T;
        }
        /// <summary>
        /// 根据JSON串生成相应的对象列表
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="strJson">JSON串</param>
        /// <returns>生成的相应的对象列表</returns>
        public static List<T> GetObjLstFromJson<T>(string strJson) where T : class
        {
            DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(List<T>));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(strJson));
            return ds.ReadObject(ms) as List<T>;
        }

        /// <summary>
        /// 获取测试代码
        /// </summary>
        /// <returns></returns>
        public static string GetTestCode()
        {
            StringBuilder sbCode = new StringBuilder();
            sbCode.Append("\r\n[Serializable]");
            sbCode.Append("\r\n[DataContractAttribute]");
            sbCode.Append("\r\npublic class User");
            sbCode.Append("\r\n{");
            sbCode.Append("\r\nprivate int id;");
            sbCode.Append("\r\nprivate String password;");
            sbCode.Append("\r\nprivate String name;");

            sbCode.Append("\r\npublic User(int id, String name, String password)");
            sbCode.Append("\r\n{");
            sbCode.Append("\r\nthis.id = id;");
            sbCode.Append("\r\nthis.password = password;");
            sbCode.Append("\r\nthis.name = name;");
            sbCode.Append("\r\n}");
            sbCode.Append("\r\n[DataMember]//非常重要");
            sbCode.Append("\r\npublic int Id");
            sbCode.Append("\r\n{");
            sbCode.Append("\r\nget { return id; }");
            sbCode.Append("\r\nset { id = value; }");
            sbCode.Append("\r\n}");
            sbCode.Append("\r\n[DataMember]//非常重要");
            sbCode.Append("\r\npublic String Name");
            sbCode.Append("\r\n{");
            sbCode.Append("\r\nget { return name; }");
            sbCode.Append("\r\nset { name = value; }");
            sbCode.Append("\r\n}");
            sbCode.Append("\r\n[DataMember]//非常重要");
            sbCode.Append("\r\npublic String Password");
            sbCode.Append("\r\n{");
            sbCode.Append("\r\nget { return password; }");
            sbCode.Append("\r\nset { password = value; }");
            sbCode.Append("\r\n}");
            sbCode.Append("\r\n}");

            sbCode.Append("\r\n protected void Button1_Click(object sender, EventArgs e)");
            sbCode.Append("\r\n {");
            sbCode.Append("\r\n  User u = new User(1, \"EE\", \"123\");");
            sbCode.Append("\r\n  lblResult.Text = clsJSON.GetJsonFromObj2<User>(u);");
            //lblResult.Text = clsJSON.DataContractJsonSerialize<User>(u);
            sbCode.Append("\r\n  User objUser = clsJSON.GetObjFromJson<User>(lblResult.Text);");
            sbCode.Append("\r\n lblResult2.Text = clsJSON.GetJsonFromObj2<User>(objUser);");
            //Console.WriteLine(ToJson2<User>(u));
            //Console.ReadLine();
            sbCode.Append("\r\n  }");

            sbCode.Append("\r\n  protected void Button2_Click(object sender, EventArgs e)");
            sbCode.Append("\r\n {");
            sbCode.Append("\r\n     User u1 = new User(1, \"EE\", \"123\");");
            sbCode.Append("\r\n    User u2 = new User(2, \"EE2\", \"1223\");");
            sbCode.Append("\r\n    List<User> arrUserObjLst = new List<MyJSON.User>();");
            sbCode.Append("\r\n   arrUserObjLst.Add(u1);");
            sbCode.Append("\r\n   arrUserObjLst.Add(u2);");

            sbCode.Append("\r\n   lblResult.Text = clsJSON.GetJsonFromObjLst<User>(arrUserObjLst);");
            sbCode.Append("\r\n  List<User> arrUserObjLst2 = clsJSON.GetObjLstFromJson<User>(lblResult.Text);");
            sbCode.Append("\r\n  lblResult2.Text = clsJSON.GetJsonFromObjLst<User>(arrUserObjLst2);");

            sbCode.Append("\r\n }");
            return sbCode.ToString();
        }
        #region DataContractJsonSerializer

        ///// <summary>
        ///// 对象转换成json
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="jsonObject">需要格式化的对象</param>
        ///// <returns>Json字符串</returns>
        //public static string DataContractJsonSerialize<T>(T jsonObject)
        //{
        //    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
        //    string json = null;
        //    using (MemoryStream ms = new MemoryStream()) //定义一个stream用来存发序列化之后的内容
        //    {
        //        serializer.WriteObject(ms, jsonObject);
        //        json = Encoding.UTF8.GetString(ms.GetBuffer()); //将stream读取成一个字符串形式的数据，并且返回
        //        ms.Close();
        //    }
        //    return json;
        //}

        ///// <summary>
        ///// json字符串转换成对象
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="json">要转换成对象的json字符串</param>
        ///// <returns></returns>
        //public static T DataContractJsonDeserialize<T>(string json)
        //{
        //    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
        //    T obj = default(T);
        //    using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        //    {
        //        obj = (T)serializer.ReadObject(ms);
        //        ms.Close();
        //    }
        //    return obj;
        //}
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    User u = new User(1, "EE", "123");
        //    lblResult.Text = ToJson2<User>(u);
        //    //Console.WriteLine(ToJson2<User>(u));
        //    //Console.ReadLine();
        //}
        #endregion

    }
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class User
    {
        private int id;
        private String password;
        private String name;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public User(int id, String name, String password)
        {
            this.id = id;
            this.password = password;
            this.name = name;
        }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]//非常重要
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]//非常重要
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]//非常重要
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}