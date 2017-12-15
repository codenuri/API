#undef UNICODE
#undef _UNICODE
#pragma comment(linker,"/subsystem:windows")
#include <Windows.h>
#include <stdio.h>
#include <string.h>
#include <tchar.h>
using namespace std;

#define IDM_VISIBLE	0x1000
#define IDM_STYLE	0x2000

constexpr TCHAR szTarget[] =_T("ConsoleWindowClass");
constexpr TCHAR szClass[] = _T("ECOURSE_CONSOLE");
constexpr TCHAR szTitle[] = _T("ecourse.co.kr");



void ResetStyle(HWND hwnd, DWORD style)
{
	SetWindowLong(hwnd, GWL_STYLE, style);
	SetWindowPos(hwnd, 0, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_DRAWFRAME);
}

void ModifyStyle(HWND hwnd, UINT remove, UINT add)
{
	UINT style = GetWindowLong(hwnd, GWL_STYLE);

	style = style & ~remove;
	style = style | add;

	ResetStyle(hwnd, style);
}



struct CONSOLE
{
	HWND hwnd = 0;
	HWND phwnd = 0;
	DWORD style = 0;
};
CONSOLE console;

void ResizeConsole(HWND hwnd)
{
	RECT rc;
	GetClientRect(hwnd, &rc);

	MoveWindow(console.hwnd , 30, 0, rc.right+10, rc.bottom, TRUE);
}
void AttachConsole(HWND hwnd, HWND hConsole)
{
	//--------------------------------------------------
	console.hwnd = hConsole;
	console.phwnd = GetParent(hConsole);
	console.style = GetWindowLong(hConsole, GWL_STYLE);
	//--------------------------------------------------

	int style = (console.style  & ~WS_CAPTION & ~WS_THICKFRAME) | WS_CHILD;
	ResetStyle(console.hwnd, style);

	ResizeConsole(hwnd);

	InvalidateRect(console.hwnd, 0, TRUE);
	SetParent(console.hwnd, hwnd);
	SetFocus(console.hwnd);
}

void VisibleToggle(HWND hwnd)
{
	static BOOL bShow = TRUE;
	bShow = !bShow;

	ShowWindow(hwnd, bShow ? SW_SHOW : SW_HIDE);
	SetForegroundWindow(hwnd);
	InvalidateRect(console.hwnd, 0, TRUE);
//	UpdateWindow(console.hwnd);

//	if (bShow)
//		SetFocus(hwnd);
}


void StyleToggle(HWND hwnd)
{
	static BOOL bStyle = TRUE;
	bStyle = !bStyle;

	UINT style = WS_CAPTION | WS_THICKFRAME;

	if (!bStyle)
	{
		ModifyStyle(hwnd, style, 0);
	}
	else
	{
		ModifyStyle(hwnd, 0, style);
	}
}
  
LRESULT __stdcall WndProc(HWND hwnd, UINT msg, WPARAM wp, LPARAM lp)
{
	switch (msg)
	{
	case WM_CREATE:
	{
		BOOL b = RegisterHotKey(hwnd, IDM_VISIBLE, MOD_CONTROL , '1');
		if (b == FALSE)
			MessageBoxA(0, "Fail Register HotKey : 1", "error", 0);

		b = RegisterHotKey(hwnd, IDM_STYLE, MOD_CONTROL, '0');
		if (b == FALSE)
			MessageBoxA(0, "Fail Register HotKey : 0", "error", 0);
	}
	break;

	case WM_HOTKEY:
		if (wp == IDM_VISIBLE)
			VisibleToggle(hwnd);
		else if (wp == IDM_STYLE)
			StyleToggle(hwnd);
	break;




	case WM_NCHITTEST:
		if ( console.hwnd )
		{
			int code = DefWindowProc(hwnd, msg, wp, lp);

			if (code == HTCLIENT)
				code = HTCAPTION;
			return code;
		}
		break;

	case WM_LBUTTONDOWN:
		if ( console.hwnd == 0 )
			SetCapture(hwnd);
		break;

	case WM_LBUTTONUP:
		if (GetCapture() == hwnd)
		{
			ReleaseCapture();

			POINT pt;
			GetCursorPos(&pt);

			HWND hConsole = WindowFromPoint(pt);

			char name[256] = { 0 };
			GetClassName(hConsole, name, 256);

			if (strcmp(name, szTarget) == 0)
			{
				AttachConsole(hwnd, hConsole);
			}
		}
		break;
		
	case WM_SETFOCUS:
		if (console.hwnd)
		{
			SetFocus(console.hwnd);
		}
		break;

	case WM_SIZE:
		if (console.hwnd)
		{
			ResizeConsole(hwnd);
		}
		break;

	case WM_DESTROY:
		if ( console.hwnd != 0)
		{
			// console Ã¢ º¹±¸
			SetWindowLong(console.hwnd, GWL_STYLE, console.style);
			SetParent(console.hwnd, console.phwnd);
		}
		PostQuitMessage(0);
		break;
		
		
	}
	return DefWindowProc(hwnd, msg, wp, lp);
}

int __stdcall WinMain(HINSTANCE hInstance, HINSTANCE hPrev, LPTSTR cmdLine, int nShowCmd)
{
	WNDCLASS wc = { 0 };
	wc.hbrBackground = CreateSolidBrush(RGB(1, 36, 86));
	wc.hCursor = LoadCursor(0, IDC_ARROW);
	wc.hIcon = 0;//LoadIcon(0, IDI_WINLOGO);
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