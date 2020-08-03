// testvideochatsample.h : main header file for the TESTVIDEOCHATSAMPLE application
//

#if !defined(AFX_TESTVIDEOCHATSAMPLE_H__D2DF8335_2E2E_4517_8902_72FEABDFF2E9__INCLUDED_)
#define AFX_TESTVIDEOCHATSAMPLE_H__D2DF8335_2E2E_4517_8902_72FEABDFF2E9__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CTestvideochatsampleApp:
// See testvideochatsample.cpp for the implementation of this class
//

class CTestvideochatsampleApp : public CWinApp
{
public:
	CTestvideochatsampleApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTestvideochatsampleApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CTestvideochatsampleApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_TESTVIDEOCHATSAMPLE_H__D2DF8335_2E2E_4517_8902_72FEABDFF2E9__INCLUDED_)
