using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using Activites.ContracTrigger;

namespace Activites.ContracTrigger
{
    public class AutoCreatePlugin 
    {
          public void Execute(IServiceProvider OrganizationRequest) //Excuteメソッド(IServiceProvider型　serviceProvider名：指定)
        {
            //実行コンテキストを取得 IPluginExcutisionContext
            IPluginExecutionContext context =
             serviceProvider.GetService(typeof(IPluginExecutionContext)) as IPluginExecutionContext;

            try
            {
                //入力パラメータに[Target]がない場合は処理を終了します      
                if (!context.InputParameters.ContainsKey("Target"))
                    return;

                //入力パラメータのが出ない場合は終了します
                if (!(context.InputParameters["Target"] is Entity))
                    return;
                //作成された取引先担当者エンティティを取得します
                Entity contact = context.InputParameters["Target"] as Entity;
                //会社名フィールドが存在している場合は処理を終了します
                if (contact.Contains("new_accountname_create"))
                    return;

                //新規作成する取引先企業を取得します　   
                string accountName = contact.GetAttributeValue<string>("new_accountName_create");
                if (string.IsNullOrEmpty(accountName))
                    return;
                //
                OrganizationRequest request = new OrganizationRequest("new_simpleactivity");
                request["Target"] = contact.ToEntityReference();
                request["AccountName"] = accountName;

                //
                IOrganizationServiceFactory factory =
                serviceProvider.GetService(typeof(IOrganizationServiceFactory)) as IOrganizationServiceFactory;

                IOrganizationService service = factory.CreateOrganizationService(context.UserId);
                service.Execute(request);

            }
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message, ex);
            }
        }

    }
}
