#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleManager.h"

// Temporary 플러그인 모듈. 모듈 로드/언로드 시점에 동작을 넣기 위해 기본 구현 대신 IModuleInterface를 직접 구현
class FTemporaryModule : public IModuleInterface
{
public:
    // 모듈이 메모리에 로드될 때 호출
    virtual void StartupModule() override;
    // 모듈이 언로드될 때 호출
    virtual void ShutdownModule() override;
};