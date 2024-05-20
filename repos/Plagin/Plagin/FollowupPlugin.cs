using Microsoft.Xrm.Sdk;
using System;
using System.Threading.Tasks;

namespace Plagin
{
    public class Follownplugin : IPlugin
    {

        //<summary>
        //取引先企業作成時に１週間後にフォローアップするタスクを作成します
        //</summary>
        //<param name="serviceProvider">サービスプロバイダ</param>
        //<remarks>
        //Message:Create
        //Primary Entity:account
        //Execution Mode: asynchronous
        //Pipeline Stage:Post-operetion
        //</remarks>


        public void Execute(IServiceProvider serviceProvider)
        {

            //サービスプロバイダから実行コンテキストを取得します
            IPluginExecutionContext context =
            serviceProvider.GetService(typeof(IPluginExecutionContext)) as IPluginExecutionContext;
            //入力パラメータコレクションはリクエストされた全てのデータを含んでいます
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {

                //入力パラメータから対象エンティティを取得する
                Entity entity = context.InputParameters["Target"] as Entity;


                //対象エンティティ取引先企業エンティティか確認します。
                //取引先企業ではない場合はプラグイン登録に不備があります。
                if (entity.LogicalName != "account")
                    return;

                try
                {
                    //１週間後に取引先企業顧客をフォローアップするタスクを作成します
                    Entity followup = new Entity("task");
                    followup["subject"] = "メール送信：新規顧客";
                    followup["description"] = "新規顧客に対してのフォローアップをしてください";
                    followup["scheduledststart"] = DateTime.Now.AddDays(7);
                    followup["scheduledend"] = DateTime.Now.AddDays(7);
                    followup["category"] = context.PrimaryEntityName;

                    //タスクに取引先企業の参照を設定します
                    if (context.OutputParameters.Contains("id"))
                    {
                        Guid regardingobjectid = new Guid(context.OutputParameters["id"].ToString());
                        followup["regardingobjectid"] = new EntityReference(entity.LogicalName, regardingobjectid);
                    }
                    //組織サービスの参照を取得します
                    IOrganizationServiceFactory serviceFactory = serviceProvider.GetService(typeof(IOrganizationServiceFactory))
                        as IOrganizationServiceFactory;

                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    //ＣＲＭにタスクを作成します
                    service.Create(followup);
                }
                catch (Exception ex)
                {
                    //サンプルの為例外処理は再スローします
                    throw new InvalidPluginExecutionException("An error occurred in the FollowupPlugin plug-in", ex);
                }
            }

        }
    }

}

