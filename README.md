<h1 align="center">NBC_Unreal_8th_Assignment10</h1>

## 개요

이 프로젝트는 두 가지가 구현되어 있습니다.

1. **프로젝트 모듈 `Test`** — `Source/` 아래의 추가 C++ 모듈. 주 게임 모듈에서 이를 참조하여 `ATestActor` 를 스폰합니다.
2. **독립 플러그인 `Temporary`** — `Plugins/` 아래의 `.uplugin` 기반 플러그인. `IModuleInterface` 를 직접 구현하여 `StartupModule` / `ShutdownModule` 로 로드/언로드 시점을 제어합니다.

---

## 모듈 vs 플러그인

| 구분 | Module (`Test`) | Plugin (`Temporary`) |
| --- | --- | --- |
| 위치 | `Source/Test/` | `Plugins/Temporary/` |
| 정의 파일 | 없음 (`.Build.cs` 만) | `.uplugin` |
| 모듈 등록 | `.uproject` 의 `Modules` + `*.Target.cs` 의 `ExtraModuleNames` | `.uplugin` 의 `Modules` |
| 활성화 | 빌드 대상에 포함 | `.uproject` 의 `Plugins` 에 `Enabled: true` |
| 켜고 끄기 | 불가 | 가능 (에디터 Plugins 창) |
| 이식성 | 프로젝트에 종속 | 폴더째 재사용 가능 |
| 구현 매크로 | `IMPLEMENT_MODULE(FDefaultModuleImpl, Test)` | `IMPLEMENT_MODULE(FTemporaryModule, Temporary)` |

---

## 구현 결과

### `Test` 모듈

- `Source/Test/` 에 위치한 추가 런타임 모듈
- `Test.cpp` 에서 `IMPLEMENT_MODULE(FDefaultModuleImpl, Test)` 로 구현
- `ATestActor` 를 포함하며, `BeginPlay()` 에서 `UE_LOG` 출력
- `Assignment10.uproject` 의 `Modules` 와 양쪽 `*.Target.cs` 의 `ExtraModuleNames` 에 등록됨

### 모듈 간 참조

- `Assignment10.Build.cs` 의 `PublicDependencyModuleNames` 에 `"Test"` 추가
- 주 게임 모듈의 캐릭터 클래스가 `TestActor.h` 를 include
- `BeginPlay()` 에서 `SpawnActor<ATestActor>()` 로 `Test` 모듈의 액터를 스폰
- `GEngine->AddOnScreenDebugMessage()` 로 뷰포트에 스폰 결과 출력

```cpp
ATestActor* Spawned = GetWorld()->SpawnActor<ATestActor>(
    ATestActor::StaticClass(), SpawnLocation, SpawnRotation);

if (Spawned && GEngine)
{
    GEngine->AddOnScreenDebugMessage(-1, 5.f, FColor::Green, TEXT("TestActor Spawned!"));
}
```

### `Temporary` 플러그인

- `Plugins/Temporary/` 에 위치한 독립 플러그인 (`CanContainContent: true`)
- `IModuleInterface` 를 상속한 `FTemporaryModule` 을 직접 구현
- `Temporary.cpp` 에서 `IMPLEMENT_MODULE(FTemporaryModule, Temporary)` 로 구현
- `.uproject` 의 `Plugins` 에 `Enabled: true` 로 등록됨

```cpp
void FTemporaryModule::StartupModule()
{
    UE_LOG(LogTemp, Warning, TEXT("Temporary Module Started!"));
}

void FTemporaryModule::ShutdownModule()
{
    UE_LOG(LogTemp, Warning, TEXT("Temporary Module Shutdown!"));
}

IMPLEMENT_MODULE(FTemporaryModule, Temporary)
```

---

## 동작 확인

| 확인 항목 | 위치 | 결과 |
| --- | --- | --- |
| `TestActor` 스폰 메시지 | 뷰포트 좌상단 | ✅ |
| 모듈 간 참조 로그 | Output Log | ✅ |
| `Temporary` 플러그인 등록 | Edit > Plugins | ✅ |
| 플러그인 콘텐츠 폴더 | Content Browser | ✅ |
| `StartupModule` 로그 | Output Log (`Temporary Module Started!`) | ✅ |

<p>
  <img src="https://github.com/user-attachments/assets/d37662e4-f46d-4a02-ba8d-e6e7cc8521e1" width="49%" />
  <img src="https://github.com/user-attachments/assets/a3c5b7c0-fecf-47a3-ac41-652836173ab6" width="49%" />
</p>

<p>
  <img src="https://github.com/user-attachments/assets/c02dbbbc-e33a-4fc3-88ce-ef236f216591" width="48%" />
  <img src="https://github.com/user-attachments/assets/d4c156c5-d03f-4bd9-93ef-1f3a5541b4fe" width="51%" />
</p>

---

## 프로젝트 구조

```
Assignment10/
├── Config/
├── Content/                       # TPS 템플릿 에셋
├── Plugins/
│   └── Temporary/                 # 독립 플러그인
│       ├── Temporary.uplugin
│       └── Source/Temporary/
├── Source/
│   ├── Assignment10/              # 주 게임 모듈
│   └── Test/                      # 추가 모듈
├── .gitignore
└── Assignment10.uproject
```
