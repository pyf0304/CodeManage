using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using com.taishsoft.common;
using System.Collections;
using com.taishsoft.comm_db_obj;

namespace com.taishsoft.encrypt
{
    public class clsEncrypt
    {
        //直接设置密钥
        //直接设置密钥
        //char[] key1 =       "1093jchmskdjjlsjdfkjuysnfkdiw;xk".ToCharArray();     
        private char[] key1 = "taishsoft_pyf_qrx_wzr_lf_yhb_123".ToCharArray();//加密的密要
        //char[] iv1 =       "asdfghjkasdfghjk".ToCharArray();
        private char[] iv1 = "zy_zgh_fwz_09876".ToCharArray();                  //加密的密要的偏移向量

        /// <summary>
        /// 对xml文件进行加密
        /// </summary>
        /// <param name="Doc">xml文件名</param>
        /// <param name="ElementName">所要加密节点名</param>
        /// <param name="Key">密钥</param>
        public void EncryptXmlDoc(XmlElement elementToEncrypt)
        {
            // Check the arguments.  
            //if (Doc == null)
            //    throw new ArgumentNullException("无法找到xml文件");
            //if (ElementName == null)
            //    throw new ArgumentNullException("无法找到需要加密的元素");

            //在xml文件中找到要加密的数据节点并实例化
            //XmlElement elementToEncrypt = Doc.GetElementsByTagName(ElementName)[2] as XmlElement;

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //建立新密钥 设置密钥
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;
            if (elementToEncrypt == null)
            {
                throw new XmlException("具体算法是不支持xml加密");
            }


            //创建一个新的EncryptedXml对象，存放使用密钥已加密的数据
            EncryptedXml eXml = new EncryptedXml();

            byte[] encryptedElement = eXml.EncryptData(elementToEncrypt, Key, false);

            EncryptedData edElement = new EncryptedData();
            edElement.Type = EncryptedXml.XmlEncElementUrl;

            // Create an EncryptionMethod element so that the 
            // receiver knows which algorithm to use for decryption.
            // Determine what kind of algorithm is being used and
            // supply the appropriate URL to the EncryptionMethod element.

            string encryptionMethod = null;

            if (Key is TripleDES)
            {
                encryptionMethod = EncryptedXml.XmlEncTripleDESUrl;
            }
            else if (Key is DES)
            {
                encryptionMethod = EncryptedXml.XmlEncDESUrl;
            }
            if (Key is Rijndael)
            {
                switch (Key.KeySize)
                {
                    case 128:
                        encryptionMethod = EncryptedXml.XmlEncAES128Url;
                        break;
                    case 192:
                        encryptionMethod = EncryptedXml.XmlEncAES192Url;
                        break;
                    case 256:
                        encryptionMethod = EncryptedXml.XmlEncAES256Url;
                        break;
                }
            }
            else
            {
                //如果算法不支持xml加密则抛出异常
                throw new CryptographicException("具体算法是不支持xml加密.");
            }

            edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);


            //在EncryptedData对象中添加已加密的元素数据
            edElement.CipherData.CipherValue = encryptedElement;

            ////////////////////////////////////////////////////
            //将已加密的元素数据替换原元素数据
            ////////////////////////////////////////////////////
            EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);
        }
        /// <summary>
        /// 到XML文档中查找某个结点
        /// </summary>
        /// <param name="xmldoc"></param>
        /// <param name="strNodeName"></param>
        /// <returns></returns>
        public ArrayList getXmlElementEx(XmlDocument xmldoc, string strNodeName)
        {
            ArrayList arrXmlElementLst = new ArrayList();
            string[] strNode = strNodeName.Split("/".ToCharArray());
            XmlNodeList elemList = null;
            if (string.IsNullOrEmpty(strNodeName) == true)
            {
                throw new Exception("Xml结点不能为空！");
            }
            if (strNode.Length == 0)
            {
                throw new Exception("Xml结点不能为空！");
            }
            else if (strNode.Length == 1)
            {
                elemList = xmldoc.GetElementsByTagName(strNode[0]);
            }
            else
            {
                elemList = xmldoc.GetElementsByTagName(strNode[0]);

                for (int iElemList = 0; iElemList < elemList.Count; iElemList++)
                {
                    Console.WriteLine(elemList[iElemList].InnerXml);

                    for (int i = 0; i < elemList[iElemList].ChildNodes.Count; i++)
                    {
                        string strNodeTypeStr = elemList[iElemList].ChildNodes[i].GetType().ToString();
                        if (strNodeTypeStr == "System.Xml.XmlWhitespace")
                            continue;
                        if (strNodeTypeStr == "System.Xml.XmlElement")
                        {
                            XmlElement xmlelem1 = elemList[iElemList].ChildNodes[i] as XmlElement;
                            if (xmlelem1.Name == strNode[1])
                            {
                                arrXmlElementLst.Add(xmlelem1);
                                //                            return xmlelem1;
                            }
                        }
                    }
                }
                //throw new Exception(string.Format("在{0}中没有{1}", xmldoc.Name, strNodeName));
            }
            return arrXmlElementLst;
        }

        /// <summary>
        /// 到XML文档中查找某个结点
        /// </summary>
        /// <param name="xmldoc"></param>
        /// <param name="strNodeName"></param>
        /// <returns></returns>
        public XmlElement getXmlElement(XmlDocument xmldoc, string strNodeName)
        {
            //ArrayList arrXmlElementLst = new ArrayList();
            string[] strNode = strNodeName.Split("/".ToCharArray());
            XmlNodeList elemList = null;
            if (string.IsNullOrEmpty(strNodeName) == true)
            {
                throw new Exception("Xml结点不能为空！");
            }
            if (strNode.Length == 0)
            {
                throw new Exception("Xml结点不能为空！");
            }
            else if (strNode.Length == 1)
            {
                elemList = xmldoc.GetElementsByTagName(strNode[0]);
            }
            else
            {
                elemList = xmldoc.GetElementsByTagName(strNode[0]);

                for (int iElemList = 0; iElemList < elemList.Count; iElemList++)
                {
                    Console.WriteLine(elemList[iElemList].InnerXml);
                }
                for (int i = 0; i < elemList[0].ChildNodes.Count; i++)
                {
                    string strNodeTypeStr = elemList[0].ChildNodes[i].GetType().ToString();
                    if (strNodeTypeStr == "System.Xml.XmlWhitespace")
                        continue;
                    if (strNodeTypeStr == "System.Xml.XmlElement")
                    {
                        XmlElement xmlelem1 = elemList[0].ChildNodes[i] as XmlElement;
                        if (xmlelem1.Name == strNode[1])
                        {
                            //arrXmlElementLst.Add(xmlelem1);
                            return xmlelem1;
                        }
                    }
                }
                
                throw new Exception(string.Format("在{0}中没有{1}", xmldoc.Name, strNodeName));
            }
            return null;
        }
        /// <summary>
        /// 对xml文件进行加密
        /// </summary>
        /// <param name="strXmlDocName">xml文件名</param>
        /// <param name="strNodeName">所要加密节点名</param>
        /// <returns></returns>
        public string EncryptXmlDoc(string strXmlDocName, string strNodeName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);

            XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            if (elementToEncrypt == null)
            {
                throw new Exception(string.Format("在{0}中没有{1}", strXmlDocName, strNodeName));
            }
            // Check the arguments.  

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //建立新密钥 设置密钥
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;
            //创建一个新的EncryptedXml对象，存放使用密钥已加密的数据
            EncryptedXml eXml = new EncryptedXml();

            byte[] encryptedElement = eXml.EncryptData(elementToEncrypt, Key, false);

            EncryptedData edElement = new EncryptedData();
            edElement.Type = EncryptedXml.XmlEncElementUrl;

            // Create an EncryptionMethod element so that the 
            // receiver knows which algorithm to use for decryption.
            // Determine what kind of algorithm is being used and
            // supply the appropriate URL to the EncryptionMethod element.

            string encryptionMethod = null;

            if (Key is TripleDES)
            {
                encryptionMethod = EncryptedXml.XmlEncTripleDESUrl;
            }
            else if (Key is DES)
            {
                encryptionMethod = EncryptedXml.XmlEncDESUrl;
            }
            if (Key is Rijndael)
            {
                switch (Key.KeySize)
                {
                    case 128:
                        encryptionMethod = EncryptedXml.XmlEncAES128Url;
                        break;
                    case 192:
                        encryptionMethod = EncryptedXml.XmlEncAES192Url;
                        break;
                    case 256:
                        encryptionMethod = EncryptedXml.XmlEncAES256Url;
                        break;
                }
            }
            else
            {
                //如果算法不支持xml加密则抛出异常
                throw new CryptographicException("具体算法是不支持xml加密.");
            }

            edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);


            //在EncryptedData对象中添加已加密的元素数据
            edElement.CipherData.CipherValue = encryptedElement;

            ////////////////////////////////////////////////////
            //将已加密的元素数据替换原元素数据
            ////////////////////////////////////////////////////
            EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);
            string strFolderName = clsString.GetDirName_S(strXmlDocName);
            string strSimFileName = clsString.GetSimpleFName_S(strXmlDocName);
            string strSimFileNameWithoutExeName = clsString.GetPureFileName(strSimFileName);
            string strExeName = clsString.GetFileExtName(strXmlDocName);
            string strNewFileName = "";
            if (string.IsNullOrEmpty( strFolderName )==true)
            {
                strNewFileName = strSimFileNameWithoutExeName + "4EnCrypt." + strExeName;
            }
            else
            {
              strNewFileName =   strFolderName + "\\" + strSimFileNameWithoutExeName + "4EnCrypt." + strExeName;
            }
            xmldoc.Save(strNewFileName);
            return strNewFileName;
        }

        /// <summary>
        /// 对xml文件进行加密
        /// </summary>
        /// <param name="strXmlDocName">xml文件名</param>
        /// <param name="strNodeName">所要加密节点名</param>
        /// <returns></returns>
        public string EncryptXmlDocEx(string strXmlDocName, string strNodeName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);

            //XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            ArrayList arrXmlElementLst = getXmlElementEx(xmldoc, strNodeName);
            if (arrXmlElementLst.Count == 0)
            {
                throw new Exception(string.Format("在{0}中没有{1}", strXmlDocName, strNodeName));
            }
            // Check the arguments.  
            foreach (XmlElement elementToEncrypt in arrXmlElementLst)
            {
                byte[] key = Encoding.UTF8.GetBytes(key1);
                byte[] iv = Encoding.UTF8.GetBytes(iv1);

                //建立新密钥 设置密钥
                RijndaelManaged Rijnd = null;
                Rijnd = new RijndaelManaged();

                Rijnd.Key = key;
                Rijnd.IV = iv;


                SymmetricAlgorithm Key = Rijnd;
                //创建一个新的EncryptedXml对象，存放使用密钥已加密的数据
                EncryptedXml eXml = new EncryptedXml();

                byte[] encryptedElement = eXml.EncryptData(elementToEncrypt, Key, false);

                EncryptedData edElement = new EncryptedData();
                edElement.Type = EncryptedXml.XmlEncElementUrl;

                // Create an EncryptionMethod element so that the 
                // receiver knows which algorithm to use for decryption.
                // Determine what kind of algorithm is being used and
                // supply the appropriate URL to the EncryptionMethod element.

                string encryptionMethod = null;

                if (Key is TripleDES)
                {
                    encryptionMethod = EncryptedXml.XmlEncTripleDESUrl;
                }
                else if (Key is DES)
                {
                    encryptionMethod = EncryptedXml.XmlEncDESUrl;
                }
                if (Key is Rijndael)
                {
                    switch (Key.KeySize)
                    {
                        case 128:
                            encryptionMethod = EncryptedXml.XmlEncAES128Url;
                            break;
                        case 192:
                            encryptionMethod = EncryptedXml.XmlEncAES192Url;
                            break;
                        case 256:
                            encryptionMethod = EncryptedXml.XmlEncAES256Url;
                            break;
                    }
                }
                else
                {
                    //如果算法不支持xml加密则抛出异常
                    throw new CryptographicException("具体算法是不支持xml加密.");
                }

                edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);


                //在EncryptedData对象中添加已加密的元素数据
                edElement.CipherData.CipherValue = encryptedElement;

                ////////////////////////////////////////////////////
                //将已加密的元素数据替换原元素数据
                ////////////////////////////////////////////////////
                EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);
            }
            string strFolderName = clsString.GetDirName_S(strXmlDocName);
            string strSimFileName = clsString.GetSimpleFName_S(strXmlDocName);
            string strSimFileNameWithoutExeName = clsString.GetPureFileName(strSimFileName);
            string strExeName = clsString.GetFileExtName(strXmlDocName);
            string strNewFileName = "";
            if (string.IsNullOrEmpty(strFolderName) == true)
            {
                strNewFileName = strSimFileNameWithoutExeName + "4EnCrypt." + strExeName;
            }
            else
            {
                strNewFileName = strFolderName + "\\" + strSimFileNameWithoutExeName + "4EnCrypt." + strExeName;
            }
            xmldoc.Save(strNewFileName);
            return strNewFileName;
        }

        /// <summary>
        /// 对xml文件进行解密
        /// </summary>
        /// <param name="strXmlDocName">xml文件名</param>
        /// <param name="strNodeName">所要加密节点名</param>
        /// <returns></returns>
        public string DecryptXmlDoc(string strXmlDocName, string strNodeName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);

            //XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            //if (elementToEncrypt == null)
            //{
            //    throw new Exception(string.Format("在{0}中没有{1}", strXmlDocName, strNodeName));
            //}
            // Check the arguments.  

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //建立新密钥 设置密钥
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;


            // 在xml文件中找到要解密的数据元素.
            XmlElement encryptedElement = xmldoc.GetElementsByTagName("EncryptedData")[0] as XmlElement;

            //如果找不到EncryptedData元素则抛出异常
            if (encryptedElement == null)
            {
                throw new XmlException(string.Format( "在文件{0}中，加密数据节点元素未找到.", strXmlDocName));
            }


            //创建EncryptedData对象并加载xml数据
            EncryptedData edElement = new EncryptedData();
            edElement.LoadXml(encryptedElement);

            //创建一个新EncryptedXml对象
            EncryptedXml exml = new EncryptedXml();


            //使用密钥来解密数据
            byte[] rgbOutput = exml.DecryptData(edElement, Key);

            //使用已解密的元素数据替换原元素数据
            exml.ReplaceData(encryptedElement, rgbOutput);
            //string strConnectString = encryptedElement.Attributes["connectionString"].Value;
            //EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);
            string strFolderName = clsString.GetDirName_S(strXmlDocName);
            string strSimFileName = clsString.GetSimpleFName_S(strXmlDocName);
            string strSimFileNameWithoutExeName = clsString.GetPureFileName(strSimFileName);
            string strExeName = clsString.GetFileExtName(strSimFileName);
            string strNewFileName = "";
            if (string.IsNullOrEmpty(strFolderName) == true)
            {
                strNewFileName = strSimFileNameWithoutExeName + "4DeCrypt." + strExeName;
            }
            else
            {
                strNewFileName = strFolderName + "\\" + strSimFileNameWithoutExeName + "4DeCrypt." + strExeName;
            }
            xmldoc.Save(strNewFileName);
            return strNewFileName;
        }

        /// <summary>
        /// 对xml文件进行解密
        /// </summary>
        /// <param name="strXmlDocName">xml文件名</param>
        /// <param name="strNodeName">所要加密节点名</param>
          /// <returns></returns>
        public string GetConnectStringForEncrypt(string strXmlDocName, string strNodeName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);

            //XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            //if (elementToEncrypt == null)
            //{
            //    throw new Exception(string.Format("在{0}中没有{1}", strXmlDocName, strNodeName));
            //}
            // Check the arguments.  

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //建立新密钥 设置密钥
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;


            // 在xml文件中找到要解密的数据元素.
            XmlElement encryptedElement = xmldoc.GetElementsByTagName("EncryptedData")[0] as XmlElement;

            //如果找不到EncryptedData元素则抛出异常
            if (encryptedElement == null)
            {
                throw new XmlException(string.Format("在文件{0}中，加密数据节点元素未找到.", strXmlDocName));
            }


            //创建EncryptedData对象并加载xml数据
            EncryptedData edElement = new EncryptedData();
            edElement.LoadXml(encryptedElement);

            //创建一个新EncryptedXml对象
            EncryptedXml exml = new EncryptedXml();


            //使用密钥来解密数据
            byte[] rgbOutput = exml.DecryptData(edElement, Key);

            //使用已解密的元素数据替换原元素数据
            exml.ReplaceData(encryptedElement, rgbOutput);
            XmlElement xmlElement = getXmlElement(xmldoc, strNodeName);
            //if (xmlElement == null)
            //{
            //    throw new Exception(string.Format("在{0}中没有{1}", xmldoc.Name, strNodeName));
            //}
            string strConnectString = xmlElement.Attributes["connectionString"].Value;
            return strConnectString;
        }

        /// <summary>
        /// 对xml文件进行解密
        /// </summary>
        /// <param name="strXmlDocName">xml文件名</param>
        /// <param name="strNodeName">所要加密节点名</param>
        /// <returns></returns>
        public List<clsConnectStrObj> GetConnectStringForEncryptEx(string strXmlDocName, string strNodeName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);
            List<clsConnectStrObj> arrConnectStrObjLst = new List<clsConnectStrObj>();
            //XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            //if (elementToEncrypt == null)
            //{
            //    throw new Exception(string.Format("在{0}中没有{1}", strXmlDocName, strNodeName));
            //}
            // Check the arguments.  

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //建立新密钥 设置密钥
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;


            // 在xml文件中找到要解密的数据元素.
            //XmlElement encryptedElement = xmldoc.GetElementsByTagName("EncryptedData")[0] as XmlElement;
            XmlNodeList arrXmlNodeList = xmldoc.GetElementsByTagName("EncryptedData");
            //如果找不到EncryptedData元素则抛出异常
            if (arrXmlNodeList.Count == 0)
            {
                throw new XmlException(string.Format("在文件{0}中，加密数据节点元素未找到.", strXmlDocName));
            }
            //string strConnectString = "";

            while (arrXmlNodeList.Count>0 )
            {
                XmlElement encryptedElement = arrXmlNodeList[arrXmlNodeList.Count-1] as XmlElement;
                //创建EncryptedData对象并加载xml数据
                EncryptedData edElement = new EncryptedData();
                edElement.LoadXml(encryptedElement);

                //创建一个新EncryptedXml对象
                EncryptedXml exml = new EncryptedXml();


                //使用密钥来解密数据
                byte[] rgbOutput = exml.DecryptData(edElement, Key);

                //使用已解密的元素数据替换原元素数据
                exml.ReplaceData(encryptedElement, rgbOutput);
                XmlElement xmlElement = getXmlElement(xmldoc, strNodeName);
                //ArrayList arrXmlElementLst = getXmlElementEx(xmldoc, strNodeName);
                //if (xmlElement == null)
                //{
                //    throw new Exception(string.Format("在{0}中没有{1}", xmldoc.Name, strNodeName));
                //}

                //foreach (XmlElement xmlElement in arrXmlElementLst)
                //{
                clsConnectStrObj objConnectStrObj = new clsConnectStrObj();
                objConnectStrObj.ConnectStringName = xmlElement.Attributes[0].Value;
                objConnectStrObj.ConnectStringValue = xmlElement.Attributes[1].Value;
                objConnectStrObj.ConnectStringProviderName = xmlElement.Attributes[2].Value;
                arrConnectStrObjLst.Add(objConnectStrObj);
                //}
            }
            return arrConnectStrObjLst;
        }



        /// <summary>
        /// 对xml文件进行解密
        /// </summary>
        /// <param name="strXmlDocName">xml文件名</param>
        /// <param name="strNodeName">所要加密节点名</param>
        /// <param name="strConnStrName">连接串名称</param>
        /// <returns></returns>
        public string GetConnectStringForEncrypt(string strXmlDocName, 
                    string strNodeName, 
                    string strConnStrName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);

            //XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            //if (elementToEncrypt == null)
            //{
            //    throw new Exception(string.Format("在{0}中没有{1}", strXmlDocName, strNodeName));
            //}
            // Check the arguments.  

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //建立新密钥 设置密钥
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;


            // 在xml文件中找到要解密的数据元素.
            XmlElement encryptedElement = xmldoc.GetElementsByTagName("EncryptedData")[0] as XmlElement;

            //如果找不到EncryptedData元素则抛出异常
            if (encryptedElement == null)
            {
                throw new XmlException(string.Format("在文件{0}中，加密数据节点元素未找到.", strXmlDocName));
            }


            //创建EncryptedData对象并加载xml数据
            EncryptedData edElement = new EncryptedData();
            edElement.LoadXml(encryptedElement);

            //创建一个新EncryptedXml对象
            EncryptedXml exml = new EncryptedXml();


            //使用密钥来解密数据
            byte[] rgbOutput = exml.DecryptData(edElement, Key);

            //使用已解密的元素数据替换原元素数据
            exml.ReplaceData(encryptedElement, rgbOutput);
            XmlElement xmlElement = getXmlElement(xmldoc, strNodeName);
            //if (xmlElement == null)
            //{
            //    throw new Exception(string.Format("在{0}中没有{1}", xmldoc.Name, strNodeName));
            //}
            string strConnectString = xmlElement.Attributes[strConnStrName].Value;
            return strConnectString;
        }

        /// <summary>
        /// 加载xml文档
        /// </summary>
        /// <param name="xmlfilename">xml文件名</param>
        /// <returns></returns>
        public System.Xml.XmlDocument LoadXML(string xmlfilename)
        {
            //加载xml文档
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.PreserveWhitespace = true;
            //string url = Server.MapPath(xmlfilename);
            xmldoc.Load(xmlfilename);
            return xmldoc;
        }
        /// <summary>
        /// MD5加密函数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MD5(String str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(str);
            byte[] result = md5.ComputeHash(data);
            String ret = "";
            for (int i = 0; i < result.Length; i++)
                ret += result[i].ToString("x").PadLeft(2, '0');
            return ret;
        } 
    }
}
