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

## 📑 Table of Contents

- [Project Overview](#project-overview)
- [Quick Start](#quick-start)
- [Usage Examples](#usage-examples)
- [Documentation & Resources](#documentation--resources)
- [Community & Support](#community--support)
- [License](#license)

---

## Project Overview

GameFrameX Advertisement (WeChat Mini Game) is an advertisement component for WeChat Mini Game platform, providing ad integration for Unity games targeting the WeChat Mini Game ecosystem.

### Key Features

- 🎯 **WeChat Mini Game Ads** - Native ad SDK integration for WeChat Mini Game
- 🔧 **Component-Based Design** - Built on GameFrameX modular architecture
- 📊 **Multiple Ad Types** - Support for banner, interstitial, and rewarded video ads
- 🛠️ **Easy Configuration** - Simple setup with code cropping support

### System Requirements

- Unity 2017.1 or higher

---

## Quick Start

### Installation

Edit your Unity project's `Packages/manifest.json` and add the `scopedRegistries` section:

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
  ]
}
```

`scopes` controls which packages are resolved through this registry. Only packages whose names start with `com.gameframex` will be fetched from it.

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.advertisement.wechatminigame": "1.2.0"
  }
}
```


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

---

## Documentation & Resources

- 📖 **Documentation**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- 🐛 **Issue Tracker**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/issues)

---

## Community & Support

- 💬 **QQ Group**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- 💡 **Feature Requests**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/discussions)

---

## License

This project is distributed under **MIT License** and **Apache License 2.0** dual licensing.

See full license text: [LICENSE.md](LICENSE.md)

---

<div align="center">

**If this project helps you, please give us a ⭐ Star!**

</div>
