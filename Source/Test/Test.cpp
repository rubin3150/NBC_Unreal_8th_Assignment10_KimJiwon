#include "Test.h"

// Test 모듈 진입점. 모듈 시작/종료 시 별도 처리가 필요 없으므로 커스텀 IModuleInterface 대신 엔진 기본 구현(FDefaultModuleImpl)을 사용
IMPLEMENT_MODULE(FDefaultModuleImpl, Test);
