#if UNITY_WEBGL && ENABLE_WECHAT_MINI_GAME && ENABLE_WECHAT_MINI_GAME_ADVERTISEMENT

using System;
using GameFrameX.Advertisement.Runtime;
using GameFrameX.Runtime;
using WeChatWASM;

namespace GameFrameX.Advertisement.WechatMiniGame.Runtime
{
    public class WechatMiniGameAdvertisementManager : BaseAdvertisementManager
    {
        private static WXRewardedVideoAd _wxRewardVideoAd;


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