// This file defines the exported functions for the DotNetAutomationNative DLL.

#include "framework.h"
#include "DotNetAutomationNative.h"

// The AppHost NuGet package provides this SDK pack.
#include <string>

// Include header files for other project files.
#include "../AppPartOps/Journaling_Session.h"
#include "../AppPartOps/Journaling_Part.h"
#include "../Core/Core.h"

// Initialize a DotNet automation session by calling initializeProduct method in core.cpp.
extern void DotNet_automationapi_Session_InitializeSession(void)
{
initializeProduct();
}

// Create a new part file for the given part path and return the GUID.
extern int DotNet_automationapi_Session_MakePart(char* partPath)
{
std::string partFilePath = std::string(partPath);
int guid = 0;
// Call Journaling_Session_MakePart() to create a new part file.
Application::PartFile* partFile = Journaling_Session_MakePart(partFilePath);

// Get the GUID of the new part file.
guid = partFile->GetGuid();

return guid;
}

// Save the specified part file by calling Journaling_Part_Save().
void DotNet_automationapi_Part_Save(int guid)
{
// Get the part object corresponding to the given GUID.
Application::PartFile* part = dynamic_castApplication::PartFile*(GuidObjectManager::GetGuidObjectManager().GetObjectFromGUID(guid));
// Throw an exception if the part object could not be retrieved.
if (part == nullptr)
{
    throw std::exception("not able to retrieve Part Object");
}
// Otherwise, save the part file by calling Journaling_Part_Save().
else
{
    Journaling_Part_Save(part);
}
// Throw an exception if the part object could not be retrieved.
if (part == nullptr)
{
    throw std::exception("not able to retrieve Part Object");
}
// Otherwise, save the part file by calling Journaling_Part_Save().
else
{
    Journaling_Part_Save(part);
}
}