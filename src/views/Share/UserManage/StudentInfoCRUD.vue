
<template>
<div id = "divLayout" ref="refDivLayout" class = "div_layout"> 
<!--标题层-->

<div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
<label id="lblViewTitle" name="lblViewTitle" class="h5">{{ strTitle }}
</label>
<label id="lblMsg_List" name="lblMsg_List" class="text-warning" style="width:250px;">
</label>
</div>
<!--查询层-->

<div id = "divQuery" ref = "refDivQuery" class = "div_query"> 
<table id="tabEdit" style="width:900px" class="table table-bordered table-hover table td table-sm">
<tr >
<td class="text-right">
<label id="lblStuId_q" name="lblStuId_q" class="col-form-label text-right" style="width:90px;">学号
</label>
</td>
<td class="text-left">
<input  id="txtStuId_q" v-model="stuId_q" class="form-control form-control-sm" style="width:120px;"/>
</td>
<td class="text-right">
<label id="lblStuName_q" name="lblStuName_q" class="col-form-label text-right" style="width:90px;">姓名
</label>
</td>
<td class="text-left">
<input  id="txtStuName_q" v-model="stuName_q" class="form-control form-control-sm" style="width:120px;"/>
</td>
<td class="text-right">
<label id="lblIdXzCollege_q" name="lblIdXzCollege_q" class="col-form-label text-right" style="width:90px;">学院
</label>
</td>
<td class="text-left">
<select id="ddlIdXzCollege_q" v-model='idXzCollege_q' class="form-control form-control-sm" style="width:120px;">
<option v-for="(item, index) in arrXzClg " :key = "index" :value = "item.idXzCollege" >
{{ item.collegeName }}
</option></select>
</td>
<td class="text-right">
<label id="lblIdXzMajor_q" name="lblIdXzMajor_q" class="col-form-label text-right" style="width:90px;">专业
</label>
</td>
<td class="text-left">
<select id="ddlIdXzMajor_q" v-model='idXzMajor_q' class="form-control form-control-sm" style="width:120px;">
<option v-for="(item, index) in arrXzMajor " :key = "index" :value = "item.idXzMajor" >
{{ item.majorName }}
</option></select>
</td>
</tr>
<tr >
<td class="text-right">
<label id="lblIdGradeBase_q" name="lblIdGradeBase_q" class="col-form-label text-right" style="width:90px;">年级
</label>
</td>
<td class="text-left">
<select id="ddlIdGradeBase_q" v-model='idGradeBase_q' class="form-control form-control-sm" style="width:120px;">
<option v-for="(item, index) in arrXzGradeBase " :key = "index" :value = "item.idGradeBase" >
{{ item.gradeBaseName }}
</option></select>
</td>
<td class="text-right">
<label id="lblIdGrade_q" name="lblIdGrade_q" class="col-form-label text-right" style="width:90px;">中小学年级
</label>
</td>
<td class="text-left">
<select id="ddlIdGrade_q" v-model='idGrade_q' class="form-control form-control-sm" style="width:200px;">
<option v-for="(item, index) in arrXzGrade " :key = "index" :value = "item.idGrade" >
{{ item.gradeName }}
</option></select>
</td>
<td class="text-left">
<button  id="btnQuery" name="btnQuery" type="submit" class="btn btn-outline-warning text-nowrap" @click="btn_Click('Query', '')">查询</button>
</td>
<td class="text-left">
<button  id="btnExportExcel" name="btnExportExcel" type="submit" class="btn btn-outline-warning text-nowrap" @click="btn_Click('ExportExcel', '')">导出Excel</button>
</td>
</tr>
</table>
</div>
<!--功能区-->

<div id="divFunction" ref="refDivFunction" class="table table-bordered table-hover">
<ul class="nav">
<li class="nav-item">
<label id="lblStudentInfoList" name="lblStudentInfoList" class="col-form-label text-info" style="width:250px;">学生列表
</label>
</li>
<li class="nav-item ml-3">
<button  id="btnCreate" name="btnCreate" class="btn btn-outline-info btn-sm text-nowrap" @click="btn_Click('Create', '')">添加</button>
</li>
<li class="nav-item ml-3">
<button  id="btnUpdate" name="btnUpdate" class="btn btn-outline-info btn-sm text-nowrap" @click="btn_Click('Update', '')">修改</button>
</li>
<li class="nav-item ml-3">
<button  id="btnDelete" name="btnDelete" class="btn btn-outline-info btn-sm text-nowrap" @click="btn_Click('Delete', '')">删除</button>
</li>
</ul>
</div>
<!--列表层-->
<div id="divList" ref="refDivList" class="div_List">
<StudentInfo_ListCom 
ref="refStudentInfo_List" 
:items="dataListStudentInfo"
:show-error-message="showErrorMessage"
:empty-rec-num-info="emptyRecNumInfo"
@on-edit-tab-relainfo="EditTabRelaInfo"
@on-sort-column="SortColumn">
</StudentInfo_ListCom>
<div id="divPager" class="pager">
</div>
<input  id="hidSortStudentInfoBy" type = "hidden"  />
</div>
<!--编辑层-->
<StudentInfo_EditCom ref='refStudentInfo_Edit'></StudentInfo_EditCom>
</div>
</template>
<script lang="ts">

//import $ from "jquery";
import 'jquery/dist/jquery.min.js';
import 'bootstrap/dist/js/bootstrap.min.js';
import 'bootstrap/dist/css/bootstrap.css';
import { defineComponent, onMounted, ref } from 'vue';
import router from '@/router';
import { clsPrivateSessionStorage } from "@/ts/PubConfig/clsPrivateSessionStorage";
import { divVarSet,refDivLayout,refDivQuery,refDivFunction,refDivList,refStudentInfo_Edit,refStudentInfo_List,showErrorMessage,dataListStudentInfo,emptyRecNumInfo,IdXzCollege_Static,UserType_Session,stuId_q,stuName_q,idXzCollege_q,idXzMajor_q,idGradeBase_q,idGrade_q, } from "@/viewsShare/UserManage/StudentInfoVueShare";
import { StudentInfoCRUDEx } from "@/viewsShare/UserManage/StudentInfoCRUDEx";
import StudentInfo_EditCom from '@/viewsShare/UserManage/StudentInfo_Edit.vue';
import StudentInfo_ListCom from '@/viewsShare/UserManage/StudentInfo_List.vue';
import { clsXzClgEN } from "@/ts/L0Entity/UserManage/clsXzClgEN";
import { clsXzMajorEN } from "@/ts/L0Entity/BaseInfo/clsXzMajorEN";
import { clsXzGradeBaseEN } from "@/ts/L0Entity/SysPara/clsXzGradeBaseEN";
import { clsXzGradeEN } from "@/ts/L0Entity/BaseInfo/clsXzGradeEN";
import { XzClg_GetObjLstCache } from "@/ts/L3ForWApi/UserManage/clsXzClgWApi";
import { XzMajor_GetObjLstCache } from "@/ts/L3ForWApi/BaseInfo/clsXzMajorWApi";
import { XzGradeBase_GetObjLstCache } from "@/ts/L3ForWApi/SysPara/clsXzGradeBaseWApi";
import { XzGrade_GetObjLstCache } from "@/ts/L3ForWApi/BaseInfo/clsXzGradeWApi";
      export  default defineComponent({
name: 'StudentInfoCRUD',
        components: {
            // 组件注册
StudentInfo_EditCom,
 StudentInfo_ListCom,
        },

setup() {

IdXzCollege_Static.value = "";
UserType_Session.value = clsPrivateSessionStorage.userType;

const arrXzClg = ref<clsXzClgEN[]>([]);
const arrXzMajor = ref<clsXzMajorEN[]>([]);
const arrXzGradeBase = ref<clsXzGradeBaseEN[]>([]);
const arrXzGrade = ref<clsXzGradeEN[]>([]);
/**
 * 获取绑定下拉框的数据
 * (AutoGCLib.Vue_ViewScript_TS4Html:Gen_Vue_setup_ts_GetDdlData)
 * @param objDDL:需要绑定当前表的下拉框

 * @param strUserType:
 * @param strIdSchool:
*/
async function getArrXzClg(strUserType: string,strIdSchool: string)
{
let arrObjLstSel = await XzClg_GetObjLstCache(strIdSchool);
if (arrObjLstSel == null) return;
arrXzClg.value.length = 0;
const obj0 = new clsXzClgEN();
obj0.idXzCollege = '0';
obj0.collegeName = '请选择学院...';
arrXzClg.value.push(obj0);
arrObjLstSel = arrObjLstSel.filter(x=>x.userType == strUserType);
arrObjLstSel.forEach(x => arrXzClg.value.push(x));
idXzCollege_q.value = '0';
}
/**
 * 获取绑定下拉框的数据
 * (AutoGCLib.Vue_ViewScript_TS4Html:Gen_Vue_setup_ts_GetDdlData)
 * @param objDDL:需要绑定当前表的下拉框

 * @param strIdXzCollege:
*/
async function getArrXzMajor(strIdXzCollege: string)
{
let arrObjLstSel = await XzMajor_GetObjLstCache();
if (arrObjLstSel == null) return;
arrXzMajor.value.length = 0;
const obj0 = new clsXzMajorEN();
obj0.idXzMajor = '0';
obj0.majorName = '请选择专业...';
arrXzMajor.value.push(obj0);
arrObjLstSel = arrObjLstSel.filter(x=>x.idXzCollege == strIdXzCollege);
arrObjLstSel.forEach(x => arrXzMajor.value.push(x));
idXzMajor_q.value = '0';
}
/**
 * 获取绑定下拉框的数据
 * (AutoGCLib.Vue_ViewScript_TS4Html:Gen_Vue_setup_ts_GetDdlData)
 * @param objDDL:需要绑定当前表的下拉框

*/
async function getArrXzGradeBase()
{
const arrObjLstSel = await XzGradeBase_GetObjLstCache();
if (arrObjLstSel == null) return;
arrXzGradeBase.value.length = 0;
const obj0 = new clsXzGradeBaseEN();
obj0.idGradeBase = '0';
obj0.gradeBaseName = '请选择年级...';
arrXzGradeBase.value.push(obj0);
arrObjLstSel.forEach(x => arrXzGradeBase.value.push(x));
idGradeBase_q.value = '0';
}
/**
 * 获取绑定下拉框的数据
 * (AutoGCLib.Vue_ViewScript_TS4Html:Gen_Vue_setup_ts_GetDdlData)
 * @param objDDL:需要绑定当前表的下拉框

*/
async function getArrXzGrade()
{
let arrObjLstSel = await XzGrade_GetObjLstCache();
if (arrObjLstSel == null) return;
arrXzGrade.value.length = 0;
const obj0 = new clsXzGradeEN();
obj0.idGrade = '0';
obj0.gradeName = '请选择年级...';
arrXzGrade.value.push(obj0);
arrObjLstSel = arrObjLstSel.sort((x, y) => x.gradeIndex - y.gradeIndex);
arrObjLstSel.forEach(x => arrXzGrade.value.push(x));
idGrade_q.value = '0';
}


 /** 函数功能:为查询区绑定下拉框
 * (AutoGCLib.Vue_ViewScript_TS4Html:Gen_Vue_setup_Ts_BindDdl4QryRegion)
 **/
async function BindDdl4QryRegion()
{
const strUserType = UserType_Session.value; //静态变量;//Session存储、local存储
const strIdSchool = IdSchool_Static.value; //静态变量;//静态变量
const strIdXzCollege_Static = IdXzCollege_Static.value; //静态变量;//静态变量


await getArrXzClg(strUserType,strIdSchool);//查询区域

await getArrXzMajor(strIdXzCollege_Static);//查询区域

await getArrXzGradeBase();//查询区域

await getArrXzGrade();//查询区域
}


 /** 函数功能:为功能区绑定下拉框
 * (AutoGCLib.Vue_ViewScript_TS4Html:Gen_Vue_setup_Ts_BindDdl4FeatureRegion)
 **/
async function BindDdl4FeatureRegion()
{

}

const strTitle = ref ('学生维护');
onMounted(() => {
BindDdl4QryRegion();
BindDdl4FeatureRegion();
StudentInfoCRUDEx.vuebtn_Click = btn_Click;
StudentInfoCRUDEx.GetPropValue = GetPropValue;
            const objPage = new StudentInfoCRUDEx();
            objPage.PageLoadCache();
         });
function GetPropValue(strPropName: string): string {
switch (strPropName)
{
case 'strTitle':
return strTitle.value;
default:
return '';
}
}
function btn_Click(strCommandName: string, strKeyId: string) {
switch (strCommandName)
{
case 'Create':
case 'AddNewRecordWithMaxId':
case 'CreateWithMaxId':
case 'Update':
case 'UpdateRecord':
case 'UpdateRecordInTab':
break;
default:
break;
}
StudentInfoCRUDEx.btn_Click(strCommandName, strKeyId);
}
return {
showErrorMessage,
dataListStudentInfo,
emptyRecNumInfo,
strTitle,
btn_Click,
...divVarSet,
refDivLayout,
        refDivQuery,
        refDivFunction,
        refDivList,
        
refStudentInfo_Edit,
refStudentInfo_List,
stuId_q,
stuName_q,
idXzCollege_q,
idXzMajor_q,
idGradeBase_q,
idGrade_q,
arrXzClg,
arrXzMajor,
arrXzGradeBase,
arrXzGrade,
};
},
        watch: {
            // 数据监听
        },
        mounted() {
        },

        methods: {

 /** 函数:编辑表的相关信息
 * (AutoGCLib.Vue_ViewScript_TS4Html:Gen_Vue_method_ts_EditTabRelaInfo)
 **/
async EditTabRelaInfo(data: any) {
console.log('data:', data);
router.push({ name: 'editStudentInfo', params: { courseId: data.courseId } });
},


 /** 函数:根据表列进行排序
 * (AutoGCLib.Vue_ViewScript_TS4Html:Gen_Vue_method_ts_SortColumn)
 **/
async SortColumn(data: any) {
console.log('data:', data);
const objPage = new StudentInfoCRUDEx();
objPage.SortColumn(data.sortColumnKey, data.sortDirection);
},

            // 方法定义
},
    });
</script>
<style scoped>
</style>