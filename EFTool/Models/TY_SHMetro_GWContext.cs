//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="TY_SHMetro_GWContext.cs">
//        Copyright(c)2015  rights reserved.
//        CLR版本：4.0.30319.239
//        开发组织：李文学@上海同岩土木科技工程有限公司
//        所属工程：TY.*
//        生成时间：2016-12-15 09:54
// </copyright>
//------------------------------------------------------------------------------

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TY.SHMetroPlan.Data.Domain.Models.Mapping;

namespace TY.SHMetroPlan.Data.Domain.Models
{
    public partial class TY_SHMetro_GWContext : DbContext
    {
        static TY_SHMetro_GWContext()
        {
            Database.SetInitializer<TY_SHMetro_GWContext>(null);
        }

        public TY_SHMetro_GWContext()
            : base("Name=TY_SHMetro_GWContext")
        {
        }

        /// <summary>
        /// [BsAssistRequire]
        /// </summary>
        public DbSet<BsAssistRequire> BsAssistRequires { get; set; }
        /// <summary>
        /// [BsAssistUnit]
        /// </summary>
        public DbSet<BsAssistUnit> BsAssistUnits { get; set; }
        /// <summary>
        /// [BsCheckArray]
        /// </summary>
        public DbSet<BsCheckArray> BsCheckArrays { get; set; }
        /// <summary>
        /// [BsCheckConfig]
        /// </summary>
        public DbSet<BsCheckConfig> BsCheckConfigs { get; set; }
        /// <summary>
        /// [BsCheckMember]
        /// </summary>
        public DbSet<BsCheckMember> BsCheckMembers { get; set; }
        /// <summary>
        /// [BsCheckRange]
        /// </summary>
        public DbSet<BsCheckRange> BsCheckRanges { get; set; }
        /// <summary>
        /// [BsDiseaseDoWay]
        /// </summary>
        public DbSet<BsDiseaseDoWay> BsDiseaseDoWays { get; set; }
        /// <summary>
        /// [BsEquipmentConfig]
        /// </summary>
        public DbSet<BsEquipmentConfig> BsEquipmentConfigs { get; set; }
        /// <summary>
        /// [BsFacilityCatetory]
        /// </summary>
        public DbSet<BsFacilityCatetory> BsFacilityCatetories { get; set; }
        /// <summary>
        /// [BsFacilityDisease]
        /// </summary>
        public DbSet<BsFacilityDisease> BsFacilityDiseases { get; set; }
        /// <summary>
        /// [BsFacilityEquipment]
        /// </summary>
        public DbSet<BsFacilityEquipment> BsFacilityEquipments { get; set; }
        /// <summary>
        /// [BsFacilityPart]
        /// </summary>
        public DbSet<BsFacilityPart> BsFacilityParts { get; set; }
        /// <summary>
        /// [BsInterfaceTable]
        /// </summary>
        public DbSet<BsInterfaceTable> BsInterfaceTables { get; set; }
        /// <summary>
        /// [BsInterfaceVersion]
        /// </summary>
        public DbSet<BsInterfaceVersion> BsInterfaceVersions { get; set; }
        /// <summary>
        /// [BsLineCurve]
        /// </summary>
        public DbSet<BsLineCurve> BsLineCurves { get; set; }
        /// <summary>
        /// [BsLineFastener]
        /// </summary>
        public DbSet<BsLineFastener> BsLineFasteners { get; set; }
        /// <summary>
        /// [BsLineInfo]
        /// </summary>
        public DbSet<BsLineInfo> BsLineInfoes { get; set; }
        /// <summary>
        /// [BsLineNet]
        /// </summary>
        public DbSet<BsLineNet> BsLineNets { get; set; }
        /// <summary>
        /// [BsLineRail]
        /// </summary>
        public DbSet<BsLineRail> BsLineRails { get; set; }
        /// <summary>
        /// [BsLineRepairRange]
        /// </summary>
        public DbSet<BsLineRepairRange> BsLineRepairRanges { get; set; }
        /// <summary>
        /// [BsMtAssigned]
        /// </summary>
        public DbSet<BsMtAssigned> BsMtAssigneds { get; set; }
        /// <summary>
        /// [BsMtBuyHistory]
        /// </summary>
        public DbSet<BsMtBuyHistory> BsMtBuyHistories { get; set; }
        /// <summary>
        /// [BsMtCategory]
        /// </summary>
        public DbSet<BsMtCategory> BsMtCategories { get; set; }
        /// <summary>
        /// [BsMtInventory]
        /// </summary>
        public DbSet<BsMtInventory> BsMtInventories { get; set; }
        /// <summary>
        /// [BsMtInvoke]
        /// </summary>
        public DbSet<BsMtInvoke> BsMtInvokes { get; set; }
        /// <summary>
        /// [BsMtMateriale]
        /// </summary>
        public DbSet<BsMtMateriale> BsMtMateriales { get; set; }
        /// <summary>
        /// [BsMtPurchase]
        /// </summary>
        public DbSet<BsMtPurchase> BsMtPurchases { get; set; }
        /// <summary>
        /// [BsMtRecord]
        /// </summary>
        public DbSet<BsMtRecord> BsMtRecords { get; set; }
        /// <summary>
        /// [BsMtReservoir]
        /// </summary>
        public DbSet<BsMtReservoir> BsMtReservoirs { get; set; }
        /// <summary>
        /// [BsMtWarning]
        /// </summary>
        public DbSet<BsMtWarning> BsMtWarnings { get; set; }
        /// <summary>
        /// [BsMtWorkflow]
        /// </summary>
        public DbSet<BsMtWorkflow> BsMtWorkflows { get; set; }
        /// <summary>
        /// [BsSection]
        /// </summary>
        public DbSet<BsSection> BsSections { get; set; }
        /// <summary>
        /// [BsSectionArea]
        /// </summary>
        public DbSet<BsSectionArea> BsSectionAreas { get; set; }
        /// <summary>
        /// [BsSectionRoute]
        /// </summary>
        public DbSet<BsSectionRoute> BsSectionRoutes { get; set; }
        /// <summary>
        /// [BsSectionTurnout]
        /// </summary>
        public DbSet<BsSectionTurnout> BsSectionTurnouts { get; set; }
        /// <summary>
        /// [BsStationLubricator]
        /// </summary>
        public DbSet<BsStationLubricator> BsStationLubricators { get; set; }
        /// <summary>
        /// [BsWkReservoir]
        /// </summary>
        public DbSet<BsWkReservoir> BsWkReservoirs { get; set; }
        /// <summary>
        /// [BsWorkArea]
        /// </summary>
        public DbSet<BsWorkArea> BsWorkAreas { get; set; }
        /// <summary>
        /// [BsWorkAreaEmp]
        /// </summary>
        public DbSet<BsWorkAreaEmp> BsWorkAreaEmps { get; set; }
        /// <summary>
        /// [Sys_Attachment]
        /// </summary>
        public DbSet<Sys_Attachment> Sys_Attachment { get; set; }
        /// <summary>
        /// [Sys_DepartMent]
        /// </summary>
        public DbSet<Sys_DepartMent> Sys_DepartMent { get; set; }
        /// <summary>
        /// [Sys_Dictionary]
        /// </summary>
        public DbSet<Sys_Dictionary> Sys_Dictionary { get; set; }
        /// <summary>
        /// [Sys_Employee]
        /// </summary>
        public DbSet<Sys_Employee> Sys_Employee { get; set; }
        /// <summary>
        /// [Sys_EmpSign]
        /// </summary>
        public DbSet<Sys_EmpSign> Sys_EmpSign { get; set; }
        /// <summary>
        /// [Sys_Log]
        /// </summary>
        public DbSet<Sys_Log> Sys_Log { get; set; }
        /// <summary>
        /// [Sys_LogDetail]
        /// </summary>
        public DbSet<Sys_LogDetail> Sys_LogDetail { get; set; }
        /// <summary>
        /// [Sys_Menu]
        /// </summary>
        public DbSet<Sys_Menu> Sys_Menu { get; set; }
        /// <summary>
        /// [Sys_OperateRight]
        /// </summary>
        public DbSet<Sys_OperateRight> Sys_OperateRight { get; set; }
        /// <summary>
        /// [Sys_Project]
        /// </summary>
        public DbSet<Sys_Project> Sys_Project { get; set; }
        /// <summary>
        /// [Sys_Right]
        /// </summary>
        public DbSet<Sys_Right> Sys_Right { get; set; }
        /// <summary>
        /// [Sys_Role]
        /// </summary>
        public DbSet<Sys_Role> Sys_Role { get; set; }
        /// <summary>
        /// [Sys_SyncLog]
        /// </summary>
        public DbSet<Sys_SyncLog> Sys_SyncLog { get; set; }
        /// <summary>
        /// [sysdiagram]
        /// </summary>
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        /// <summary>
        /// [wf_Activity]
        /// </summary>
        public DbSet<wf_Activity> wf_Activity { get; set; }
        /// <summary>
        /// [wf_ActivityDelegate]
        /// </summary>
        public DbSet<wf_ActivityDelegate> wf_ActivityDelegate { get; set; }
        /// <summary>
        /// [wf_ActivityInstance]
        /// </summary>
        public DbSet<wf_ActivityInstance> wf_ActivityInstance { get; set; }
        /// <summary>
        /// [wf_AppDelegate]
        /// </summary>
        public DbSet<wf_AppDelegate> wf_AppDelegate { get; set; }
        /// <summary>
        /// [wf_CustomFormRelation]
        /// </summary>
        public DbSet<wf_CustomFormRelation> wf_CustomFormRelation { get; set; }
        /// <summary>
        /// [wf_DBVersion]
        /// </summary>
        public DbSet<wf_DBVersion> wf_DBVersion { get; set; }
        /// <summary>
        /// [wf_DemoWorkflowform]
        /// </summary>
        public DbSet<wf_DemoWorkflowform> wf_DemoWorkflowform { get; set; }
        /// <summary>
        /// [wf_GridConfig]
        /// </summary>
        public DbSet<wf_GridConfig> wf_GridConfig { get; set; }
        /// <summary>
        /// [wf_GridViewTable]
        /// </summary>
        public DbSet<wf_GridViewTable> wf_GridViewTable { get; set; }
        /// <summary>
        /// [wf_LogException]
        /// </summary>
        public DbSet<wf_LogException> wf_LogException { get; set; }
        /// <summary>
        /// [wf_ns_Message]
        /// </summary>
        public DbSet<wf_ns_Message> wf_ns_Message { get; set; }
        /// <summary>
        /// [wf_ns_MessageCompleted]
        /// </summary>
        public DbSet<wf_ns_MessageCompleted> wf_ns_MessageCompleted { get; set; }
        /// <summary>
        /// [wf_ns_MessageTemplate]
        /// </summary>
        public DbSet<wf_ns_MessageTemplate> wf_ns_MessageTemplate { get; set; }
        /// <summary>
        /// [wf_ns_NotificationSet]
        /// </summary>
        public DbSet<wf_ns_NotificationSet> wf_ns_NotificationSet { get; set; }
        /// <summary>
        /// [wf_OrganizationConfig]
        /// </summary>
        public DbSet<wf_OrganizationConfig> wf_OrganizationConfig { get; set; }
        /// <summary>
        /// [wf_SmartFormTemplate]
        /// </summary>
        public DbSet<wf_SmartFormTemplate> wf_SmartFormTemplate { get; set; }
        /// <summary>
        /// [wf_SmartTable]
        /// </summary>
        public DbSet<wf_SmartTable> wf_SmartTable { get; set; }
        /// <summary>
        /// [wf_TaskInstance]
        /// </summary>
        public DbSet<wf_TaskInstance> wf_TaskInstance { get; set; }
        /// <summary>
        /// [wf_Transition]
        /// </summary>
        public DbSet<wf_Transition> wf_Transition { get; set; }
        /// <summary>
        /// [wf_TransitionInstance]
        /// </summary>
        public DbSet<wf_TransitionInstance> wf_TransitionInstance { get; set; }
        /// <summary>
        /// [wf_WorkflowApp]
        /// </summary>
        public DbSet<wf_WorkflowApp> wf_WorkflowApp { get; set; }
        /// <summary>
        /// [wf_WorkflowAppCategory]
        /// </summary>
        public DbSet<wf_WorkflowAppCategory> wf_WorkflowAppCategory { get; set; }
        /// <summary>
        /// [wf_WorkflowApprelation]
        /// </summary>
        public DbSet<wf_WorkflowApprelation> wf_WorkflowApprelation { get; set; }
        /// <summary>
        /// [wf_WorkflowConfig]
        /// </summary>
        public DbSet<wf_WorkflowConfig> wf_WorkflowConfig { get; set; }
        /// <summary>
        /// [wf_WorkflowDefinition]
        /// </summary>
        public DbSet<wf_WorkflowDefinition> wf_WorkflowDefinition { get; set; }
        /// <summary>
        /// [wf_WorkflowFile]
        /// </summary>
        public DbSet<wf_WorkflowFile> wf_WorkflowFile { get; set; }
        /// <summary>
        /// [wf_WorkflowHoliday]
        /// </summary>
        public DbSet<wf_WorkflowHoliday> wf_WorkflowHoliday { get; set; }
        /// <summary>
        /// [wf_WorkflowInstance]
        /// </summary>
        public DbSet<wf_WorkflowInstance> wf_WorkflowInstance { get; set; }
        /// <summary>
        /// [wf_WorkflowInstanceComment]
        /// </summary>
        public DbSet<wf_WorkflowInstanceComment> wf_WorkflowInstanceComment { get; set; }
        /// <summary>
        /// [wf_WorkflowOpinion]
        /// </summary>
        public DbSet<wf_WorkflowOpinion> wf_WorkflowOpinion { get; set; }
        /// <summary>
        /// [Wx_CheckArrange]
        /// </summary>
        public DbSet<Wx_CheckArrange> Wx_CheckArrange { get; set; }
        /// <summary>
        /// [Wx_CheckFile]
        /// </summary>
        public DbSet<Wx_CheckFile> Wx_CheckFile { get; set; }
        /// <summary>
        /// [Wx_CheckProject]
        /// </summary>
        public DbSet<Wx_CheckProject> Wx_CheckProject { get; set; }
        /// <summary>
        /// [Wx_CheckWorkMaterial]
        /// </summary>
        public DbSet<Wx_CheckWorkMaterial> Wx_CheckWorkMaterial { get; set; }
        /// <summary>
        /// [Wx_RepairRange]
        /// </summary>
        public DbSet<Wx_RepairRange> Wx_RepairRange { get; set; }
        /// <summary>
        /// [Wx_RepairYearPlan]
        /// </summary>
        public DbSet<Wx_RepairYearPlan> Wx_RepairYearPlan { get; set; }
        /// <summary>
        /// [Wx_YearCheckPlan]
        /// </summary>
        public DbSet<Wx_YearCheckPlan> Wx_YearCheckPlan { get; set; }
        /// <summary>
        /// [YwDiseaseAssistUnit]
        /// </summary>
        public DbSet<YwDiseaseAssistUnit> YwDiseaseAssistUnits { get; set; }
        /// <summary>
        /// [YwDiseaseData]
        /// </summary>
        public DbSet<YwDiseaseData> YwDiseaseDatas { get; set; }
        /// <summary>
        /// [YwDiseaseEvaluate]
        /// </summary>
        public DbSet<YwDiseaseEvaluate> YwDiseaseEvaluates { get; set; }
        /// <summary>
        /// [YwDiseaseFile]
        /// </summary>
        public DbSet<YwDiseaseFile> YwDiseaseFiles { get; set; }
        /// <summary>
        /// [YwDiseaseMaterial]
        /// </summary>
        public DbSet<YwDiseaseMaterial> YwDiseaseMaterials { get; set; }
        /// <summary>
        /// [YwDiseaseModifyHistory]
        /// </summary>
        public DbSet<YwDiseaseModifyHistory> YwDiseaseModifyHistories { get; set; }
        /// <summary>
        /// [YwDiseasePlan]
        /// </summary>
        public DbSet<YwDiseasePlan> YwDiseasePlans { get; set; }
        /// <summary>
        /// [YwDiseasePlanDetail]
        /// </summary>
        public DbSet<YwDiseasePlanDetail> YwDiseasePlanDetails { get; set; }
        /// <summary>
        /// [YwDiseasePlanDetailEmp]
        /// </summary>
        public DbSet<YwDiseasePlanDetailEmp> YwDiseasePlanDetailEmps { get; set; }
        /// <summary>
        /// [YwDiseasePlanDoWay]
        /// </summary>
        public DbSet<YwDiseasePlanDoWay> YwDiseasePlanDoWays { get; set; }
        /// <summary>
        /// [YwDiseasePush]
        /// </summary>
        public DbSet<YwDiseasePush> YwDiseasePushes { get; set; }
        /// <summary>
        /// [YwDiseaseRecord]
        /// </summary>
        public DbSet<YwDiseaseRecord> YwDiseaseRecords { get; set; }
        /// <summary>
        /// [YwGdDetail]
        /// </summary>
        public DbSet<YwGdDetail> YwGdDetails { get; set; }
        /// <summary>
        /// [YwGdTask]
        /// </summary>
        public DbSet<YwGdTask> YwGdTasks { get; set; }
        /// <summary>
        /// [YwTemporaryDeatil]
        /// </summary>
        public DbSet<YwTemporaryDeatil> YwTemporaryDeatils { get; set; }
        /// <summary>
        /// [YwTemporaryTask]
        /// </summary>
        public DbSet<YwTemporaryTask> YwTemporaryTasks { get; set; }
        /// <summary>
        /// [YwXjTask]
        /// </summary>
        public DbSet<YwXjTask> YwXjTasks { get; set; }
        /// <summary>
        /// [vw_Organization]
        /// </summary>
        public DbSet<vw_Organization> vw_Organization { get; set; }
        /// <summary>
        /// [vw_RoleInfo]
        /// </summary>
        public DbSet<vw_RoleInfo> vw_RoleInfo { get; set; }
        /// <summary>
        /// [vw_UserInfo]
        /// </summary>
        public DbSet<vw_UserInfo> vw_UserInfo { get; set; }
        /// <summary>
        /// [vw_UserRoleInfo]
        /// </summary>
        public DbSet<vw_UserRoleInfo> vw_UserRoleInfo { get; set; }
        /// <summary>
        /// [vw_wf_AiidCurrentActors]
        /// </summary>
        public DbSet<vw_wf_AiidCurrentActors> vw_wf_AiidCurrentActors { get; set; }
        /// <summary>
        /// [vw_wf_DoneCirculatedList]
        /// </summary>
        public DbSet<vw_wf_DoneCirculatedList> vw_wf_DoneCirculatedList { get; set; }
        /// <summary>
        /// [vw_wf_DoneList]
        /// </summary>
        public DbSet<vw_wf_DoneList> vw_wf_DoneList { get; set; }
        /// <summary>
        /// [vw_wf_MyCirculatedList]
        /// </summary>
        public DbSet<vw_wf_MyCirculatedList> vw_wf_MyCirculatedList { get; set; }
        /// <summary>
        /// [vw_wf_TodoCirculatedList]
        /// </summary>
        public DbSet<vw_wf_TodoCirculatedList> vw_wf_TodoCirculatedList { get; set; }
        /// <summary>
        /// [vw_wf_TodoList]
        /// </summary>
        public DbSet<vw_wf_TodoList> vw_wf_TodoList { get; set; }
        /// <summary>
        /// [vw_wf_WiidCurrentActivityName]
        /// </summary>
        public DbSet<vw_wf_WiidCurrentActivityName> vw_wf_WiidCurrentActivityName { get; set; }
        /// <summary>
        /// [vw_wf_WorkflowInstanceList]
        /// </summary>
        public DbSet<vw_wf_WorkflowInstanceList> vw_wf_WorkflowInstanceList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BsAssistRequireMap());
            modelBuilder.Configurations.Add(new BsAssistUnitMap());
            modelBuilder.Configurations.Add(new BsCheckArrayMap());
            modelBuilder.Configurations.Add(new BsCheckConfigMap());
            modelBuilder.Configurations.Add(new BsCheckMemberMap());
            modelBuilder.Configurations.Add(new BsCheckRangeMap());
            modelBuilder.Configurations.Add(new BsDiseaseDoWayMap());
            modelBuilder.Configurations.Add(new BsEquipmentConfigMap());
            modelBuilder.Configurations.Add(new BsFacilityCatetoryMap());
            modelBuilder.Configurations.Add(new BsFacilityDiseaseMap());
            modelBuilder.Configurations.Add(new BsFacilityEquipmentMap());
            modelBuilder.Configurations.Add(new BsFacilityPartMap());
            modelBuilder.Configurations.Add(new BsInterfaceTableMap());
            modelBuilder.Configurations.Add(new BsInterfaceVersionMap());
            modelBuilder.Configurations.Add(new BsLineCurveMap());
            modelBuilder.Configurations.Add(new BsLineFastenerMap());
            modelBuilder.Configurations.Add(new BsLineInfoMap());
            modelBuilder.Configurations.Add(new BsLineNetMap());
            modelBuilder.Configurations.Add(new BsLineRailMap());
            modelBuilder.Configurations.Add(new BsLineRepairRangeMap());
            modelBuilder.Configurations.Add(new BsMtAssignedMap());
            modelBuilder.Configurations.Add(new BsMtBuyHistoryMap());
            modelBuilder.Configurations.Add(new BsMtCategoryMap());
            modelBuilder.Configurations.Add(new BsMtInventoryMap());
            modelBuilder.Configurations.Add(new BsMtInvokeMap());
            modelBuilder.Configurations.Add(new BsMtMaterialeMap());
            modelBuilder.Configurations.Add(new BsMtPurchaseMap());
            modelBuilder.Configurations.Add(new BsMtRecordMap());
            modelBuilder.Configurations.Add(new BsMtReservoirMap());
            modelBuilder.Configurations.Add(new BsMtWarningMap());
            modelBuilder.Configurations.Add(new BsMtWorkflowMap());
            modelBuilder.Configurations.Add(new BsSectionMap());
            modelBuilder.Configurations.Add(new BsSectionAreaMap());
            modelBuilder.Configurations.Add(new BsSectionRouteMap());
            modelBuilder.Configurations.Add(new BsSectionTurnoutMap());
            modelBuilder.Configurations.Add(new BsStationLubricatorMap());
            modelBuilder.Configurations.Add(new BsWkReservoirMap());
            modelBuilder.Configurations.Add(new BsWorkAreaMap());
            modelBuilder.Configurations.Add(new BsWorkAreaEmpMap());
            modelBuilder.Configurations.Add(new Sys_AttachmentMap());
            modelBuilder.Configurations.Add(new Sys_DepartMentMap());
            modelBuilder.Configurations.Add(new Sys_DictionaryMap());
            modelBuilder.Configurations.Add(new Sys_EmployeeMap());
            modelBuilder.Configurations.Add(new Sys_EmpSignMap());
            modelBuilder.Configurations.Add(new Sys_LogMap());
            modelBuilder.Configurations.Add(new Sys_LogDetailMap());
            modelBuilder.Configurations.Add(new Sys_MenuMap());
            modelBuilder.Configurations.Add(new Sys_OperateRightMap());
            modelBuilder.Configurations.Add(new Sys_ProjectMap());
            modelBuilder.Configurations.Add(new Sys_RightMap());
            modelBuilder.Configurations.Add(new Sys_RoleMap());
            modelBuilder.Configurations.Add(new Sys_SyncLogMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new wf_ActivityMap());
            modelBuilder.Configurations.Add(new wf_ActivityDelegateMap());
            modelBuilder.Configurations.Add(new wf_ActivityInstanceMap());
            modelBuilder.Configurations.Add(new wf_AppDelegateMap());
            modelBuilder.Configurations.Add(new wf_CustomFormRelationMap());
            modelBuilder.Configurations.Add(new wf_DBVersionMap());
            modelBuilder.Configurations.Add(new wf_DemoWorkflowformMap());
            modelBuilder.Configurations.Add(new wf_GridConfigMap());
            modelBuilder.Configurations.Add(new wf_GridViewTableMap());
            modelBuilder.Configurations.Add(new wf_LogExceptionMap());
            modelBuilder.Configurations.Add(new wf_ns_MessageMap());
            modelBuilder.Configurations.Add(new wf_ns_MessageCompletedMap());
            modelBuilder.Configurations.Add(new wf_ns_MessageTemplateMap());
            modelBuilder.Configurations.Add(new wf_ns_NotificationSetMap());
            modelBuilder.Configurations.Add(new wf_OrganizationConfigMap());
            modelBuilder.Configurations.Add(new wf_SmartFormTemplateMap());
            modelBuilder.Configurations.Add(new wf_SmartTableMap());
            modelBuilder.Configurations.Add(new wf_TaskInstanceMap());
            modelBuilder.Configurations.Add(new wf_TransitionMap());
            modelBuilder.Configurations.Add(new wf_TransitionInstanceMap());
            modelBuilder.Configurations.Add(new wf_WorkflowAppMap());
            modelBuilder.Configurations.Add(new wf_WorkflowAppCategoryMap());
            modelBuilder.Configurations.Add(new wf_WorkflowApprelationMap());
            modelBuilder.Configurations.Add(new wf_WorkflowConfigMap());
            modelBuilder.Configurations.Add(new wf_WorkflowDefinitionMap());
            modelBuilder.Configurations.Add(new wf_WorkflowFileMap());
            modelBuilder.Configurations.Add(new wf_WorkflowHolidayMap());
            modelBuilder.Configurations.Add(new wf_WorkflowInstanceMap());
            modelBuilder.Configurations.Add(new wf_WorkflowInstanceCommentMap());
            modelBuilder.Configurations.Add(new wf_WorkflowOpinionMap());
            modelBuilder.Configurations.Add(new Wx_CheckArrangeMap());
            modelBuilder.Configurations.Add(new Wx_CheckFileMap());
            modelBuilder.Configurations.Add(new Wx_CheckProjectMap());
            modelBuilder.Configurations.Add(new Wx_CheckWorkMaterialMap());
            modelBuilder.Configurations.Add(new Wx_RepairRangeMap());
            modelBuilder.Configurations.Add(new Wx_RepairYearPlanMap());
            modelBuilder.Configurations.Add(new Wx_YearCheckPlanMap());
            modelBuilder.Configurations.Add(new YwDiseaseAssistUnitMap());
            modelBuilder.Configurations.Add(new YwDiseaseDataMap());
            modelBuilder.Configurations.Add(new YwDiseaseEvaluateMap());
            modelBuilder.Configurations.Add(new YwDiseaseFileMap());
            modelBuilder.Configurations.Add(new YwDiseaseMaterialMap());
            modelBuilder.Configurations.Add(new YwDiseaseModifyHistoryMap());
            modelBuilder.Configurations.Add(new YwDiseasePlanMap());
            modelBuilder.Configurations.Add(new YwDiseasePlanDetailMap());
            modelBuilder.Configurations.Add(new YwDiseasePlanDetailEmpMap());
            modelBuilder.Configurations.Add(new YwDiseasePlanDoWayMap());
            modelBuilder.Configurations.Add(new YwDiseasePushMap());
            modelBuilder.Configurations.Add(new YwDiseaseRecordMap());
            modelBuilder.Configurations.Add(new YwGdDetailMap());
            modelBuilder.Configurations.Add(new YwGdTaskMap());
            modelBuilder.Configurations.Add(new YwTemporaryDeatilMap());
            modelBuilder.Configurations.Add(new YwTemporaryTaskMap());
            modelBuilder.Configurations.Add(new YwXjTaskMap());
            modelBuilder.Configurations.Add(new vw_OrganizationMap());
            modelBuilder.Configurations.Add(new vw_RoleInfoMap());
            modelBuilder.Configurations.Add(new vw_UserInfoMap());
            modelBuilder.Configurations.Add(new vw_UserRoleInfoMap());
            modelBuilder.Configurations.Add(new vw_wf_AiidCurrentActorsMap());
            modelBuilder.Configurations.Add(new vw_wf_DoneCirculatedListMap());
            modelBuilder.Configurations.Add(new vw_wf_DoneListMap());
            modelBuilder.Configurations.Add(new vw_wf_MyCirculatedListMap());
            modelBuilder.Configurations.Add(new vw_wf_TodoCirculatedListMap());
            modelBuilder.Configurations.Add(new vw_wf_TodoListMap());
            modelBuilder.Configurations.Add(new vw_wf_WiidCurrentActivityNameMap());
            modelBuilder.Configurations.Add(new vw_wf_WorkflowInstanceListMap());
        }
    }
}