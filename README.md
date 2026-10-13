<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX Advertisement (WeChat Mini Game)

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.advertisement.wechatminigame)](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.advertisement.wechatminigame)](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · QQ Group: 467608841 / 233840761

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## Table of Contents

- [Project Overview](#project-overview)
- [Quick Start](#quick-start)
- [Usage Examples](#usage-examples)
- [Documentation & Resources](#documentation--resources)
- [Community & Support](#community--support)
- [License](#license)

---

## Project Overview

GameFrameX Advertisement (WeChat Mini Game) is an advertisement component for WeChat Mini Game platform, providing ad integration for Unity games targeting the WeChat Mini Game ecosystem. This package self-registers into the main package's `AdvertisementRegistry` via `WechatMiniGameAdvertisementBootstrap` at the `BeforeSceneLoad` stage (when the macros `UNITY_WEBGL && ENABLE_WECHAT_MINI_GAME && ENABLE_WECHAT_MINI_GAME_ADVERTISEMENT` are not enabled the code is stripped and registration does not happen; referencing the package is registering); initialization is injected with a strongly-typed config through the factory closure.

### Key Features

- **WeChat Mini Game Ads** - Native ad SDK integration for WeChat Mini Game
- **Component-Based Design** - Built on GameFrameX modular architecture
- **Multiple Ad Types** - Support for banner, interstitial, and rewarded video ads
- **Easy Configuration** - Simple setup with code cropping support

### System Requirements

- Unity 2017.1 or higher

---

## Quick Start

### Installation

Choose one of the following methods:

1. Edit your Unity project's `Packages/manifest.json` and add the `scopedRegistries` section:
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

   `scopes` controls which packages are resolved through this registry. Only packages whose names start with `com.gameframex` will be fetched from it.

2. Add to `manifest.json` dependencies:
   ```json
   {
      "com.gameframex.unity.advertisement.wechatminigame": "https://github.com/gameframex/com.gameframex.unity.advertisement.wechatminigame.git"
   }
   ```
3. Use **Package Manager** in Unity with **Git URL**: `https://github.com/gameframex/com.gameframex.unity.advertisement.wechatminigame.git`
4. Clone the repository into your Unity project's `Packages` directory. It will be loaded automatically.

### Channel Registration & Configuration

Assign `WechatMiniGameAdvertisementBootstrap.Config` at startup (before the first ad call):

```csharp
using GameFrameX.Advertisement.Runtime;

// Inject the channel config at startup (before the first ad call)
WechatMiniGameAdvertisementBootstrap.Config = new WechatMiniGameAdvertisementConfig
{
    adUnitId = "your ad unit id",
    isDebug = false,
};

// Then use AdvertisementComponent as usual; or explicitly route to this channel
var manager = AdvertisementRegistry.ResolveManager("wechatminigame");
```

The channel `ChannelId` constant is `"wechatminigame"`; `AdvertisementRegistry.ResolveManager("wechatminigame")` routes explicitly to this channel.
## Usage Examples

### Project Structure

```
Runtime/
├── WechatMiniGame/
│   └── WechatMiniGameAdvertisementManager.cs  # WeChat Mini Game Ad Manager
└── GameFrameXAdvertisementWechatMiniGameCroppingHelper.cs  # Code Cropping Helper
```

### Main Classes

- **`WechatMiniGameAdvertisementManager`**: Implements `IAdvertisementManager` for the WeChat Mini Game ad SDK.
- **`GameFrameXAdvertisementWechatMiniGameCroppingHelper`**: Code cropping helper for build optimization.
- **`WechatMiniGameAdvertisementConfig`**: Strongly-typed channel config with the `adUnitId` field, injected via `WechatMiniGameAdvertisementBootstrap.Config`.
- **`WechatMiniGameAdvertisementBootstrap`**: Channel startup registration; self-registers into the main package's `AdvertisementRegistry` at `BeforeSceneLoad`, with a startup-time `Config` static property.

### Breaking Changes (v2.1)

- **Macro-selected ad unit ID fields removed**: the serialized "WebGL WeChat ad unit ID" field on `AdvertisementComponent` has been removed; `adUnitId` is now injected via `WechatMiniGameAdvertisementBootstrap.Config`;
- **Main package Inspector type dropdown removed**: channel discovery is now unified through the main package's `AdvertisementRegistry`.

---

## Documentation & Resources

- **Documentation**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- **Issue Tracker**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/issues)

---

## Community & Support

- **QQ Group**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- **Feature Requests**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/discussions)

---


## Dependencies

| Package | Description |
|---------|-------------|
| (无) | - |


## Changelog

See [Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.advertisement.wechatminigame/releases) for changelog.
## License

See [LICENSE.md](LICENSE.md) for license information.
