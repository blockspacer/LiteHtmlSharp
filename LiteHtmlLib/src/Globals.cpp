#include "Globals.h"

#include "DocContainer.h"

std::vector<DocContainer*> _containers;

__declspec(dllexport) void SetDrawBorders(DocContainer* container, DrawBorders_function callback)
{
   container->DrawBorders = callback;
}

__declspec(dllexport) void SetDrawBackground(DocContainer* container, DrawBackground_function callback)
{
   container->DrawBackground = callback;
}

__declspec(dllexport) void SetGetImageSize(DocContainer* container, GetImageSize_function callback)
{
   container->GetImageSize = callback;
}

__declspec(dllexport) void SetTestCallback(DocContainer* container, Test_function callback)
{
   container->TestCallback = callback;
}

__declspec(dllexport) void TriggerTestCallback(DocContainer* container, const litehtml::tchar_t* testString)
{
   container->TestCallback(testString);
}

__declspec(dllexport) void SetTestFunction(Test_function callback)
{
   callback(_T("xxx test string"));
}

__declspec(dllexport) DocContainer* Init()
{
   DocContainer* container = new DocContainer();
   _containers.push_back(container);
   return container;
}

__declspec(dllexport) void RenderHTML(DocContainer* container, const litehtml::tchar_t* html)
{
   container->RenderHTML(html);
}

__declspec(dllexport) void SetMasterCSS(DocContainer* container, const litehtml::tchar_t* css)
{
   container->SetMasterCSS(css);
}

__declspec(dllexport) bool OnMouseMove(DocContainer* container, int x, int y)
{
   return container->OnMouseMove(x, y);
}

__declspec(dllexport) void Draw(DocContainer* container)
{
   container->Draw();
}

__declspec(dllexport) void SetCreateFont(DocContainer* container, CreateFont_function callback)
{
   container->CreateFont = callback;
}

__declspec(dllexport) void SetGetTextWidth(DocContainer* container, GetTextWidth_function callback)
{
   container->GetTextWidth = callback;
}

__declspec(dllexport) void SetDrawText(DocContainer* container, DrawText_function callback)
{
   container->DrawText = callback;
}

__declspec(dllexport) void SetImportCss(DocContainer* container, ImportCss_function callback)
{
   container->ImportCss = callback;
}

__declspec(dllexport) void SetGetClientRect(DocContainer* container, GetClientRect_function callback)
{
   container->GetClientRect = callback;
}

__declspec(dllexport) void SetGetMediaFeatures(DocContainer* container, GetMediaFeatures_function callback)
{
   container->GetMediaFeatures = callback;
}