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

## 📑 目录导航

- [项目简介](#项目简介)
- [快速开始](#快速开始)
- [使用示例](#使用示例)
- [文档与资源](#文档与资源)
- [社区与支持](#社区与支持)
- [开源协议](#开源协议)

---

## 项目简介

GameFrameX Advertisement（微信小游戏）是针对微信小游戏平台的广告组件，为面向微信小游戏生态的 Unity 游戏提供广告集成功能。

### 核心特性

- 🎯 **微信小游戏广告** - 微信小游戏原生广告 SDK 集成
- 🔧 **组件化设计** - 基于 GameFrameX 模块化架构
- 📊 **多种广告类型** - 支持横幅、插屏和激励视频广告
- 🛠️ **简单配置** - 支持代码裁剪的简单设置

### 系统要求

- Unity 2017.1 或更高版本

---

## 快速开始

### 安装方式

#### 方式一：Unity Package Manager（推荐）

1. 打开 Unity Package Manager
2. 点击 `+` 按钮，选择 `Add package from git URL...`
3. 输入以下 URL：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame.git
   ```

#### 方式二：手动安装

1. 下载或克隆此仓库
2. 将包文件夹复制到你的 Unity 项目的 `Packages` 目录中

---

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

---

## 文档与资源

- 📖 **完整文档**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- 🐛 **问题反馈**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/issues)

---

## 社区与支持

- 💬 **QQ 讨论群**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- 💡 **功能建议**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/discussions)

---

## 开源协议

本项目采用 **MIT License** 与 **Apache License 2.0** 双许可证分发。

完整许可证文本请参见: [LICENSE.md](LICENSE.md)

---

<div align="center">

**如果这个项目对你有帮助，请给我们一个 ⭐ Star！**

</div>
