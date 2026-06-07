<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX Advertisement (WeChat ミニゲーム広告)

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.advertisement.wechatminigame)](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.advertisement.wechatminigame)](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/releases)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>
## 📑 目次

- [プロジェクト概要](#プロジェクト概要)
- [クイックスタート](#クイックスタート)
- [使用例](#使用例)
- [ドキュメントとリソース](#ドキュメントとリソース)
- [コミュニティとサポート](#コミュニティとサポート)
- [ライセンス](#ライセンス)

---

## プロジェクト概要

GameFrameX Advertisement（WeChat ミニゲーム）は、WeChat ミニゲームプラットフォーム向けの広告コンポーネントで、WeChat ミニゲームエコシステムをターゲットとした Unity ゲームに広告統合機能を提供します。

### 主な機能

- 🎯 **WeChat ミニゲーム広告** - WeChat ミニゲームネイティブ広告 SDK 統合
- 🔧 **コンポーネントベース設計** - GameFrameX モジュラーアーキテクチャ基盤
- 📊 **複数広告タイプ** - バナー、インタースティシャル、リワード動画広告をサポート
- 🛠️ **簡単設定** - コードクロッピング対応のシンプルセットアップ

### システム要件

- Unity 2017.1以上

---

## クイックスタート

### インストール

#### 方法1: Unity Package Manager（推奨）

1. Unity Package Managerを開く
2. `+`ボタンをクリックし、`Add package from git URL...`を選択
3. 次のURLを入力：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame.git
   ```

#### 方法2: 手動インストール

1. このリポジトリをダウンロードまたはクローン
2. パッケージフォルダをUnityプロジェクトの`Packages`ディレクトリにコピー

---

## 使用例

### プロジェクト構造

```
Runtime/
├── WechatMiniGame/
│   └── WechatMiniGameAdvertisementManager.cs  # WeChat ミニゲーム広告マネージャー
└── GameFrameXAdvertisementWechatMiniGameCroppingHelper.cs  # コードクロッピングヘルパー
```

### 主要なクラス

- **`WechatMiniGameAdvertisementManager`**: WeChat ミニゲーム広告 SDK の `IAdvertisementManager` インターフェースを実装。
- **`GameFrameXAdvertisementWechatMiniGameCroppingHelper`**: ビルド最適化のためのコードクロッピングヘルパー。

---

## ドキュメントとリソース

- 📖 **ドキュメント**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- 🐛 **イシュートラッカー**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/issues)

---

## コミュニティとサポート

- 💬 **QQグループ**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- 💡 **機能リクエスト**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/discussions)

---

## ライセンス

このプロジェクトは**MIT License**と**Apache License 2.0**の二重ライセンスで配布されています。

完全なライセンステキスト: [LICENSE.md](LICENSE.md)

---

<div align="center">

**このプロジェクトが役立ったら、⭐ をください！**

</div>
