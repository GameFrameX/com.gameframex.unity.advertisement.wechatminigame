<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX Advertisement (微信小遊戲廣告)

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.advertisement.wechatminigame)](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.advertisement.wechatminigame)](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 目錄導航

- [項目簡介](#項目簡介)
- [快速開始](#快速開始)
- [使用範例](#使用範例)
- [文檔與資源](#文檔與資源)
- [社區與支援](#社區與支援)
- [開源協議](#開源協議)

---

## 項目簡介

GameFrameX Advertisement（微信小遊戲）是針對微信小遊戲平台的廣告組件，為面向微信小遊戲生態的 Unity 遊戲提供廣告集成功能。本包通過 `WechatMiniGameAdvertisementBootstrap` 在 `BeforeSceneLoad` 階段自註冊進主包 `AdvertisementRegistry`（宏 `UNITY_WEBGL && ENABLE_WECHAT_MINI_GAME && ENABLE_WECHAT_MINI_GAME_ADVERTISEMENT` 未啟用時代碼被裁剪，註冊不會發生；引用即註冊）；初始化由工廠閉包注入強型別配置。

### 核心特性

- **微信小遊戲廣告** - 微信小遊戲原生廣告 SDK 集成
- **組件化設計** - 基於 GameFrameX 模組化架構
- **多種廣告類型** - 支援橫幅、插屏和激勵視頻廣告
- **簡單配置** - 支持代碼裁剪的簡單設置

### 系統需求

- Unity 2017.1 或更高版本

---

## 快速開始

### 安裝

選擇以下任一方式：

1. 編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：
   ```json
   {
     "scopedRegistries": [
       {
         "name": "GameFrameX",
         "url": "https://gameframex.upm.alianblank.uk",
         "scopes": [
           "com.gameframex"
         ]
       }
     ],
     "dependencies": {
       "com.gameframex.unity.advertisement.wechatminigame": "1.2.0"
     }
   }
   ```

   `scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

2. 直接在 `manifest.json` 的 `dependencies` 節點下添加以下內容：
   ```json
   {
      "com.gameframex.unity.advertisement.wechatminigame": "https://github.com/gameframex/com.gameframex.unity.advertisement.wechatminigame.git"
   }
   ```
3. 在 Unity 的 `Package Manager` 中使用 `Git URL` 的方式添加庫，地址為：`https://github.com/gameframex/com.gameframex.unity.advertisement.wechatminigame.git`
4. 直接下載倉庫放置到 Unity 專案的 `Packages` 目錄下，會自動載入識別。

### 渠道註冊與配置

在啟動期（首次廣告呼叫前）對 `WechatMiniGameAdvertisementBootstrap.Config` 賦值：

```csharp
using GameFrameX.Advertisement.Runtime;

// 啟動期（首次廣告呼叫前）注入渠道配置
WechatMiniGameAdvertisementBootstrap.Config = new WechatMiniGameAdvertisementConfig
{
    adUnitId = "你的廣告位ID",
    isDebug = false,
};

// 之後照常使用 AdvertisementComponent；或顯式路由到本渠道
var manager = AdvertisementRegistry.ResolveManager("wechatminigame");
```

渠道 `ChannelId` 常量值為 `"wechatminigame"`，可通過 `AdvertisementRegistry.ResolveManager("wechatminigame")` 顯式路由到本渠道。
## 使用範例

### 項目結構

```
Runtime/
├── WechatMiniGame/
│   └── WechatMiniGameAdvertisementManager.cs  # 微信小遊戲廣告管理器
└── GameFrameXAdvertisementWechatMiniGameCroppingHelper.cs  # 代碼裁剪輔助類
```

### 主要類

- **`WechatMiniGameAdvertisementManager`**: 實現了微信小遊戲廣告 SDK 的 `IAdvertisementManager` 介面。
- **`GameFrameXAdvertisementWechatMiniGameCroppingHelper`**: 用於構建優化的代碼裁剪輔助類。
- **`WechatMiniGameAdvertisementConfig`**: 渠道強型別配置，含 `adUnitId`（廣告位ID）欄位，經 `WechatMiniGameAdvertisementBootstrap.Config` 注入。
- **`WechatMiniGameAdvertisementBootstrap`**: 渠道啟動註冊，`BeforeSceneLoad` 階段自註冊進主包 `AdvertisementRegistry`，含啟動期 `Config` 靜態屬性。

### 破壞性變更（v2.1）

- **宏選廣告位ID欄位已移除**：`AdvertisementComponent` 上的「WebGL 微信 廣告位ID」序列化欄位已刪除，`adUnitId` 改經 `WechatMiniGameAdvertisementBootstrap.Config` 注入；
- **主包 Inspector 類型下拉已移除**：渠道發現統一收斂到主包 `AdvertisementRegistry`。

---

## 文檔與資源

- **完整文檔**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- **問題反饋**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/issues)

---

## 社區與支援

- **QQ 討論群**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- **功能建議**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/discussions)

---


## 依賴

| 套件 | 說明 |
|------|------|
| (无) | - |


## 更新日誌

查看 [Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.advertisement.wechatminigame/releases) 了解更新日誌。
## 開源協議

詳見 [LICENSE.md](LICENSE.md) 檔案。
