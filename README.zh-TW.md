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

## 📑 目錄導航

- [項目簡介](#項目簡介)
- [快速開始](#快速開始)
- [使用範例](#使用範例)
- [文檔與資源](#文檔與資源)
- [社區與支援](#社區與支援)
- [開源協議](#開源協議)

---

## 項目簡介

GameFrameX Advertisement（微信小遊戲）是針對微信小遊戲平台的廣告組件，為面向微信小遊戲生態的 Unity 遊戲提供廣告集成功能。

### 核心特性

- 🎯 **微信小遊戲廣告** - 微信小遊戲原生廣告 SDK 集成
- 🔧 **組件化設計** - 基於 GameFrameX 模組化架構
- 📊 **多種廣告類型** - 支援橫幅、插屏和激勵視頻廣告
- 🛠️ **簡單配置** - 支持代碼裁剪的簡單設置

### 系統需求

- Unity 2017.1 或更高版本

---

## 快速開始

### 安裝方式

#### 方式一：Unity Package Manager（推薦）

1. 打開 Unity Package Manager
2. 點擊 `+` 按鈕，選擇 `Add package from git URL...`
3. 輸入以下 URL：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame.git
   ```

#### 方式二：手動安裝

1. 下載或克隆此倉庫
2. 將包文件夾複製到你的 Unity 項目的 `Packages` 目錄中

---

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

---

## 文檔與資源

- 📖 **完整文檔**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- 🐛 **問題反饋**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/issues)

---

## 社區與支援

- 💬 **QQ 討論群**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- 💡 **功能建議**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/discussions)

---

## 開源協議

本項目採用 **MIT License** 與 **Apache License 2.0** 雙許可證分發。

完整許可證文本請參見: [LICENSE.md](LICENSE.md)

---

<div align="center">

**如果這個項目對你有幫助，請給我們一個 ⭐ Star！**

</div>
