
/**
* 类名:qa_Paper_EditEx(界面:qa_PaperCRUD)
* 表名:qa_Paper(01120643)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/08 01:11:37
* 生成者:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:互动管理(InteractManage)
* 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
* 编程语言:TypeScript
**/
import { Pub_PaperList } from "../GraduateEduPublicPage/Pub_PaperList.js";
import { qa_Paper_Edit } from "../PagesBase/InteractManage/qa_Paper_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsqa_PaperEN } from "../TS/L0_Entity/InteractManage/clsqa_PaperEN.js";
import { qa_Paper_AddNewRecordWithMaxIdAsync } from "../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { IsNullOrEmpty } from "../TS/PubFun/clsString.js";
/* qa_Paper_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class qa_Paper_EditEx extends qa_Paper_Edit {


    /**
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    **/
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        const strThisFuncName = this.btnEdit_Click.name;
        const objPage = qa_Paper_EditEx.objPage_Edit;
        switch (strCommandName) {
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                const strMsg = '命令:' + strCommandName + "在函数(qa_Paper_EditEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }

    public async btnAddNewRecordWithMaxId_Click() {
        this.opType = "AddWithMaxId";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                console.log('开始添加AddDPV_Edit界面');
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                console.log('结束AddDPV_Edit界面');
                const conBindDdl = await this.BindDdl4EditRegionInDiv();
                console.log('结束BindDdl4EditRegion绑定');

                ShowDialog('Add');

                //获取分享Id
                const responseText = await gs_UserConfigEx_GetNewReturnShareIdEx("11", clsPublocalStorage.userId);
                var strShareId: string = responseText;
                //var returnBool: boolean = !!responseText2;
                if (strShareId != "") {
                    this.shareId = strShareId;
                }

                const objPage_Paper = new Pub_PaperList();
                await objPage_Paper.Page_Load();
                //await objPage_Paper.BindGv_vPaper();
                this.bolIsLoadEditRegion = true;  //


            }
            else {
                ShowDialog('Add');
                console.log('开始绑定BindGv_vPaper');
                const objPage_Paper = new Pub_PaperList();
                await objPage_Paper.Page_Load();
                //await objPage_Paper.BindGv_vPaper();
                console.log('结束绑定BindGv_vPaper');
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
*/
    public async AddNewRecordWithMaxIdSave(): Promise<string> {
        
        var objqa_PaperEN: clsqa_PaperEN = new clsqa_PaperEN();
        this.PutDataToqa_PaperClass(objqa_PaperEN);
        try {
            const returnKeyId = await qa_Paper_AddNewRecordWithMaxIdAsync(objqa_PaperEN);

            if (IsNullOrEmpty( returnKeyId ) == false) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return returnKeyId;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return "";
        }
        //return true;//一定要有一个返回值，否则会出错！
    }

    public async PutDataToqa_PaperClass(pobjqa_PaperEN: clsqa_PaperEN) {
        pobjqa_PaperEN.SetPaperId($("#hidPaperId").val());// 论文Id
        pobjqa_PaperEN.SetIsPublic(true);// 是否公开
        pobjqa_PaperEN.SetIsSubmit(false);// 是否公开
        pobjqa_PaperEN.SetQuestionsCount(0);
        pobjqa_PaperEN.SetAnswerCount(0);
        pobjqa_PaperEN.SetShareId(this.shareId);
        pobjqa_PaperEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjqa_PaperEN.SetUpdUser(clsPublocalStorage.userId);// 修改日期
        pobjqa_PaperEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班id
        pobjqa_PaperEN.SetMemo(this.memo);// 备注
    }


    //////////////////////////////////////////////////////论文部分/////////////////////////////////////////////////
    //确定选择的论文 并添加到关系表中
    public async btnPaperRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidPaperId").val(strkeyId)

        //判断是否选择分配权限；没选择给出提示；
        //需要提示选择角色
        if (this.shareId != "" && this.shareId != "0") {

            const returnKeyId = await this.AddNewRecordWithMaxIdSave();
            if (IsNullOrEmpty(returnKeyId) == false) {
                HideDialog();
                this.iShowList.BindGv(clsqa_PaperEN._CurrTabName, returnKeyId);
            }

        }
        else {
            var strInfo: string = `请选择分配权限下拉框!`;

            //显示信息框
            alert(strInfo);
            return;
        }

    }
    /*
* 分享
*/
    public set shareId(value: string) {
        $("#ddlShareId").val(value);
    }
    /*
    * 分享
    */
    public get shareId(): string {
        return $("#ddlShareId").val();
    }

   
}