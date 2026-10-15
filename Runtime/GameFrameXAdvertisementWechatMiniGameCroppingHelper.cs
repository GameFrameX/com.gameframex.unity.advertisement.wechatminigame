using UnityEngine;

namespace GameFrameX.Advertisement.WechatMiniGame.Runtime
{
    [UnityEngine.Scripting.Preserve]
    public class GameFrameXAdvertisementWechatMiniGameCroppingHelper : MonoBehaviour
    {
        [UnityEngine.Scripting.Preserve]
        private void Start()
        {
#if UNITY_WEBGL && ENABLE_WECHAT_MINI_GAME && ENABLE_WECHAT_MINI_GAME_ADVERTISEMENT
            _ = typeof(WechatMiniGameAdvertisementManager);
            _ = typeof(WechatMiniGameAdvertisementConfig);
            _ = typeof(WechatMiniGameAdvertisementBootstrap);
#endif
        }
    }
}