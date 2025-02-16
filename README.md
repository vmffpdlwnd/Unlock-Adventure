# Unlock Adventure

메타적 진행을 특징으로 하는 텍스트 기반 RPG 게임입니다. 플레이어는 게임을 진행하면서 게임 시스템 자체를 발견하고 해금해나가게 됩니다.

## 프로젝트 구조

### Core (코어 시스템)
- `AchievementManager`: 업적 시스템 관리
- `GameManager`: 전체 매니저 총괄 관리
- `InputManager`: 입력값 처리
- `SceneManager`: 씬 관리 및 전환
- `TextManager`: 텍스트/언어 관리

### Data (데이터)
- `GameData`: 게임의 정적 데이터 저장소
  - 텍스트 데이터
  - 업적 데이터
  - (향후 추가될 퀘스트, 아이템 데이터)

### Scenes (씬)
- `LanguageSelectScene`: 언어 선택 화면
- `IntroScene`: 게임 시작 화면
- `GameOverScene`: 게임 오버 화면

## 주요 특징

1. 메타적 진행
   - 게임 시스템을 점진적으로 발견
   - 실패를 통한 새로운 발견

2. 다국어 지원
   - 한국어
   - 영어

3. 업적 시스템
   - 게임 플레이 과정에서 특별한 순간 기록
   - 힌트 시스템으로 활용

## 시작하기

1. 프로젝트 요구사항
   - C# (.NET Core)
   - Visual Studio
   - Windows Console 지원

2. 실행 방법
   1. 프로젝트를 Visual Studio에서 엽니다.
   2. 빌드 후 실행합니다.
   3. 화면의 지시에 따라 진행합니다.

## 확장 계획
- 마을 시스템 추가
- 전투 시스템 구현
- 한국 전통 판타지 요소 추가
- Firebase 연동 저장 시스템

## 아키텍처 특징
- 각 매니저는 단일 책임 원칙을 따름
- Core 시스템과 데이터를 명확히 분리
- 씬은 순수하게 출력만 담당