using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CloudSaveManager : MonoBehaviour
{
    async void Start()
    {
        // 初始化 Unity 服务
        await UnityServices.InitializeAsync();

        // 匿名登录
        await AuthenticationService.Instance.SignInAnonymouslyAsync();

        // 保存数据
        var data = new Dictionary<string, object> { { "MySaveKey", "HelloWorld" } };
        await CloudSaveService.Instance.Data.ForceSaveAsync(data);

        Debug.Log("数据已保存");
    }
}
