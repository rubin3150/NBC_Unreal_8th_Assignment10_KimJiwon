// Fill out your copyright notice in the Description page of Project Settings.


#include "TestActor.h"

// Sets default values
ATestActor::ATestActor()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void ATestActor::BeginPlay()
{
	Super::BeginPlay();

	// 액터가 정상적으로 스폰되어 BeginPlay까지 도달했는지 확인용 로그
	UE_LOG(LogTemp, Warning, TEXT("TestActor BeginPlay"));
}

// Called every frame
void ATestActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

