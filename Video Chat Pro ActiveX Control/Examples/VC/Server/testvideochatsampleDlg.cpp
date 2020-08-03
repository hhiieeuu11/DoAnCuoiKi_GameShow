// testvideochatsampleDlg.cpp : implementation file
//

#include "stdafx.h"
#include "testvideochatsample.h"
#include "testvideochatsampleDlg.h"

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
// CTestvideochatsampleDlg dialog

CTestvideochatsampleDlg::CTestvideochatsampleDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CTestvideochatsampleDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CTestvideochatsampleDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CTestvideochatsampleDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CTestvideochatsampleDlg)
	DDX_Control(pDX, IDC_EDIT3, m_edtSelectedUserID);
	DDX_Control(pDX, IDC_EDIT2, m_edtConference);
	DDX_Control(pDX, IDC_BUTTON2, m_btnAdd);
	DDX_Control(pDX, IDC_BUTTON1, m_btnCreate);
	DDX_Control(pDX, IDC_LIST1, m_listUserID);
	DDX_Control(pDX, IDC_CHECK1, m_chkUseRandomNumber);
	DDX_Control(pDX, IDC_EDIT1, m_edtPortNO);
	DDX_Control(pDX, IDC_VIDEOCHATSERVERCTRL1, m_VideoChatServer);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CTestvideochatsampleDlg, CDialog)
	//{{AFX_MSG_MAP(CTestvideochatsampleDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON1, OnButton1)
	ON_BN_CLICKED(IDC_BUTTON2, OnButton2)
	ON_LBN_SELCHANGE(IDC_LIST1, OnSelchangeList1)
	ON_WM_DESTROY()
	ON_WM_CLOSE()
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CTestvideochatsampleDlg message handlers

BOOL CTestvideochatsampleDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
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
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here
	m_btnCreate.EnableWindow(true);
	m_btnAdd.EnableWindow(false);
	m_chkUseRandomNumber.SetCheck(1);
	m_edtPortNO.SetWindowText("1234");
	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CTestvideochatsampleDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CTestvideochatsampleDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CTestvideochatsampleDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

void CTestvideochatsampleDlg::OnButton1() 
{
	// TODO: Add your control notification handler code here
	CString strPort;
	m_edtPortNO.GetWindowText(strPort);
	if(strPort.IsEmpty())
	{
		AfxMessageBox("Please input Port No");
		return;
	}
	m_VideoChatServer.InitServer(atol(strPort),300);
	if(m_chkUseRandomNumber.GetCheck() == 1)
	{
		m_VideoChatServer.SetUseRandomNumber(true);
	}
	else
	{
		m_VideoChatServer.SetUseRandomNumber(false);
	}
	CString strConference;
	long iConference = m_VideoChatServer.CreateConference();
	strConference.Format("%ld",iConference);
	m_edtConference.SetWindowText(strConference);
	m_listUserID.ResetContent();

	m_btnCreate.EnableWindow(false);
	m_btnAdd.EnableWindow(true);

}

void CTestvideochatsampleDlg::OnButton2() 
{
	// TODO: Add your control notification handler code here
	CString strConf;
	this->m_edtConference.GetWindowText(strConf);
	if(strConf.IsEmpty())
	{
		AfxMessageBox("Please Create Conference");
		return;
	}
	long iUserID = m_VideoChatServer.AddUser(atol(strConf));

	
	CString strUserID;
	if(iUserID != 0)
	{
		strUserID.Format("%ld",iUserID);
		m_listUserID.AddString(strUserID);
	}
	else
	{
		AfxMessageBox("Max is 12 user per Room");
	}
}

BEGIN_EVENTSINK_MAP(CTestvideochatsampleDlg, CDialog)
    //{{AFX_EVENTSINK_MAP(CTestvideochatsampleDlg)
	ON_EVENT(CTestvideochatsampleDlg, IDC_VIDEOCHATSERVERCTRL1, 1 /* ClientConnected */, OnClientConnectedVideochatserverctrl1, VTS_I4 VTS_I4)
	ON_EVENT(CTestvideochatsampleDlg, IDC_VIDEOCHATSERVERCTRL1, 2 /* ClientDisconnected */, OnClientDisconnectedVideochatserverctrl1, VTS_I4 VTS_I4)
	//}}AFX_EVENTSINK_MAP
END_EVENTSINK_MAP()

void CTestvideochatsampleDlg::OnClientConnectedVideochatserverctrl1(long iConfNumber, long iUserID) 
{
	// TODO: Add your control notification handler code here
	int iCount = m_listUserID.GetCount();
	CString strListUserID;
	CString strUserID;
	strUserID.Format("%ld",iUserID);
	for(int i= 0;i<iCount;i++)
	{
		m_listUserID.GetText(i,strListUserID);
		
		if(strListUserID == strUserID)
		{
			strListUserID = strUserID + "***";
			m_listUserID.DeleteString(i);
			m_listUserID.InsertString(i,strListUserID);
		}
	}
}

void CTestvideochatsampleDlg::OnClientDisconnectedVideochatserverctrl1(long iConfNumber, long iUserID) 
{
	// TODO: Add your control notification handler code here
	int iCount = m_listUserID.GetCount();
	CString strListUserID;
	CString strUserID;
	strUserID.Format("%ld",iUserID);
	for(int i= 0;i<iCount;i++)
	{
		m_listUserID.GetText(i,strListUserID);
		if(strListUserID == strUserID+"***")
		{
			strListUserID = strUserID;
			m_listUserID.DeleteString(i);
			m_listUserID.InsertString(i,strListUserID);
		}
	}
}

void CTestvideochatsampleDlg::OnAllClientDisconnectedVideochatserverctrl1(long iConfNumber) 
{
	// TODO: Add your control notification handler code here
	AfxMessageBox("All client disconnected");
	m_listUserID.ResetContent();
}

void CTestvideochatsampleDlg::OnSelchangeList1() 
{
	// TODO: Add your control notification handler code here
	CString strUserID;
	m_listUserID.GetText(m_listUserID.GetCurSel(),strUserID);
	m_edtSelectedUserID.SetWindowText(strUserID);
}

void CTestvideochatsampleDlg::OnDestroy() 
{
	CDialog::OnDestroy();
	
	// TODO: Add your message handler code here

}

void CTestvideochatsampleDlg::OnClose() 
{
	// TODO: Add your message handler code here and/or call default
		m_VideoChatServer.UnInitServer();
	CDialog::OnClose();
}
