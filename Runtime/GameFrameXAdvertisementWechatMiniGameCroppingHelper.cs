using UnityEngine;
using UnityEngine.Scripting;

namespace GameFrameX.Advertisement.WechatMiniGame.Runtime
{
    [Preserve]
    public class GameFrameXAdvertisementWechatMiniGameCroppingHelper : MonoBehaviour
    {
        [Preserve]
        private void Start()
        {
#if UNITY_WEBGL && ENABLE_WECHAT_MINI_GAME_ADVERTISEMENT
            _ = typeof(WechatMiniGameAdvertisementManager);
#endif
        }
    }
}