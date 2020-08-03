#if !defined(AFX_DLGSET_H__F9C8A13F_B826_43D9_953B_C8D621F54195__INCLUDED_)
#define AFX_DLGSET_H__F9C8A13F_B826_43D9_953B_C8D621F54195__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// DlgSet.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CDlgSet dialog
#include "testvideochatsampleDlg.h"

class CDlgSet : public CDialog
{
// Construction
public:
	CDlgSet(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CDlgSet)
	enum { IDD = IDD_DIALOG1 };
	CStatic	m_StaticListenIP;
	CStatic	m_StaticConnectIP;
	int		m_iType;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CDlgSet)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual BOOL OnCommand(WPARAM wParam, LPARAM lParam);
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;
	// Generated message map functions
	//{{AFX_MSG(CDlgSet)
	afx_msg void OnButton1();
	virtual BOOL OnInitDialog();
	afx_msg void OnRadio2();
	afx_msg void OnRadiovideochattype();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DLGSET_H__F9C8A13F_B826_43D9_953B_C8D621F54195__INCLUDED_)
