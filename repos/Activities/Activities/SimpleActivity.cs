using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

namespace Activities
{
    public class SimpleActivity : CodeActivity
    {

    ///<summary>
    ///取引先企業　タスク件名　通知日数を引数に取引先企業の作成とタスクの作成をおこないます
    ///</summary>
    ///<param name="context">アクティビティコンテキスト</param>
    ///<remarks>
    /// [パラメータ]
    ///[必須]取引先企業.取引先名:String
    ///[必須]タスク.件名：String
    ///[必須]タスク.通知日数：Int32
    ///[任意]取引先担当者：EntityReference
    ///</remarks>

        protected override void Execute(CodeActivityContext executionContext)
        {
            //コンテキスト　組織サービスを作成
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

            //取引先企業を作成
            Entity account = new Entity("account");
            account.Attributes.Add("name", AccountName.Get<string>(executionContext));
            Guid newAccountId = service.Create(account);


            //取引先企業をの主キー情報を作成
            EntityReference accountReference = new EntityReference(account.LogicalName, newAccountId);


            //タスクを作成
            Entity task = new Entity("task");
            task.Attributes.Add("subject", TaskSubject.Get<string>(executionContext));
            task.Attributes.Add("regardingobjectid", new EntityReference(account.LogicalName, newAccountId));

            //
            DateTime notifyDate = DateTime.Now.AddDays(NotifyDays.Get<int>(executionContext));
            task.Attributes.Add("scheduldestart", new DateTime(notifyDate.Year, notifyDate.Month, notifyDate.Day));
            task.Attributes.Add("scheduldeend", new DateTime(notifyDate.Year, notifyDate.Month, notifyDate.Day));

            Guid newTaskId = service.Create(task);


            //取引先担当者の会社名に作成した取引先企業を想定
            EntityReference contactReference = this.ContactReference.Get<EntityReference>(executionContext);

            //取引先担当者が指定されていない場合は処理を終了します
            if (contactReference == null)
                return;

            //取引先担当者
            Entity contact = new Entity(contactReference.LogicalName);
            contact.Id = contactReference.Id;
            contact.Attributes.Add("parentcustomerid", accountReference);

            //組織サービスを更新します
            service.Update(contact);
        }


        
        ///<summary>
        ///[必須]取引先企業
        ///</summary>
        [Input("Account Name")]
        [RequiredArgument()]
        public InArgument<string> AccountName { get; set; }

        ///<summary>
        ///[必須]タスク件名
        ///</summary>
        [Input("Task Subject")]
        [RequiredArgument()]
        public InArgument<string> TaskSubject { get; set; }


        //<summary>
        ///[必須]タスク通知日数
        ///</summary>
        [Input("Task Notify Days")]
        [RequiredArgument()]
        public InArgument<int> NotifyDays { get; set; }

        ///<summary>
        ///取引先担当者主キー情報
        ///</summary>
        [Input("Contact Entity Reference")]
        [ReferenceTarget("contact")]
        public InArgument<EntityReference> ContactReference { get; set; }

       
    }


}
///③	ソリューションをビルドします。「7.3プラグインアセンブリの作成」と同じ手順で、アセンブリがされているかを確認します。
/// から開始