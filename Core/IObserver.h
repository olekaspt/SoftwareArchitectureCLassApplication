#pragma once
#include "CoreExports.h"
#include <string>

/// <summary>
/// Observer interface class
/// 
/// Inspired from - https://refactoring.guru/design-patterns/observer/cpp/example
/// </summary>
class CORE_API IObserver {
public:
    enum EventTypes
    {
        SavePart =0,
        OpenPart =1,
        ClosePart =2,
        CreatePart =4
    };

    virtual ~IObserver() {};
    virtual void Update(const std::string& message_from_subject) = 0;
    virtual void Update(const std::string& message_from_subject, void* data) = 0;
};