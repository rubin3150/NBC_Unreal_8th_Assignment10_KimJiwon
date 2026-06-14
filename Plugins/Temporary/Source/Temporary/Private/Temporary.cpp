#include "Temporary.h"

void FTemporaryModule::StartupModule()
{
    UE_LOG(LogTemp, Warning, TEXT("Temporary Module Started!"));
}

void FTemporaryModule::ShutdownModule()
{
    UE_LOG(LogTemp, Warning, TEXT("Temporary Module Shutdown!"));
}

IMPLEMENT_MODULE(FTemporaryModule, Temporary)