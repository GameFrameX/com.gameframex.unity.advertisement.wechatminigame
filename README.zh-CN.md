<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX Advertisement (微信小游戏广告)

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.advertisement.wechatminigame)](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.advertisement.wechatminigame)](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 目录导航

- [项目简介](#项目简介)
- [快速开始](#快速开始)
- [使用示例](#使用示例)
- [文档与资源](#文档与资源)
- [社区与支持](#社区与支持)
- [开源协议](#开源协议)

---

## 项目简介

GameFrameX Advertisement（微信小游戏）是针对微信小游戏平台的广告组件，为面向微信小游戏生态的 Unity 游戏提供广告集成功能。本包通过 `WechatMiniGameAdvertisementBootstrap` 在 `BeforeSceneLoad` 阶段自注册进主包 `AdvertisementRegistry`（宏 `UNITY_WEBGL && ENABLE_WECHAT_MINI_GAME && ENABLE_WECHAT_MINI_GAME_ADVERTISEMENT` 未启用时代码被裁剪，注册不会发生；引用即注册）；初始化由工厂闭包注入强类型配置。

### 核心特性

- **微信小游戏广告** - 微信小游戏原生广告 SDK 集成
- **组件化设计** - 基于 GameFrameX 模块化架构
- **多种广告类型** - 支持横幅、插屏和激励视频广告
- **简单配置** - 支持代码裁剪的简单设置

### 系统要求

- Unity 2017.1 或更高版本

---

## 快速开始

### 安装

选择以下任一方式：

1. 编辑 Unity 项目的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：
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

   `scopes` 控制哪些包通过此注册表解析。只有以 `com.gameframex` 开头的包才会从这个注册表获取。

2. 直接在 `manifest.json` 的 `dependencies` 节点下添加以下内容：
   ```json
   {
      "com.gameframex.unity.advertisement.wechatminigame": "https://github.com/gameframex/com.gameframex.unity.advertisement.wechatminigame.git"
   }
   ```
3. 在 Unity 的 `Package Manager` 中使用 `Git URL` 的方式添加库，地址为：`https://github.com/gameframex/com.gameframex.unity.advertisement.wechatminigame.git`
4. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。

### 渠道注册与配置

在启动期（首次广告调用前）对 `WechatMiniGameAdvertisementBootstrap.Config` 赋值：

```csharp
using GameFrameX.Advertisement.Runtime;

// 启动期（首次广告调用前）注入渠道配置
WechatMiniGameAdvertisementBootstrap.Config = new WechatMiniGameAdvertisementConfig
{
    adUnitId = "你的广告位ID",
    isDebug = false,
};

// 之后照常使用 AdvertisementComponent；或显式路由到本渠道
var manager = AdvertisementRegistry.ResolveManager("wechatminigame");
```

渠道 `ChannelId` 常量值为 `"wechatminigame"`，可通过 `AdvertisementRegistry.ResolveManager("wechatminigame")` 显式路由到本渠道。
## 使用示例

### 项目结构

```
Runtime/
├── WechatMiniGame/
│   └── WechatMiniGameAdvertisementManager.cs  # 微信小游戏广告管理器
└── GameFrameXAdvertisementWechatMiniGameCroppingHelper.cs  # 代码裁剪辅助类
```

### 主要类

- **`WechatMiniGameAdvertisementManager`**: 实现了微信小游戏广告 SDK 的 `IAdvertisementManager` 接口。
- **`GameFrameXAdvertisementWechatMiniGameCroppingHelper`**: 用于构建优化的代码裁剪辅助类。
- **`WechatMiniGameAdvertisementConfig`**: 渠道强类型配置，含 `adUnitId`（广告位ID）字段，经 `WechatMiniGameAdvertisementBootstrap.Config` 注入。
- **`WechatMiniGameAdvertisementBootstrap`**: 渠道启动注册，`BeforeSceneLoad` 阶段自注册进主包 `AdvertisementRegistry`，含启动期 `Config` 静态属性。

### 破坏性变更（v2.1）

- **宏选广告位ID字段已移除**：`AdvertisementComponent` 上的「WebGL 微信 广告位ID」序列化字段已删除，`adUnitId` 改经 `WechatMiniGameAdvertisementBootstrap.Config` 注入；
- **主包 Inspector 类型下拉已移除**：渠道发现统一收敛到主包 `AdvertisementRegistry`。

---

## 文档与资源

- **完整文档**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- **问题反馈**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/issues)

---

## 社区与支持

- **QQ 讨论群**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- **功能建议**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/discussions)

---


## 依赖

| 包 | 说明 |
|----|------|
| (无) | - |


## 更新日志

查看 [Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.advertisement.wechatminigame/releases) 了解更新日志。
## 开源协议

详见 [LICENSE.md](LICENSE.md) 文件。
