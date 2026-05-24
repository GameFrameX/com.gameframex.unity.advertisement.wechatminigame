<div align="center">

![GameFrameX Logo](https://download.alianblank.com/gameframex/gameframex_logo_320.png)

# GameFrameX Advertisement (WeChat 미니게임 광고)

[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.advertisement.wechatminigame)](https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame/releases)
[![License](https://img.shields.io/badge/license-MIT+Apache%202.0-orange.svg)](LICENSE.md)
[![Documentation](https://img.shields.io/badge/docs-gameframex.doc.alianblank.com-brightgreen.svg)](https://gameframex.doc.alianblank.com)

**인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현**

[📖 문서](https://gameframex.doc.alianblank.com) | [🚀 빠른 시작](#빠른-시작) | [💬 QQ 그룹: 467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)

---

🌐 **언어**: [English](./README.md) | [简体中文](./README.zh-CN.md) | [繁體中文](./README.zh-TW.md) | [日本語](./README.ja.md) | **한국어**

---

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

#### 방법 1: Unity Package Manager (권장)

1. Unity Package Manager를 엽니다
2. `+` 버튼을 클릭하고 `Add package from git URL...`을 선택합니다
3. 다음 URL을 입력합니다:
   ```
   https://github.com/GameFrameX/com.gameframex.unity.advertisement.wechatminigame.git
   ```

#### 방법 2: 수동 설치

1. 이 저장소를 다운로드하거나 클론합니다
2. 패키지 폴더를 Unity 프로젝트의 `Packages` 디렉토리에 복사합니다

---

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

이 프로젝트는 **MIT 라이선스** 및 **Apache 라이선스 2.0** 이중 라이선스로 배포됩니다.

전체 라이선스 텍스트 보기: [LICENSE.md](LICENSE.md)

---

<div align="center">

**이 프로젝트가 도움이 되셨다면, ⭐ 별을 주세요!**

</div>
