#if UNITY_WEBGL && ENABLE_WECHAT_MINI_GAME && ENABLE_WECHAT_MINI_GAME_ADVERTISEMENT

using System;
using GameFrameX.Advertisement.Runtime;
using GameFrameX.Runtime;
using WeChatWASM;

namespace GameFrameX.Advertisement.WechatMiniGame.Runtime
{
    /// <summary>
    /// 微信小游戏激励视频广告管理器。
    /// </summary>
    /// <remarks>
    /// 渠道身份常量 <see cref="ChannelId"/> 供注册表互斥解析与显式路由使用；初始化统一走
    /// <see cref="Initialize(AdvertisementConfig)"/> 的强类型 <see cref="WechatMiniGameAdvertisementConfig"/>
    /// （由 WechatMiniGameAdvertisementBootstrap 工厂闭包注入，adUnitId 自组件宏选字段下沉而来）。
    /// </remarks>
    public class WechatMiniGameAdvertisementManager : BaseAdvertisementManager
    {
        /// <summary>
        /// 微信小游戏渠道唯一标识。
        /// </summary>
        public const string ChannelId = "wechatminigame";

        private static WXRewardedVideoAd _wxRewardVideoAd;

        /// <summary>
        /// 使用强类型配置初始化微信小游戏广告管理器。
        /// </summary>
        /// <param name="config">微信小游戏渠道配置</param>
        public override void Initialize(AdvertisementConfig config)
        {
            var wechatConfig = config as WechatMiniGameAdvertisementConfig;
            if (wechatConfig == null)
            {
                throw new ArgumentException("Config must be WechatMiniGameAdvertisementConfig", nameof(config));
            }

            GameFrameworkGuard.NotNullOrEmpty(wechatConfig.adUnitId, nameof(wechatConfig.adUnitId));
#pragma warning disable CS0618
            Initialize(wechatConfig.adUnitId, wechatConfig.isDebug);
#pragma warning restore CS0618
        }

        public override void Initialize(string adUnitId, bool debug = false)
        {
            WXBase.InitSDK((code) => { });
            _wxRewardVideoAd = WXBase.CreateRewardedVideoAd(new WXCreateRewardedVideoAdParam()
            {
                adUnitId = adUnitId
            });

            _wxRewardVideoAd.OnLoad(OnWxAdLoad);
            _wxRewardVideoAd.OnError(OnWxAdError);
            _wxRewardVideoAd.OnClose(OnWxAdClose);
        }

        private void OnWxAdLoad(WXADLoadResponse response)
        {
            UnityEngine.Debug.Log("OnWxAdLoad:" + Utility.Json.ToJson(response));
        }

        private void OnWxADLoadSuccess(WXTextResponse response)
        {
            LoadSuccess(Utility.Json.ToJson(response));
            UnityEngine.Debug.Log("OnWxADLoadSuccess:" + Utility.Json.ToJson(response));
        }

        private void OnWxAdLoadFail(WXADErrorResponse response)
        {
            LoadFail(Utility.Json.ToJson(response));
            UnityEngine.Debug.Log("OnWxAdLoadFail:" + Utility.Json.ToJson(response));
        }

        private void OnWxAdError(WXADErrorResponse response)
        {
            UnityEngine.Debug.Log("WxRewardVideoAd.OnError:" + Utility.Json.ToJson(response));
        }

        private void OnWxAdClose(WXRewardedVideoAdOnCloseResponse response)
        {
            OnShowResult?.Invoke(response.isEnded);
            UnityEngine.Debug.Log("WxRewardVideoAd.OnClose:" + Utility.Json.ToJson(response));
        }

        public override void Show(Action<string> success, Action<string> fail, Action<bool> onShowResult, string customData = null)
        {
            OnShowResult = onShowResult;
            _wxRewardVideoAd.Show(
                (response) =>
                {
                    success.Invoke(Utility.Json.ToJson(response));
                    UnityEngine.Debug.Log("WxRewardVideoAd.Show:" + Utility.Json.ToJson(response));
                },
                (err) =>
                {
                    UnityEngine.Debug.Log("WxRewardVideoAd.ShowError:" + Utility.Json.ToJson(err));
                    fail?.Invoke(Utility.Json.ToJson(err));
                });
        }

        public override void Load(Action<string> success, Action<string> fail, string customData = null)
        {
            OnLoadSuccess = success;
            OnLoadFail = fail;
            _wxRewardVideoAd.Load(OnWxADLoadSuccess, OnWxAdLoadFail);
        }

        public override void Play(Action<bool> playResult, string customData = null)
        {
            void AdLoadSuccess(string success)
            {
                void ShowSuccess(string showSuccess)
                {
                    Log.Debug("ShowSuccess:" + showSuccess);
                }

                void ShowFail(string fail)
                {
                    Log.Debug("ShowFail:" + fail);
                }

                Show(ShowSuccess, ShowFail, playResult, customData);
            }

            void AdLoadFail(string fail)
            {
                playResult?.Invoke(false);
            }

            Load(AdLoadSuccess, AdLoadFail, customData);
        }
    }
}

#endif