// DotNetAutomationNative.cpp : Defines the exported functions for the DLL.
//

#include "framework.h"
#include "DotNetAutomationNative.h"
// Provided by the AppHost NuGet package and installed as an SDK pack

#include <string>
#include "../AppPartOps/Journaling_Session.h"
#include "../AppPartOps/Journaling_Part.h"
#include "../Core/Core.h"


extern void DotNet_automationapi_Session_InitializeSession(void)
{
	// calling initializeProduct method in core.cpp
	initializeProduct();

}



extern int DotNet_automationapi_Session_MakePart(char* partPath)
{
	std::string partFilePath = std::string(partPath);
	int guid = 0;

	Application::PartFile* partFile = Journaling_Session_MakePart(partFilePath);

	guid = partFile->GetGuid();

	return guid;
}

void DotNet_automationapi_Part_Save(int guid)
{
	Application::PartFile* part = dynamic_cast<Application::PartFile*>(GuidObjectManager::GetGuidObjectManager().GetObjectFromGUID(guid));
	if (part == nullptr)
	{
		throw std::exception("not able to retrieve Part Object");
	}
	else
	{
		Journaling_Part_Save(part);
	}
}
