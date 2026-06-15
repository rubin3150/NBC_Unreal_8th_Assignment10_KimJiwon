#include "Temporary.h"

void FTemporaryModule::StartupModule()
{
    UE_LOG(LogTemp, Warning, TEXT("Temporary Module Started!"));
}

void FTemporaryModule::ShutdownModule()
{
    UE_LOG(LogTemp, Warning, TEXT("Temporary Module Shutdown!"));
}

// 이 플러그인의 모듈 구현체를 Temporary 모듈로 엔진에 등록
IMPLEMENT_MODULE(FTemporaryModule, Temporary)