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
        //ֱ��������Կ
        //ֱ��������Կ
        //char[] key1 =       "1093jchmskdjjlsjdfkjuysnfkdiw;xk".ToCharArray();     
        private char[] key1 = "taishsoft_pyf_qrx_wzr_lf_yhb_123".ToCharArray();//���ܵ���Ҫ
        //char[] iv1 =       "asdfghjkasdfghjk".ToCharArray();
        private char[] iv1 = "zy_zgh_fwz_09876".ToCharArray();                  //���ܵ���Ҫ��ƫ������

        /// <summary>
        /// ��xml�ļ����м���
        /// </summary>
        /// <param name="Doc">xml�ļ���</param>
        /// <param name="ElementName">��Ҫ���ܽڵ���</param>
        /// <param name="Key">��Կ</param>
        public void EncryptXmlDoc(XmlElement elementToEncrypt)
        {
            // Check the arguments.  
            //if (Doc == null)
            //    throw new ArgumentNullException("�޷��ҵ�xml�ļ�");
            //if (ElementName == null)
            //    throw new ArgumentNullException("�޷��ҵ���Ҫ���ܵ�Ԫ��");

            //��xml�ļ����ҵ�Ҫ���ܵ����ݽڵ㲢ʵ����
            //XmlElement elementToEncrypt = Doc.GetElementsByTagName(ElementName)[2] as XmlElement;

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //��������Կ ������Կ
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;
            if (elementToEncrypt == null)
            {
                throw new XmlException("�����㷨�ǲ�֧��xml����");
            }


            //����һ���µ�EncryptedXml���󣬴��ʹ����Կ�Ѽ��ܵ�����
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
                //����㷨��֧��xml�������׳��쳣
                throw new CryptographicException("�����㷨�ǲ�֧��xml����.");
            }

            edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);


            //��EncryptedData����������Ѽ��ܵ�Ԫ������
            edElement.CipherData.CipherValue = encryptedElement;

            ////////////////////////////////////////////////////
            //���Ѽ��ܵ�Ԫ�������滻ԭԪ������
            ////////////////////////////////////////////////////
            EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);
        }
        /// <summary>
        /// ��XML�ĵ��в���ĳ�����
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
                throw new Exception("Xml��㲻��Ϊ�գ�");
            }
            if (strNode.Length == 0)
            {
                throw new Exception("Xml��㲻��Ϊ�գ�");
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
                //throw new Exception(string.Format("��{0}��û��{1}", xmldoc.Name, strNodeName));
            }
            return arrXmlElementLst;
        }

        /// <summary>
        /// ��XML�ĵ��в���ĳ�����
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
                throw new Exception("Xml��㲻��Ϊ�գ�");
            }
            if (strNode.Length == 0)
            {
                throw new Exception("Xml��㲻��Ϊ�գ�");
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
                
                throw new Exception(string.Format("��{0}��û��{1}", xmldoc.Name, strNodeName));
            }
            return null;
        }
        /// <summary>
        /// ��xml�ļ����м���
        /// </summary>
        /// <param name="strXmlDocName">xml�ļ���</param>
        /// <param name="strNodeName">��Ҫ���ܽڵ���</param>
        /// <returns></returns>
        public string EncryptXmlDoc(string strXmlDocName, string strNodeName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);

            XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            if (elementToEncrypt == null)
            {
                throw new Exception(string.Format("��{0}��û��{1}", strXmlDocName, strNodeName));
            }
            // Check the arguments.  

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //��������Կ ������Կ
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;
            //����һ���µ�EncryptedXml���󣬴��ʹ����Կ�Ѽ��ܵ�����
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
                //����㷨��֧��xml�������׳��쳣
                throw new CryptographicException("�����㷨�ǲ�֧��xml����.");
            }

            edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);


            //��EncryptedData����������Ѽ��ܵ�Ԫ������
            edElement.CipherData.CipherValue = encryptedElement;

            ////////////////////////////////////////////////////
            //���Ѽ��ܵ�Ԫ�������滻ԭԪ������
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
        /// ��xml�ļ����м���
        /// </summary>
        /// <param name="strXmlDocName">xml�ļ���</param>
        /// <param name="strNodeName">��Ҫ���ܽڵ���</param>
        /// <returns></returns>
        public string EncryptXmlDocEx(string strXmlDocName, string strNodeName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);

            //XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            ArrayList arrXmlElementLst = getXmlElementEx(xmldoc, strNodeName);
            if (arrXmlElementLst.Count == 0)
            {
                throw new Exception(string.Format("��{0}��û��{1}", strXmlDocName, strNodeName));
            }
            // Check the arguments.  
            foreach (XmlElement elementToEncrypt in arrXmlElementLst)
            {
                byte[] key = Encoding.UTF8.GetBytes(key1);
                byte[] iv = Encoding.UTF8.GetBytes(iv1);

                //��������Կ ������Կ
                RijndaelManaged Rijnd = null;
                Rijnd = new RijndaelManaged();

                Rijnd.Key = key;
                Rijnd.IV = iv;


                SymmetricAlgorithm Key = Rijnd;
                //����һ���µ�EncryptedXml���󣬴��ʹ����Կ�Ѽ��ܵ�����
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
                    //����㷨��֧��xml�������׳��쳣
                    throw new CryptographicException("�����㷨�ǲ�֧��xml����.");
                }

                edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);


                //��EncryptedData����������Ѽ��ܵ�Ԫ������
                edElement.CipherData.CipherValue = encryptedElement;

                ////////////////////////////////////////////////////
                //���Ѽ��ܵ�Ԫ�������滻ԭԪ������
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
        /// ��xml�ļ����н���
        /// </summary>
        /// <param name="strXmlDocName">xml�ļ���</param>
        /// <param name="strNodeName">��Ҫ���ܽڵ���</param>
        /// <returns></returns>
        public string DecryptXmlDoc(string strXmlDocName, string strNodeName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);

            //XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            //if (elementToEncrypt == null)
            //{
            //    throw new Exception(string.Format("��{0}��û��{1}", strXmlDocName, strNodeName));
            //}
            // Check the arguments.  

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //��������Կ ������Կ
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;


            // ��xml�ļ����ҵ�Ҫ���ܵ�����Ԫ��.
            XmlElement encryptedElement = xmldoc.GetElementsByTagName("EncryptedData")[0] as XmlElement;

            //����Ҳ���EncryptedDataԪ�����׳��쳣
            if (encryptedElement == null)
            {
                throw new XmlException(string.Format( "���ļ�{0}�У��������ݽڵ�Ԫ��δ�ҵ�.", strXmlDocName));
            }


            //����EncryptedData���󲢼���xml����
            EncryptedData edElement = new EncryptedData();
            edElement.LoadXml(encryptedElement);

            //����һ����EncryptedXml����
            EncryptedXml exml = new EncryptedXml();


            //ʹ����Կ����������
            byte[] rgbOutput = exml.DecryptData(edElement, Key);

            //ʹ���ѽ��ܵ�Ԫ�������滻ԭԪ������
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
        /// ��xml�ļ����н���
        /// </summary>
        /// <param name="strXmlDocName">xml�ļ���</param>
        /// <param name="strNodeName">��Ҫ���ܽڵ���</param>
          /// <returns></returns>
        public string GetConnectStringForEncrypt(string strXmlDocName, string strNodeName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);

            //XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            //if (elementToEncrypt == null)
            //{
            //    throw new Exception(string.Format("��{0}��û��{1}", strXmlDocName, strNodeName));
            //}
            // Check the arguments.  

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //��������Կ ������Կ
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;


            // ��xml�ļ����ҵ�Ҫ���ܵ�����Ԫ��.
            XmlElement encryptedElement = xmldoc.GetElementsByTagName("EncryptedData")[0] as XmlElement;

            //����Ҳ���EncryptedDataԪ�����׳��쳣
            if (encryptedElement == null)
            {
                throw new XmlException(string.Format("���ļ�{0}�У��������ݽڵ�Ԫ��δ�ҵ�.", strXmlDocName));
            }


            //����EncryptedData���󲢼���xml����
            EncryptedData edElement = new EncryptedData();
            edElement.LoadXml(encryptedElement);

            //����һ����EncryptedXml����
            EncryptedXml exml = new EncryptedXml();


            //ʹ����Կ����������
            byte[] rgbOutput = exml.DecryptData(edElement, Key);

            //ʹ���ѽ��ܵ�Ԫ�������滻ԭԪ������
            exml.ReplaceData(encryptedElement, rgbOutput);
            XmlElement xmlElement = getXmlElement(xmldoc, strNodeName);
            //if (xmlElement == null)
            //{
            //    throw new Exception(string.Format("��{0}��û��{1}", xmldoc.Name, strNodeName));
            //}
            string strConnectString = xmlElement.Attributes["connectionString"].Value;
            return strConnectString;
        }

        /// <summary>
        /// ��xml�ļ����н���
        /// </summary>
        /// <param name="strXmlDocName">xml�ļ���</param>
        /// <param name="strNodeName">��Ҫ���ܽڵ���</param>
        /// <returns></returns>
        public List<clsConnectStrObj> GetConnectStringForEncryptEx(string strXmlDocName, string strNodeName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);
            List<clsConnectStrObj> arrConnectStrObjLst = new List<clsConnectStrObj>();
            //XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            //if (elementToEncrypt == null)
            //{
            //    throw new Exception(string.Format("��{0}��û��{1}", strXmlDocName, strNodeName));
            //}
            // Check the arguments.  

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //��������Կ ������Կ
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;


            // ��xml�ļ����ҵ�Ҫ���ܵ�����Ԫ��.
            //XmlElement encryptedElement = xmldoc.GetElementsByTagName("EncryptedData")[0] as XmlElement;
            XmlNodeList arrXmlNodeList = xmldoc.GetElementsByTagName("EncryptedData");
            //����Ҳ���EncryptedDataԪ�����׳��쳣
            if (arrXmlNodeList.Count == 0)
            {
                throw new XmlException(string.Format("���ļ�{0}�У��������ݽڵ�Ԫ��δ�ҵ�.", strXmlDocName));
            }
            //string strConnectString = "";

            while (arrXmlNodeList.Count>0 )
            {
                XmlElement encryptedElement = arrXmlNodeList[arrXmlNodeList.Count-1] as XmlElement;
                //����EncryptedData���󲢼���xml����
                EncryptedData edElement = new EncryptedData();
                edElement.LoadXml(encryptedElement);

                //����һ����EncryptedXml����
                EncryptedXml exml = new EncryptedXml();


                //ʹ����Կ����������
                byte[] rgbOutput = exml.DecryptData(edElement, Key);

                //ʹ���ѽ��ܵ�Ԫ�������滻ԭԪ������
                exml.ReplaceData(encryptedElement, rgbOutput);
                XmlElement xmlElement = getXmlElement(xmldoc, strNodeName);
                //ArrayList arrXmlElementLst = getXmlElementEx(xmldoc, strNodeName);
                //if (xmlElement == null)
                //{
                //    throw new Exception(string.Format("��{0}��û��{1}", xmldoc.Name, strNodeName));
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
        /// ��xml�ļ����н���
        /// </summary>
        /// <param name="strXmlDocName">xml�ļ���</param>
        /// <param name="strNodeName">��Ҫ���ܽڵ���</param>
        /// <param name="strConnStrName">���Ӵ�����</param>
        /// <returns></returns>
        public string GetConnectStringForEncrypt(string strXmlDocName, 
                    string strNodeName, 
                    string strConnStrName)
        {
            XmlDocument xmldoc = LoadXML(strXmlDocName);

            //XmlElement elementToEncrypt = getXmlElement(xmldoc, strNodeName);
            //if (elementToEncrypt == null)
            //{
            //    throw new Exception(string.Format("��{0}��û��{1}", strXmlDocName, strNodeName));
            //}
            // Check the arguments.  

            byte[] key = Encoding.UTF8.GetBytes(key1);
            byte[] iv = Encoding.UTF8.GetBytes(iv1);

            //��������Կ ������Կ
            RijndaelManaged Rijnd = null;
            Rijnd = new RijndaelManaged();

            Rijnd.Key = key;
            Rijnd.IV = iv;


            SymmetricAlgorithm Key = Rijnd;


            // ��xml�ļ����ҵ�Ҫ���ܵ�����Ԫ��.
            XmlElement encryptedElement = xmldoc.GetElementsByTagName("EncryptedData")[0] as XmlElement;

            //����Ҳ���EncryptedDataԪ�����׳��쳣
            if (encryptedElement == null)
            {
                throw new XmlException(string.Format("���ļ�{0}�У��������ݽڵ�Ԫ��δ�ҵ�.", strXmlDocName));
            }


            //����EncryptedData���󲢼���xml����
            EncryptedData edElement = new EncryptedData();
            edElement.LoadXml(encryptedElement);

            //����һ����EncryptedXml����
            EncryptedXml exml = new EncryptedXml();


            //ʹ����Կ����������
            byte[] rgbOutput = exml.DecryptData(edElement, Key);

            //ʹ���ѽ��ܵ�Ԫ�������滻ԭԪ������
            exml.ReplaceData(encryptedElement, rgbOutput);
            XmlElement xmlElement = getXmlElement(xmldoc, strNodeName);
            //if (xmlElement == null)
            //{
            //    throw new Exception(string.Format("��{0}��û��{1}", xmldoc.Name, strNodeName));
            //}
            string strConnectString = xmlElement.Attributes[strConnStrName].Value;
            return strConnectString;
        }

        /// <summary>
        /// ����xml�ĵ�
        /// </summary>
        /// <param name="xmlfilename">xml�ļ���</param>
        /// <returns></returns>
        public System.Xml.XmlDocument LoadXML(string xmlfilename)
        {
            //����xml�ĵ�
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.PreserveWhitespace = true;
            //string url = Server.MapPath(xmlfilename);
            xmldoc.Load(xmlfilename);
            return xmldoc;
        }
        /// <summary>
        /// MD5���ܺ���
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
