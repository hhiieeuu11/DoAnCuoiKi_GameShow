// DlgSet.cpp : implementation file
//

#include "stdafx.h"
#include "testvideochatsample.h"
#include "DlgSet.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	//{{AFX_DATA(CAboutDlg)
	enum { IDD = IDD_ABOUTBOX };
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
	//{{AFX_DATA_INIT(CAboutDlg)
	//}}AFX_DATA_INIT
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAboutDlg)
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
	//{{AFX_MSG_MAP(CAboutDlg)
		// No message handlers
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CDlgSet dialog


CDlgSet::CDlgSet(CWnd* pParent /*=NULL*/)
	: CDialog(CDlgSet::IDD, pParent)
{
	//{{AFX_DATA_INIT(CDlgSet)
	m_iType =0;
	//}}AFX_DATA_INIT
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}


void CDlgSet::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CDlgSet)
	DDX_Control(pDX, IDC_STATICLISTENIP, m_StaticListenIP);
	DDX_Control(pDX, IDC_STATICCONNECTIP, m_StaticConnectIP);
	DDX_Radio(pDX, IDC_RADIOVIDEOCHATTYPE, m_iType);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CDlgSet, CDialog)
	//{{AFX_MSG_MAP(CDlgSet)
	ON_BN_CLICKED(IDC_BUTTON1, OnButton1)
	ON_BN_CLICKED(IDC_RADIO2, OnRadio2)
	ON_BN_CLICKED(IDC_RADIOVIDEOCHATTYPE, OnRadiovideochattype)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CDlgSet message handlers

void CDlgSet::OnButton1() 
{
	// TODO: Add your control notification handler code here

	GetDlgItemText(IDC_EDITCONNECTIP,strIPAddress);
	GetDlgItemText(IDC_EDITLISTENIP,strListenIPAddress);
	
	
	GetDlgItemText(IDC_EDITPORTNO,strPort);
	GetDlgItemText(IDC_EDITCONFNO,strConfNo);
	GetDlgItemText(IDC_EDITUSERID,strUserID);
	if(strIPAddress.IsEmpty())
	{
		AfxMessageBox("Please input IP Address");
		return ;
	}

	UpdateData(TRUE);

	if(m_iType==0)
	if(strListenIPAddress.IsEmpty() || strListenIPAddress=="0")
	{
		AfxMessageBox("Please input Listen IP Address");
		return ;
	}

	if(strPort.IsEmpty())
	{
		AfxMessageBox("Please input Port No");
		return ;
	}
	if(strConfNo.IsEmpty())
	{
		AfxMessageBox("Please input Conference Number");
		return ;
	}
	if(strUserID.IsEmpty())
	{
		AfxMessageBox("Please input User ID");
		return ;
	}
	this->ShowWindow(false);
	CTestvideochatsampleDlg dlg;
	dlg.DoModal();

	PostMessage(WM_CLOSE,0);
/*	if(dlg.DoModal() == IDOK)
	{
		
		
	}*/
}

BOOL CDlgSet::OnCommand(WPARAM wParam, LPARAM lParam) 
{
	// TODO: Add your specialized code here and/or call the base class
	
	return CDialog::OnCommand(wParam, lParam);
}

BOOL CDlgSet::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	// TODO: Add extra initialization here
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}
	
	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);

	GetDlgItem(IDC_EDITCONNECTIP)->SetWindowText("127.0.0.1");
	GetDlgItem(IDC_EDITLISTENIP)->SetWindowText("127.0.0.1");

	GetDlgItem(IDC_EDITPORTNO)->SetWindowText("1234");
	GetDlgItem(IDC_EDITCONFNO)->SetWindowText("0");
	GetDlgItem(IDC_EDITUSERID)->SetWindowText("0");



	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CDlgSet::OnRadio2() 
{
	// TODO: Add your control notification handler code here
	this->m_StaticConnectIP.SetWindowText("IP address of Video Chat Pro server");
	GetDlgItem(IDC_EDITCONFNO)->SetWindowText("5000");
	GetDlgItem(IDC_EDITUSERID)->SetWindowText("10000");

	GetDlgItem(IDC_EDITLISTENIP)->SetWindowText("0");
	GetDlgItem(IDC_EDITLISTENIP)->EnableWindow(FALSE);



	GetDlgItem(IDC_EDITCONFNO)->EnableWindow(TRUE);
	GetDlgItem(IDC_EDITUSERID)->EnableWindow(TRUE);



}

void CDlgSet::OnRadiovideochattype() 
{
	// TODO: Add your control notification handler code here
	this->m_StaticConnectIP.SetWindowText("Stream to IP address");

	GetDlgItem(IDC_EDITLISTENIP)->EnableWindow(TRUE);



	GetDlgItem(IDC_EDITCONFNO)->EnableWindow(FALSE);
	GetDlgItem(IDC_EDITUSERID)->EnableWindow(FALSE);


}
