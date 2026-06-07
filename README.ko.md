<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX Advertisement (WeChat 미니게임 광고)

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.advertisement.wechatminigame)](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.advertisement.wechatminigame)](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

<br />

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · QQ 그룹: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

## 📑 목차

- [프로젝트 개요](#프로젝트-개요)
- [빠른 시작](#빠른-시작)
- [사용 예시](#사용-예시)
- [문서 및 자료](#문서-및-자료)
- [커뮤니티 및 지원](#커뮤니티-및-지원)
- [라이선스](#라이선스)

---

## 프로젝트 개요

GameFrameX Advertisement (WeChat 미니게임)은 WeChat 미니게임 플랫폼을 위한 광고 컴포넌트로, WeChat 미니게임 생태계를 대상으로 하는 Unity 게임에 광고 통합 기능을 제공합니다.

### 주요 기능

- 🎯 **WeChat 미니게임 광고** - WeChat 미니게임 네이티브 광고 SDK 통합
- 🔧 **컴포넌트 기반 설계** - GameFrameX 모듈식 아키텍처 기반
- 📊 **다중 광고 유형** - 배너, 전면, 리워드 비디오 광고 지원
- 🛠️ **간편 설정** - 코드 크롭핑 지원 간편 설정

### 시스템 요구사항

- Unity 2017.1 이상

---

## 빠른 시작

### 설치

Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:

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

`scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.advertisement.wechatminigame": "1.2.0"
  }
}
```

## 사용 예시

### 프로젝트 구조

```
Runtime/
├── WechatMiniGame/
│   └── WechatMiniGameAdvertisementManager.cs  # WeChat 미니게임 광고 매니저
└── GameFrameXAdvertisementWechatMiniGameCroppingHelper.cs  # 코드 크롭핑 헬퍼
```

### 주요 클래스

- **`WechatMiniGameAdvertisementManager`**: WeChat 미니게임 광고 SDK의 `IAdvertisementManager` 인터페이스 구현.
- **`GameFrameXAdvertisementWechatMiniGameCroppingHelper`**: 빌드 최적화를 위한 코드 크롭핑 헬퍼.

---

## 문서 및 자료

- 📖 **전체 문서**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- 🐛 **이슈 트래커**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/issues)

---

## 커뮤니티 및 지원

- 💬 **QQ 그룹**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- 💡 **기능 요청**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/discussions)

---

## 라이선스

자세한 내용은 [LICENSE.md](LICENSE.md) 파일을 참조하세요.
