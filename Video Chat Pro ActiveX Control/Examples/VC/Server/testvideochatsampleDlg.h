// testvideochatsampleDlg.h : header file
//
//{{AFX_INCLUDES()
#include "videochatserver.h"
//}}AFX_INCLUDES

#if !defined(AFX_TESTVIDEOCHATSAMPLEDLG_H__1602FCC8_5A9A_4275_B340_48A6C7D27A03__INCLUDED_)
#define AFX_TESTVIDEOCHATSAMPLEDLG_H__1602FCC8_5A9A_4275_B340_48A6C7D27A03__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CTestvideochatsampleDlg dialog

class CTestvideochatsampleDlg : public CDialog
{
// Construction
public:
	CTestvideochatsampleDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CTestvideochatsampleDlg)
	enum { IDD = IDD_TESTVIDEOCHATSAMPLE_DIALOG };
	CEdit	m_edtSelectedUserID;
	CEdit	m_edtConference;
	CButton	m_btnAdd;
	CButton	m_btnCreate;
	CListBox	m_listUserID;
	CButton	m_chkUseRandomNumber;
	CEdit	m_edtPortNO;
	CVideoChatServer	m_VideoChatServer;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTestvideochatsampleDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CTestvideochatsampleDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnButton1();
	afx_msg void OnButton2();
	afx_msg void OnClientConnectedVideochatserverctrl1(long iConfNumber, long iUserID);
	afx_msg void OnClientDisconnectedVideochatserverctrl1(long iConfNumber, long iUserID);
	afx_msg void OnAllClientDisconnectedVideochatserverctrl1(long iConfNumber);
	afx_msg void OnSelchangeList1();
	afx_msg void OnDestroy();
	afx_msg void OnClose();
	DECLARE_EVENTSINK_MAP()
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_TESTVIDEOCHATSAMPLEDLG_H__1602FCC8_5A9A_4275_B340_48A6C7D27A03__INCLUDED_)
