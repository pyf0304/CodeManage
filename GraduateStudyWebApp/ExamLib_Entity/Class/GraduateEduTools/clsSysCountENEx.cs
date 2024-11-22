
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsSysCountENEx
表名:SysCount(01120625)
生成代码版本:2020.04.08.1
生成日期:2020/04/16 19:55:40
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;

namespace ExamLib.Entity
{
    /// <summary>
    /// 统计数据(SysCount)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class clsSysCountENEx: clsSysCountEN
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4CSharp:Gen_ENEx_ClassConstructor1)
        /// </summary>
        public clsSysCountENEx()
        {

        }
        private string countType;    //评分统计类型Id
        private int pacount;    //说明类型名
        private float fScore;    //统计分
        private float fStuScore;    //学生统计分
        private float fTeaScore;    //教师统计分
        private string userId;//用户
        private string tablekey;//主键
        private string parrentId;//存放主题；

        public string CountType { get => countType; set => countType = value; }
        public int Pacount { get => pacount; set => pacount = value; }
        public float FScore { get => fScore; set => fScore = value; }
        public float FStuScore { get => fStuScore; set => fStuScore = value; }
        public float FTeaScore { get => fTeaScore; set => fTeaScore = value; }
        public string UserId { get => userId; set => userId = value; }
        public string Tablekey { get => tablekey; set => tablekey = value; }
        public string ParrentId { get => parrentId; set => parrentId = value; }
    }
}