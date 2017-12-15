#undef UNICODE
#undef _UNICODE
#include <Windows.h>
#pragma comment(linker,"/subsystem:windows")

#include <stdio.h>
#include <tchar.h>

constexpr TCHAR szClass[] = _T("ECOURSE_CLASS");
constexpr TCHAR szTitle[] = _T("ecourse.co.kr");


LRESULT __stdcall WndProc(HWND hwnd, UINT msg, WPARAM wp, LPARAM lp)
{
	switch (msg)
	{
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	}
	return DefWindowProc(hwnd, msg, wp, lp);
}

int __stdcall WinMain( HINSTANCE hInstance, HINSTANCE hPrev, LPTSTR cmdLine, int nShowCmd)
{
	WNDCLASS wc = { 0 };
	wc.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
	wc.hCursor = LoadCursor(0, IDC_ARROW);
	wc.hIcon = LoadIcon(0, IDI_WINLOGO);
	wc.lpfnWndProc = WndProc;
	wc.lpszClassName = szClass;
	wc.lpszMenuName = 0;

	RegisterClass(&wc);

	HWND hwnd = CreateWindowEx(WS_EX_TOPMOST, szClass, szTitle, WS_OVERLAPPEDWINDOW, 
		CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT, 0, 0, GetModuleHandle(0), 0);

	ShowWindow(hwnd, SW_SHOW);
	UpdateWindow(hwnd);
	
	MSG msg;
	while (GetMessage(&msg, 0, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	return msg.wParam;
}