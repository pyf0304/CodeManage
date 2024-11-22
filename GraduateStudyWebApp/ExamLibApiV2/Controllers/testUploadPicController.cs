
using com.taishsoft.common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Comm.WebApi
{
    [ApiController]
    [Route("[controller]")]
    //[ApiExplorerSettings(IgnoreApi = true)]
    public class testUploadPicController : ControllerBase
    {
        private static string UploadWebMainDir = "";
        private static string UploadWebSubDir = "";
        private static string FunctionDir = "";//功能目录

        //public IActionResult Index()
        //{
        //    return View();
        //}

        ///// <summary>  
        ///// base64编码的文本转为图片  
        ///// </summary>  
        ///// <param name="txtFilePath">文件相对路径(存到服务器上)</param>  
        ///// <param name="str">图片字符串</param>  
        //private void Base64StringToImage(string txtFilePath, string str)
        //{
        //    try
        //    {
        //        String inputStr = str;
        //        byte[] arr = Convert.FromBase64String(inputStr);
        //        MemoryStream ms = new MemoryStream(arr);
        //        Bitmap bmp = new Bitmap(ms);

        //        bmp.Save(System.Web.HttpContext.Current.Server.MapPath(txtFilePath) + ".png", System.Drawing.Imaging.ImageFormat.Jpeg);
        //        //bmp.Save(txtFileName + ".bmp", ImageFormat.Bmp);  
        //        //bmp.Save(txtFileName + ".gif", ImageFormat.Gif);  
        //        //bmp.Save(txtFileName + ".png", ImageFormat.Png);  
        //        ms.Close();
        //        //imgPhoto.ImageUrl = txtFilePath + ".png";  
        //        //MessageBox.Show("转换成功！");  
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        [HttpGet]
        public ActionResult Plus(int a, int b)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            //Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("a", a.ToString());
            //dictParam.Add("b", b.ToString());
            //clsPubFun_WebApi.Log4Debug(this, "Plus", dictParam);
            var c = a + b;
            return Ok(new { success = true, status = 0, message = c.ToString() }); ;

        }

        [HttpGet("GetUploadDir")]
        public ActionResult GetUploadDir(string strUploadWebMainDir, string strUploadWebSubDir, string strFunctionDir)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {
                ["strUploadWebMainDir"] = strUploadWebMainDir,
                ["strUploadWebSubDir"] = strUploadWebSubDir,
                ["strFunctionDir"] = strFunctionDir

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            testUploadPicController.UploadWebMainDir = strUploadWebMainDir;
            testUploadPicController.UploadWebSubDir = strUploadWebSubDir;
            testUploadPicController.FunctionDir = strFunctionDir;

            return Ok(new { success = true, status = 0, message = "设置上传目录成功!" }); ;

        }
        [HttpGet("Test")]
        public ActionResult Test()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            //Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("a", a.ToString());
            //dictParam.Add("b", b.ToString());
            //clsPubFun_WebApi.Log4Debug(this, "Plus", dictParam);
            //var c = a + b;
            return Ok(new { success = true, status = 0, message = "测试成功0" });
        }
        //base64字符串转化成图片  
        [HttpGet("GenerateImage")]
        public ActionResult GenerateImage(String imgStr)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            //图片路径
            string strfilepathPic = string.Empty;

            //对字节数组字符串进行Base64解码并生成图片  
            if (imgStr == "")
            {
                //图像数据为空  
                return Ok(new { status = -1, message = "没有文件", fileName = "" });
            }

            //BASE64Decoder decoder = new BASE64Decoder();
            // BASE64Encoder encoder = new BASE64Encoder();
            try
            {
                // byte[] arr2 = Convert.FromBase64String(imgStr);
                //    //Base64解码  
                //    byte[] b = decoder.decodeBuffer(imgStr);
                //for (int i = 0; i < b.length; ++i)
                //{
                //    if (b[i] < 0)
                //    {//调整异常数据  
                //        b[i] += 256;
                //    }
                //}

                string Id = "";//记录返回的附件Id

                //保存文件
                // var stream = file.OpenReadStream();
                // 把 Stream 转换成 byte[] 
                byte[] bytes = Convert.FromBase64String(imgStr);
                //stream.Read(bytes, 0, bytes.Length);
                //// 设置当前流的位置为流的开始 
                //stream.Seek(0, SeekOrigin.Begin);
                string strAllfileName = "new.png";
                //图片
                string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/UserCanvasPic/";
                if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                {
                    Directory.CreateDirectory(dirFullPath); //创建文件夹
                }
                FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(bytes);
                bw.Close();
                fs.Close();

                //返回路径；
                strfilepathPic = "UploadFiles/" + strAllfileName;

                return Ok(new { success = true, status = 0, message = "上传成功", fileNamePic = strfilepathPic, code = Id });

                //   //生成jpeg图片  
                //   String imgFilePath = "D:\\tupian\\new.png";//新生成的图片  
                //   OutputStream out = new FileOutputStream(imgFilePath);      
                //out.write(b);  
                //out.flush();  
                //out.close();
                //   return true;
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, status = -3, message = "图片解码失败", data = ex.Message, code = "" });
            }
        }




        //通过Canvas生成图片，上传到指定文件夹；
        /// <summary>
        /// 上传附件
        /// </summary>
        /// <returns></returns>
        [HttpPost("UpLoadUserCanvasPic")]
        public ActionResult UpLoadUserCanvasPic(String DataUserId, String Id_CurrEducls, String PicType)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);


            //图片路径
            string strfilepathPic = string.Empty;
            string strAllfileName = string.Empty;//图片命名；
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        //  string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        // string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        //   string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        //string strAllfileName = strfileName + "_" + shortTime + strsuffix;

                        //根据图片类型判断 如果是1 则是学生图片或其他教学班图、2则是教学班图片
                        if (PicType == "2")
                        {
                            strAllfileName = Id_CurrEducls + ".png";

                        }
                        else
                        {
                            strAllfileName = DataUserId + ".png";
                        }



                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 

                        //图片 路径要加上教学班ID文件夹；
                        string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/UserCanvasPic/" + Id_CurrEducls + "/";

                        string fullallPath = dirFullPath + "\\" + strAllfileName;
                        //先清除文件
                        FileInfo filedel = new FileInfo(fullallPath);
                        if (filedel.Exists)
                        {
                            filedel.Delete();
                        }


                        if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                        {
                            Directory.CreateDirectory(dirFullPath); //创建文件夹
                        }


                        FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(bytes);
                        bw.Close();
                        fs.Close();

                        //返回路径；
                        strfilepathPic = "UploadFiles/UserCanvasPic/" + Id_CurrEducls + "/" + strAllfileName;


                    }
                }
                return Ok(new { success = true, status = 0, message = "上传成功", fileNamePic = strfilepathPic, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }
        }

        private void DeleteTempFiles(string iFileName)
        {


            // 文件夹路径

            DirectoryInfo dyInfo = new DirectoryInfo(iFileName);
            //获取文件夹下所有的文件
            foreach (FileInfo feInfo in dyInfo.GetFiles())
            {
                //判断文件日期是否小于今天，是则删除
                if (feInfo.CreationTime < DateTime.Now)
                    feInfo.Delete();
            }


            //DirectoryInfo TheFolder = new DirectoryInfo(iFileName);
            //////遍历文件夹
            ////foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
            ////    this.listBox1.Items.Add(NextFolder.Name);
            ////遍历文件
            //foreach (FileInfo NextFile in TheFolder.GetFiles())
            //{
            //    try { NextFile.Delete(); }
            //    catch { }
            //}
        }
        [HttpPost("UploadFileB")]
        public ActionResult UploadFileB([FromForm] IFormFileCollection formFiles)
        {
            if (formFiles == null || formFiles.Count == 0)
            {
                return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
            }

            // 处理上传的文件
            foreach (var formFile in formFiles)
            {
                // 这里可以对每个上传的文件进行处理
                // 例如，保存文件到磁盘、检查文件类型等
            }

            // 返回成功的响应
            return Ok(new { status = 0, message = "文件上传成功" });
        }

        /// <summary>
        /// 上传附件(单个图片，多个附件文件)论文；
        /// </summary>
        /// <returns></returns>
        [HttpPost("UploadFile")]
        public ActionResult UploadFile()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };

            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            //图片路径
            string strfilepathPic = string.Empty;
            //文件路径1
            string strfilepathOne = string.Empty;
            //文件路径2
            string strfilepathTwo = string.Empty;
            //文件路径3
            string strfilepathThree = string.Empty;
            int i = 1;
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);

                        //判断文件名后缀，是图片还是文件，分别上传到不同的目录路径
                        if (fileExtension == "jpg" || fileExtension == "png" || fileExtension == "gif")
                        {
                            //图片
                            //string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/";

                            string dirFullPath = $"{testUploadPicController.UploadWebMainDir}/UploadFiles/{testUploadPicController.UploadWebSubDir}/";

                            if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                            {
                                Directory.CreateDirectory(dirFullPath); //创建文件夹
                            }
                            FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                            BinaryWriter bw = new BinaryWriter(fs);
                            bw.Write(bytes);
                            bw.Close();
                            fs.Close();

                            //返回路径；
                            //strfilepathPic = "UploadFiles/" + strAllfileName;
                            if (i == 1)
                            {
                                strfilepathOne = $"UploadFiles/{testUploadPicController.UploadWebSubDir}/{strAllfileName}";
                                i++;
                            }
                            else if (i == 2)
                            {
                                strfilepathTwo = $"UploadFiles/{testUploadPicController.UploadWebSubDir}/{strAllfileName}";
                                i++;
                            }
                            else if (i == 3)
                            {
                                strfilepathThree = $"UploadFiles/{testUploadPicController.UploadWebSubDir}/{strAllfileName}";
                            }
                        }
                        else
                        {


                            //文件 word pdf
                            string dirFullPath = $"{testUploadPicController.UploadWebMainDir}/UploadFiles/{testUploadPicController.UploadWebSubDir}/";
                            if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                            {
                                Directory.CreateDirectory(dirFullPath); //创建文件夹
                            }
                            FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                            BinaryWriter bw = new BinaryWriter(fs);
                            bw.Write(bytes);
                            bw.Close();
                            fs.Close();

                            //返回路径；
                            if (i == 1)
                            {
                                strfilepathOne = $"UploadFiles/{testUploadPicController.UploadWebSubDir}/{strAllfileName}";
                                i++;
                            }
                            else if (i == 2)
                            {
                                strfilepathTwo = $"UploadFiles/{testUploadPicController.UploadWebSubDir}/{strAllfileName}";
                                i++;
                            }
                            else if (i == 3)
                            {
                                strfilepathThree = $"UploadFiles/{testUploadPicController.UploadWebSubDir}/{strAllfileName}";
                            }
                        }
                    }
                }

                //string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                //string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                //string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                ////文件名拼接；
                //string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                ////string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                //string strAllfileName = strfileName + shortTime + strsuffix;
                ////string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                ////保存文件
                //var stream = file.OpenReadStream();
                //// 把 Stream 转换成 byte[] 
                //byte[] bytes = new byte[stream.Length];
                //stream.Read(bytes, 0, bytes.Length);
                //// 设置当前流的位置为流的开始 
                //stream.Seek(0, SeekOrigin.Begin);
                //// 把 byte[] 写入文件 
                ////FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                ////FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);

                //string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/";
                //if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                //{
                //    Directory.CreateDirectory(dirFullPath); //创建文件夹
                //}
                //FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                //  BinaryWriter bw = new BinaryWriter(fs);
                //bw.Write(bytes);
                //bw.Close();
                //fs.Close();

                ////返回路径；
                //string strfilepath = "UploadFiles/" + strAllfileName;
                //return Json(strAllfileName);
                //返回图片路径、文件路径
                return Ok(new { success = true, status = 0, message = "上传成功", fileNamePic = strfilepathPic, fileNameOne = strfilepathOne, fileNameTwo = strfilepathTwo, fileNameThree = strfilepathThree, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }

        }

        /// <summary>
        /// 上传附件(单个图片，多个附件文件)论文；
        /// </summary>
        /// <returns></returns>
        [HttpPost("UploadImgFile")]
        public ActionResult UploadImgFile()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };

            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            //图片文件路径1
            string strImgFilePathOne = string.Empty;

            //图片文件路径2
            string strImgFilePathTwo = string.Empty;
            //图片文件路径3
            string strImgFilePathThree = string.Empty;
            int i = 1;
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);

                        //判断文件名后缀，是图片还是文件，分别上传到不同的目录路径
                        if (fileExtension == "jpg" || fileExtension == "png" || fileExtension == "gif")
                        {
                            //图片

                            string dirFullPath = $"{testUploadPicController.UploadWebMainDir}/UploadFiles/{testUploadPicController.UploadWebSubDir}/";

                            if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                            {
                                Directory.CreateDirectory(dirFullPath); //创建文件夹
                            }
                            string strFileFullName_Save = dirFullPath + "\\" + strAllfileName;
                            FileStream fs = new FileStream(strFileFullName_Save, FileMode.Create);

                            BinaryWriter bw = new BinaryWriter(fs);
                            bw.Write(bytes);
                            bw.Close();
                            fs.Close();
                            //clsPubFun_WebApi.Log4Debug(this, strFileFullName_Save, dictParam);
                            clsPubVar_WebApi.objLog.WriteDebugLog($"保存的文件目录:{strFileFullName_Save}");

                            //返回路径；
                            if (i == 1)
                            {
                                strImgFilePathOne = $"UploadFiles/{testUploadPicController.FunctionDir}/{strAllfileName}";
                                i++;
                            }
                            else if (i == 2)
                            {
                                strImgFilePathTwo = $"UploadFiles/{testUploadPicController.FunctionDir}/{strAllfileName}";
                                i++;
                            }
                            else if (i == 3)
                            {
                                strImgFilePathThree = $"UploadFiles/{testUploadPicController.FunctionDir}/{strAllfileName}";
                            }

                        }

                    }
                }

                //返回图片路径、文件路径
                return Ok(new { success = true, status = 0, message = "上传成功", imgFilePathOne = strImgFilePathOne, imgFilePathTwo = strImgFilePathTwo, imgFilePathThree = strImgFilePathThree, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }

        }

        [HttpPost("UploadQuestionImgFile")]
        public ActionResult UploadQuestionImgFile()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };

            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            //图片文件路径1
            string strImgFilePathOne = string.Empty;

            //图片文件路径2
            string strImgFilePathTwo = string.Empty;
            //图片文件路径3
            string strImgFilePathThree = string.Empty;
            int i = 1;
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);

                        //判断文件名后缀，是图片还是文件，分别上传到不同的目录路径
                        if (fileExtension == "jpg" || fileExtension == "png" || fileExtension == "gif")
                        {
                            //图片

                            string dirFullPath = $"{testUploadPicController.UploadWebMainDir}/UploadFiles/{testUploadPicController.UploadWebSubDir}/";

                            if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                            {
                                Directory.CreateDirectory(dirFullPath); //创建文件夹
                            }
                            FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                            BinaryWriter bw = new BinaryWriter(fs);
                            bw.Write(bytes);
                            bw.Close();
                            fs.Close();


                            //返回路径；
                            if (i == 1)
                            {
                                strImgFilePathOne = "UploadFiles/QuestionPic/" + strAllfileName;
                                i++;
                            }
                            else if (i == 2)
                            {
                                strImgFilePathTwo = "UploadFiles/QuestionPic/" + strAllfileName;
                                i++;
                            }
                            else if (i == 3)
                            {
                                strImgFilePathThree = "UploadFiles/QuestionPic/" + strAllfileName;
                            }

                        }

                    }
                }

                //返回图片路径、文件路径
                return Ok(new { success = true, status = 0, message = "上传成功", imgFilePathOne = strImgFilePathOne, imgFilePathTwo = strImgFilePathTwo, imgFilePathThree = strImgFilePathThree, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }

        }

        [HttpPost("UploadQuestionOptionImgFile")]
        public ActionResult UploadQuestionOptionImgFile()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };

            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            //图片文件路径1
            string strImgFilePathOne = string.Empty;

            //图片文件路径2
            string strImgFilePathTwo = string.Empty;
            //图片文件路径3
            string strImgFilePathThree = string.Empty;
            int i = 1;
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);

                        //判断文件名后缀，是图片还是文件，分别上传到不同的目录路径
                        if (fileExtension == "jpg" || fileExtension == "png" || fileExtension == "gif")
                        {
                            //图片

                            string dirFullPath = $"{testUploadPicController.UploadWebMainDir}/UploadFiles/{testUploadPicController.UploadWebSubDir}/";

                            if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                            {
                                Directory.CreateDirectory(dirFullPath); //创建文件夹
                            }
                            FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                            BinaryWriter bw = new BinaryWriter(fs);
                            bw.Write(bytes);
                            bw.Close();
                            fs.Close();


                            //返回路径；
                            if (i == 1)
                            {
                                strImgFilePathOne = "UploadFiles/QuestionOptionPic/" + strAllfileName;
                                i++;
                            }
                            else if (i == 2)
                            {
                                strImgFilePathTwo = "UploadFiles/QuestionOptionPic/" + strAllfileName;
                                i++;
                            }
                            else if (i == 3)
                            {
                                strImgFilePathThree = "UploadFiles/QuestionOptionPic/" + strAllfileName;
                            }

                        }

                    }
                }

                //返回图片路径、文件路径
                return Ok(new { success = true, status = 0, message = "上传成功", imgFilePathOne = strImgFilePathOne, imgFilePathTwo = strImgFilePathTwo, imgFilePathThree = strImgFilePathThree, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }

        }


        /// <summary>
        /// 上传附件(多个附件图片)论文子观点；
        /// </summary>
        /// <returns></returns>
        [HttpPost("UploadFilePic")]
        public ActionResult UploadFilePic()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            ////图片路径
            //string strfilepathPic = string.Empty;
            //图片路径1
            string strfilepathOne = string.Empty;
            //图片路径2
            string strfilepathTwo = string.Empty;
            //图片路径3
            string strfilepathThree = string.Empty;
            int i = 1;
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);


                        //图片
                        string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/PaperSubUploadFile/";
                        if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                        {
                            Directory.CreateDirectory(dirFullPath); //创建文件夹
                        }
                        FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(bytes);
                        bw.Close();
                        fs.Close();

                        //返回路径；
                        if (i == 1)
                        {
                            strfilepathOne = "UploadFiles/PaperSubUploadFile/" + strAllfileName;
                            i++;
                        }
                        else if (i == 2)
                        {
                            strfilepathTwo = "UploadFiles/PaperSubUploadFile/" + strAllfileName;
                            i++;
                        }
                        else if (i == 3)
                        {
                            strfilepathThree = "UploadFiles/PaperSubUploadFile/" + strAllfileName;
                        }
                    }
                }


                return Ok(new { success = true, status = 0, message = "上传成功", fileNameOne = strfilepathOne, fileNameTwo = strfilepathTwo, fileNameThree = strfilepathThree, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }

        }



        /// <summary>
        /// 上传附件(多个附件图片)主题观点附件；
        /// </summary>
        /// <returns></returns>
        [HttpPost("UploadViewpointFilePic")]
        public ActionResult UploadViewpointFilePic()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            ////图片路径
            //string strfilepathPic = string.Empty;
            //图片路径1
            string strfilepathOne = string.Empty;
            //图片路径2
            string strfilepathTwo = string.Empty;
            //图片路径3
            string strfilepathThree = string.Empty;
            int i = 1;
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);


                        //图片
                        string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/ViewpointUploadFile/";
                        if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                        {
                            Directory.CreateDirectory(dirFullPath); //创建文件夹
                        }
                        FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(bytes);
                        bw.Close();
                        fs.Close();

                        //返回路径；
                        if (i == 1)
                        {
                            strfilepathOne = "UploadFiles/ViewpointUploadFile/" + strAllfileName;
                            i++;
                        }
                        else if (i == 2)
                        {
                            strfilepathTwo = "UploadFiles/ViewpointUploadFile/" + strAllfileName;
                            i++;
                        }
                        else if (i == 3)
                        {
                            strfilepathThree = "UploadFiles/ViewpointUploadFile/" + strAllfileName;
                        }
                    }
                }


                return Ok(new { success = true, status = 0, message = "上传成功", fileNameOne = strfilepathOne, fileNameTwo = strfilepathTwo, fileNameThree = strfilepathThree, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }

        }


        /// <summary>
        /// 上传附件(多个附件图片)主题概念附件；
        /// </summary>
        /// <returns></returns>
        [HttpPost("UploadConceptFilePic")]
        public ActionResult UploadConceptFilePic()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            ////图片路径
            //string strfilepathPic = string.Empty;
            //图片路径1
            string strfilepathOne = string.Empty;
            //图片路径2
            string strfilepathTwo = string.Empty;
            //图片路径3
            string strfilepathThree = string.Empty;
            int i = 1;
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);


                        //图片
                        string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/ConceptUploadFile/";
                        if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                        {
                            Directory.CreateDirectory(dirFullPath); //创建文件夹
                        }
                        FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(bytes);
                        bw.Close();
                        fs.Close();

                        //返回路径；
                        if (i == 1)
                        {
                            strfilepathOne = "UploadFiles/ConceptUploadFile/" + strAllfileName;
                            i++;
                        }
                        else if (i == 2)
                        {
                            strfilepathTwo = "UploadFiles/ConceptUploadFile/" + strAllfileName;
                            i++;
                        }
                        else if (i == 3)
                        {
                            strfilepathThree = "UploadFiles/ConceptUploadFile/" + strAllfileName;
                        }
                    }
                }


                return Ok(new { success = true, status = 0, message = "上传成功", fileNameOne = strfilepathOne, fileNameTwo = strfilepathTwo, fileNameThree = strfilepathThree, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }

        }



        /// <summary>
        /// 上传附件(多个附件图片)主题客观附件；
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UploadObjectiveFilePic()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            ////图片路径
            //string strfilepathPic = string.Empty;
            //图片路径1
            string strfilepathOne = string.Empty;
            //图片路径2
            string strfilepathTwo = string.Empty;
            //图片路径3
            string strfilepathThree = string.Empty;
            int i = 1;
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);


                        //图片
                        string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/ObjectiveUploadFile/";
                        if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                        {
                            Directory.CreateDirectory(dirFullPath); //创建文件夹
                        }
                        FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(bytes);
                        bw.Close();
                        fs.Close();

                        //返回路径；
                        if (i == 1)
                        {
                            strfilepathOne = "UploadFiles/ObjectiveUploadFile/" + strAllfileName;
                            i++;
                        }
                        else if (i == 2)
                        {
                            strfilepathTwo = "UploadFiles/ObjectiveUploadFile/" + strAllfileName;
                            i++;
                        }
                        else if (i == 3)
                        {
                            strfilepathThree = "UploadFiles/ObjectiveUploadFile/" + strAllfileName;
                        }
                    }
                }


                return Ok(new { success = true, status = 0, message = "上传成功", fileNameOne = strfilepathOne, fileNameTwo = strfilepathTwo, fileNameThree = strfilepathThree, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }

        }


        //上传论文写作图片（单个）
        /// <summary>
        /// 上传附件
        /// </summary>
        /// <returns></returns>
        [HttpPost("UpLoadPaperWriteGraph")]
        public ActionResult UpLoadPaperWriteGraph()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            //图片路径
            string strfilepathPic = string.Empty;
            //文件路径1
            string strfilepathOne = string.Empty;
            //文件路径2
            string strfilepathTwo = string.Empty;
            //文件路径3
            string strfilepathThree = string.Empty;
            //int i = 1;
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);

                        //判断文件名后缀，是图片还是文件，分别上传到不同的目录路径
                        if (fileExtension == "jpg" || fileExtension == "png" || fileExtension == "gif")
                        {
                            //图片
                            string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/PaperParagraphPic/";
                            if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                            {
                                Directory.CreateDirectory(dirFullPath); //创建文件夹
                            }
                            FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                            BinaryWriter bw = new BinaryWriter(fs);
                            bw.Write(bytes);
                            bw.Close();
                            fs.Close();

                            //返回路径；
                            strfilepathPic = "UploadFiles/PaperParagraphPic/" + strAllfileName;

                        }
                    }
                }
                return Ok(new { success = true, status = 0, message = "上传成功", fileNamePic = strfilepathPic, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }
        }



        //上传论文汇报
        /// <summary>
        /// 上传附件
        /// </summary>
        /// <returns></returns>
        [HttpPost("UpLoadPaperReport")]
        public ActionResult UpLoadPaperReport()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            //ppt
            string strfilepathPPT = string.Empty;
            //pdf
            string strfilepathPDF = string.Empty;

            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);

                        //判断文件名后缀，是图片还是文件，分别上传到不同的目录路径
                        if (fileExtension == "ppt" || fileExtension == "PPT" || fileExtension == "pptx" || fileExtension == "PPTX")
                        {
                            //图片
                            string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/PaperReportFile/";
                            if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                            {
                                Directory.CreateDirectory(dirFullPath); //创建文件夹
                            }
                            FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                            BinaryWriter bw = new BinaryWriter(fs);
                            bw.Write(bytes);
                            bw.Close();
                            fs.Close();

                            //返回路径；
                            strfilepathPPT = "UploadFiles/PaperReportFile/" + strAllfileName;

                        }
                        else if (fileExtension == "pdf" || fileExtension == "PDF")
                        {
                            //图片
                            string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/PaperReportFile/";
                            if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                            {
                                Directory.CreateDirectory(dirFullPath); //创建文件夹
                            }
                            FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                            BinaryWriter bw = new BinaryWriter(fs);
                            bw.Write(bytes);
                            bw.Close();
                            fs.Close();

                            //返回路径；
                            strfilepathPDF = "UploadFiles/PaperReportFile/" + strAllfileName;
                        }
                    }
                }
                return Ok(new { success = true, status = 0, message = "上传成功", fileNamePPT = strfilepathPPT, fileNamePDF = strfilepathPDF, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }
        }



        //上传用户头像（单个）
        /// <summary>
        /// 上传附件
        /// </summary>
        /// <returns></returns>
        [HttpPost("UpLoadUserHeadPic")]
        public ActionResult UpLoadUserHeadPic()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            //图片路径
            string strfilepathPic = string.Empty;
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + "_" + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);

                        //判断文件名后缀，是图片还是文件，分别上传到不同的目录路径
                        if (fileExtension == "jpg" || fileExtension == "png" || fileExtension == "gif")
                        {
                            //图片
                            string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/UserHeadPic/";
                            if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                            {
                                Directory.CreateDirectory(dirFullPath); //创建文件夹
                            }
                            FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                            BinaryWriter bw = new BinaryWriter(fs);
                            bw.Write(bytes);
                            bw.Close();
                            fs.Close();

                            //返回路径；
                            strfilepathPic = "UploadFiles/UserHeadPic/" + strAllfileName;

                        }
                    }
                }
                return Ok(new { success = true, status = 0, message = "上传成功", fileNamePic = strfilepathPic, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }
        }





        /// <summary>
        /// 上传附件(多个附件图片)研究成果附件；
        /// </summary>
        /// <returns></returns>
        [HttpPost("UploadResearchResultFile")]
        public ActionResult UploadResearchResultFile()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            ////图片路径
            //string strfilepathPic = string.Empty;
            //图片路径1
            string strfilepathOne = string.Empty;
            //图片路径2
            string strfilepathTwo = string.Empty;
            //图片路径3
            string strfilepathThree = string.Empty;
            int i = 1;
            try
            {
                string Id = "";//记录返回的附件Id
                               //string filePath = "";//记录文件路径
                IFormFileCollection formFiles = Request.Form.Files;//获取上传的文件
                if (formFiles == null || formFiles.Count == 0)
                {
                    return Ok(new { status = -1, message = "没有上传文件", fileName = "" });
                }
                //临时注释，老方法
                //IFormFile file = formFiles[0];
                //获取多个文件循环
                foreach (var file in formFiles)
                {
                    if (file.Length > 0)
                    {
                        string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);//获取文件名称后缀  png/gif
                        string strfileName = file.FileName.Substring(0, file.FileName.LastIndexOf(".")); //例如:index;
                        string strsuffix = file.FileName.Substring(file.FileName.LastIndexOf(".")); //例如:.png/.gif;
                        long fileSize = file.Length; //获得文件大小，以字节为单位
                                                     //文件名拼接；
                        string shortTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        //string strAllfileName = "/GraduateStudyUploadfiles/"+ strfileName + shortTime + strsuffix;
                        string strAllfileName = strfileName + shortTime + strsuffix;
                        //string strPortAndAddress = clsPubVar.IPAddressAndPortOne;

                        //保存文件
                        var stream = file.OpenReadStream();
                        // 把 Stream 转换成 byte[] 
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        // 设置当前流的位置为流的开始 
                        stream.Seek(0, SeekOrigin.Begin);
                        // 把 byte[] 写入文件 
                        //FileStream fs = new FileStream("D:\\" + file.FileName, FileMode.Create);
                        //FileStream fs = new FileStream(WebRoot + "\\" + file.FileName, FileMode.Create);


                        //图片
                        string dirFullPath = Directory.GetCurrentDirectory() + "/wwwroot/UploadFiles/ResearchResultUploadFile/";
                        if (!Directory.Exists(dirFullPath)) //判断上传文件夹是否存在，若不存在，则创建
                        {
                            Directory.CreateDirectory(dirFullPath); //创建文件夹
                        }
                        FileStream fs = new FileStream(dirFullPath + "\\" + strAllfileName, FileMode.Create);

                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(bytes);
                        bw.Close();
                        fs.Close();

                        //返回路径；
                        if (i == 1)
                        {
                            strfilepathOne = "UploadFiles/ResearchResultUploadFile/" + strAllfileName;
                            i++;
                        }
                        else if (i == 2)
                        {
                            strfilepathTwo = "UploadFiles/ResearchResultUploadFile/" + strAllfileName;
                            i++;
                        }
                        else if (i == 3)
                        {
                            strfilepathThree = "UploadFiles/ResearchResultUploadFile/" + strAllfileName;
                        }
                    }
                }


                return Ok(new { success = true, status = 0, message = "上传成功", fileNameOne = strfilepathOne, fileNameTwo = strfilepathTwo, fileNameThree = strfilepathThree, code = Id });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "上传失败", data = ex.Message, code = "" });
            }

        }





        //public async Task<IActionResult> UploadFiles()
        [HttpPost("UploadFiles")]
        public ActionResult UploadFiles()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            var date = Request;
            var files = Request.Form.Files;
            long size = files.Sum(f => f.Length);
            string shortTime = DateTime.Now.ToString("yyyy/MM/dd") + "/";
            string filePhysicalPath = WebRoot + shortTime;  //文件路径  可以通过注入 IHostingEnvironment 服务对象来取得Web根目录和内容根目录的物理路径

            if (!Directory.Exists(filePhysicalPath)) //判断上传文件夹是否存在，若不存在，则创建
            {
                Directory.CreateDirectory(filePhysicalPath); //创建文件夹
            }
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    var fileName = System.Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);//文件名+文件后缀名
                    using (var stream = new FileStream(filePhysicalPath + fileName, FileMode.Create))
                    {
                        file.CopyToAsync(stream);
                    }
                }
            }
            return Ok(new { count = files.Count, size });
        }

        /// <summary>
        /// 当前的虚拟根目录，在appsettings.json设置：environmentVariables:ASPNETCORE_PATHBASE
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_WebRoot)
        /// </summary>
        public string WebRoot
        {
            get
            {
                //物理路径
                string strPhysicalRoot = AppContext.BaseDirectory;
                //获取设置：虚拟根目录
                var pathBase = Environment.GetEnvironmentVariable("ASPNETCORE_PATHBASE");
                //获取公共变量：WebRoot
                return clsPubVar.WebRoot;
            }
        }
        public string AddressAndPort
        {
            get
            {
                return clsPubVar.IPAddressAndPort + "/GraduateStudyUploadfiles/";
            }
        }

        /// <summary>
                /// 数据下载
                /// </summary>
                /// <param name="path">网站文件的绝对路径</param>
                /// <returns></returns>
        [HttpPost("DownloadFile")]
        public ActionResult DownloadFile(string path)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new()
            {

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    return Ok(new { success = false, status = -3, message = "路径为空" });
                }
                var memoryStream = new MemoryStream();
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    stream.CopyToAsync(memoryStream);
                }
                memoryStream.Seek(0, SeekOrigin.Begin);
                string[] strArry = path.Split('/');
                string fileName = strArry[strArry.Length - 1];
                //文件名必须编码，否则会有特殊字符(如中文)无法在此下载。
                string encodeFilename = System.Net.WebUtility.UrlEncode(fileName);
                Response.Headers.Add("Content-Disposition", "attachment; filename=" + encodeFilename);
                new FileStreamResult(memoryStream, "application/octet-stream");//文件流方式，指定文件流对应的ContenType。
                return Ok(new { success = true, status = 0, message = "下载成功" });
            }

            catch (Exception ex)
            {

                return Ok(new { success = false, status = -3, message = "下载失败", data = ex.Message, code = "" });
            }


        }

    }
}