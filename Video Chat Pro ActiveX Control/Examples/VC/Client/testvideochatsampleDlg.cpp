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
// CTestvideochatsampleDlg dialog

CTestvideochatsampleDlg::CTestvideochatsampleDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CTestvideochatsampleDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CTestvideochatsampleDlg)
	m_iVideoBitrate = 528000;
	m_strConnectIP = _T("127.0.0.1");
	m_iConnectPortNo = 7000;
	m_iFrameRate = 25;
	m_bSendVideo = TRUE;
	m_bSendAudio = TRUE;
	m_bReceiveVideo = TRUE;
	m_bReceiveAudio = TRUE;
	m_bPopUp = FALSE;
	m_iLeft = 0;
	m_iTop = 0;
	m_iWidth = 100;
	m_iHeight = 100;
	m_strNoVideoImage = _T("");
	m_ivLeft = 0;
	m_ivTop = 0;
	m_ivWidth = 640;
	m_ivHeight = 480;
	m_bvFullScreen = TRUE;
	m_iMP4Width = 720;
	m_iMP4Height = 480;
	m_iMP4AudioChannel = 2;
	m_iMP4VideoBitrate = 4600000;
	m_iMP4AudioBitrate = 96000;
	m_iMP4Framerate = 25;
	m_iMP4Audiosamplerate = 44100;
	m_iAspectRatioType =0;
	m_iOutputFileType = 0;
	m_bMaxFirstVideo = FALSE;
	m_bCaptureToFile = FALSE;
	m_strCustomCursor = _T("");
	m_bUseSysCursor = TRUE;
	m_iIndexVideoWnd = 0;
	m_strPeertoPeerListenIP = _T("");
	m_bDefaultVMR1 = TRUE;
	m_bDefaultVMR2 = TRUE;
	m_bMouseHighlight = FALSE;
	m_iLightR = 255;
	m_iLightG = 100;
	m_iLightB = 0;
	m_iFadeIn = 0.1;
	m_iFadeOut = 0.4;
	m_strChatMessage = _T("Enter your message");
	m_iTextAlpha = 255;
	m_iBgTextAlpha = 255;
	m_iChatX = 0;
	m_iChatY = 0;
	m_iChatSpeed = 4;
	m_iOverlayImageAlpha = 255;
	m_strOverlayImageFile = _T("");
	m_iOverlayImageX = 0;
	m_iOverlayImageY = 0;
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	//m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
	m_bClickChangeVideoFormat=FALSE;
	m_clrCursorHighlight=RGB(255,0,0);

	m_clrLeftClick = RGB(255,0,0);
	m_clrRightClick = RGB(0,0,255);

}

void CTestvideochatsampleDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CTestvideochatsampleDlg)
	DDX_Control(pDX, IDC_CHKFILLBG, m_ChkChatFillBg);
	DDX_Control(pDX, IDC_CBOCHATDIR, m_CboChatDir);
	DDX_Control(pDX, IDC_CBOEFFECTTYPE, m_CboEffectType);
	DDX_Control(pDX, IDC_CBOSTATE, m_CboChatBannerState);
	DDX_Control(pDX, IDC_CBOFONTSTYLE, m_CboFontStyle);
	DDX_Control(pDX, IDC_CBOCHATFONTSIZE, m_CboFontSize);
	DDX_Control(pDX, IDC_CBOCHATFONT, m_CboFont);
	DDX_Control(pDX, IDC_CHKGRAYSCALE, m_ChkGrayScale);
	DDX_Control(pDX, IDC_CHKINVERTCOLOR, m_ChkInvert);
	DDX_Control(pDX, IDC_CBOROTATE, m_CboRotate);
	DDX_Control(pDX, IDC_EDITLISTENIP, m_edtListenIPAddress);
	DDX_Control(pDX, IDC_LIST1, m_ListEvent);
	DDX_Control(pDX, IDC_CHECK1, m_ChkvFullScreen);
	DDX_Control(pDX, IDC_EDIT8, m_EdtvHeight);
	DDX_Control(pDX, IDC_EDIT7, m_EdtvWidth);
	DDX_Control(pDX, IDC_EDIT5, m_EdtvTop);
	DDX_Control(pDX, IDC_EDIT2, m_EdtvLeft);
	DDX_Control(pDX, IDC_EDT_USER_ID, m_edtUserID);
	DDX_Control(pDX, IDC_EDT_CONF_NO, m_edtConfNo);
	DDX_Control(pDX, IDC_EDITCONNECTPORT, m_edtPortNo);
	DDX_Control(pDX, IDC_EDITCONNECTIP, m_edtIPAddress);
	DDX_Control(pDX, IDC_STATICAUDIOBITRATE, m_StaticAudioBitrate);
	DDX_Control(pDX, IDC_STATICVIDEOBITRATE, m_StaticVideoBitrate);
	DDX_Control(pDX, IDC_CBOAUDIOQUALITY, m_CboAudioQuality);
	DDX_Control(pDX, IDC_CBOAUDIOCOMPLEX, m_CboAudioComplex);
	DDX_Control(pDX, IDC_COMBO3, m_CboVideoFormat);
	DDX_Control(pDX, IDC_COMBO2, m_CboAudioDevice);
	DDX_Control(pDX, IDC_COMBO1, m_CboVideoDevice);
	DDX_Control(pDX, IDC_VIDEOCHATCTRL1, m_VideoChat);
	DDX_Text(pDX, IDC_EDITVIDEOBITRATE, m_iVideoBitrate);
	DDX_Text(pDX, IDC_EDITCONNECTIP, m_strConnectIP);
	DDX_Text(pDX, IDC_EDITCONNECTPORT, m_iConnectPortNo);
	DDX_Text(pDX, IDC_EDITFRAMERATE, m_iFrameRate);
	DDX_Check(pDX, IDC_CHECKSENDVIDEO, m_bSendVideo);
	DDX_Check(pDX, IDC_CHECKSENDAUDIO, m_bSendAudio);
	DDX_Check(pDX, IDC_CHECKRECVIDEO, m_bReceiveVideo);
	DDX_Check(pDX, IDC_CHECKRECAUDIO, m_bReceiveAudio);
	DDX_Text(pDX, IDC_EDIT1, m_strNoVideoImage);
	DDX_Control(pDX, IDC_VIDEOCHATRECEIVECTRL1, m_VideoChatListen);
	DDX_Text(pDX, IDC_EDIT2, m_ivLeft);
	DDX_Text(pDX, IDC_EDIT5, m_ivTop);
	DDX_Text(pDX, IDC_EDIT7, m_ivWidth);
	DDX_Text(pDX, IDC_EDIT8, m_ivHeight);
	DDX_Check(pDX, IDC_CHECK1, m_bvFullScreen);
	DDX_Text(pDX, IDC_EDITMP4WIDTH, m_iMP4Width);
	DDX_Text(pDX, IDC_EDITMP4HEIGHT, m_iMP4Height);
	DDX_Text(pDX, IDC_EDITAUDIOCHANNEL, m_iMP4AudioChannel);
	DDX_Text(pDX, IDC_EDITMP4VIDEOBITRATE, m_iMP4VideoBitrate);
	DDX_Text(pDX, IDC_EDITMP4AUDIOBITRATE, m_iMP4AudioBitrate);
	DDX_Text(pDX, IDC_EDITMP4FRAMERATE, m_iMP4Framerate);
	DDX_Text(pDX, IDC_EDITMP4AUDIOSAMPLERATE, m_iMP4Audiosamplerate);
	DDX_Radio(pDX, IDC_RADIOASPECTRATIO1, m_iAspectRatioType);
	DDX_Radio(pDX, IDC_RADIOOUTMP4, m_iOutputFileType);
	DDX_Check(pDX, IDC_CHKMAXFIRST, m_bMaxFirstVideo);
	DDX_Check(pDX, IDC_CHKCAPTUREFILE, m_bCaptureToFile);
	DDX_Text(pDX, IDC_EDITCUSTOMCURSOR, m_strCustomCursor);
	DDX_Check(pDX, IDC_CHKUSESYSCURSOR, m_bUseSysCursor);
	DDX_Text(pDX, IDC_EDITINDEXVIDEOWND, m_iIndexVideoWnd);
	DDX_Text(pDX, IDC_EDITLISTENIP, m_strPeertoPeerListenIP);
	DDX_Check(pDX, IDC_CHKVMRSENDER, m_bDefaultVMR1);
	DDX_Check(pDX, IDC_CHECKRECEIVEVIDEO, m_bDefaultVMR2);
	DDX_Check(pDX, IDC_CHKMOUSEHIGHLIGHT, m_bMouseHighlight);
	DDX_Text(pDX, IDC_EDITLIGHTR, m_iLightR);
	DDX_Text(pDX, IDC_EDITLIGHTG, m_iLightG);
	DDX_Text(pDX, IDC_EDITLIGHTB, m_iLightB);
	DDX_Text(pDX, IDC_EDITFADEIN, m_iFadeIn);
	DDX_Text(pDX, IDC_EDITFADEOUT, m_iFadeOut);
	DDX_Text(pDX, IDC_EDITCHATMESSAGE, m_strChatMessage);
	DDX_Text(pDX, IDC_EDITTEXTALPHA, m_iTextAlpha);
	DDX_Text(pDX, IDC_EDITBGALPHA, m_iBgTextAlpha);
	DDX_Text(pDX, IDC_EDITCHATX, m_iChatX);
	DDX_Text(pDX, IDC_EDITCHATY, m_iChatY);
	DDX_Text(pDX, IDC_EDITCHATSPEED, m_iChatSpeed);
	DDX_Text(pDX, IDC_EDITOVERLAYIMAGEALPHA, m_iOverlayImageAlpha);
	DDX_Text(pDX, IDC_EDITOVERLAYIMAGE, m_strOverlayImageFile);
	DDX_Text(pDX, IDC_EDITOVERLAYIMAGEX, m_iOverlayImageX);
	DDX_Text(pDX, IDC_EDITOVERLAYIMAGEY, m_iOverlayImageY);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CTestvideochatsampleDlg, CDialog)
	//{{AFX_MSG_MAP(CTestvideochatsampleDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON1, OnButton1)
	ON_BN_CLICKED(IDC_BUTTON3, OnButton3)
	ON_BN_CLICKED(IDC_BUTTON2, OnButton2)
	ON_BN_CLICKED(IDC_BUTTON4, OnButton4)
	ON_BN_CLICKED(IDC_CHECK1, OnCheck1)
	ON_BN_CLICKED(IDC_BUTTON5, OnButton5)
	ON_BN_CLICKED(IDC_BTNCHANGECAPAREA, OnBtnchangecaparea)
	ON_CBN_EDITCHANGE(IDC_COMBO1, OnEditchangeCombo1)
	ON_CBN_SELCHANGE(IDC_COMBO1, OnSelchangeCombo1)
	ON_BN_CLICKED(IDC_CHKCAPTUREFILE, OnChkcapturefile)
	ON_BN_CLICKED(IDC_BTNCURSORHIGHLIGHT, OnBtncursorhighlight)
	ON_BN_CLICKED(IDC_BTNLEFTCLICKCOLOR, OnBtnleftclickcolor)
	ON_BN_CLICKED(IDC_BTNRIGHTCLICKCOLOR, OnBtnrightclickcolor)
	ON_BN_CLICKED(IDC_CHKUSESYSCURSOR, OnChkusesyscursor)
	ON_BN_CLICKED(IDC_BTNSELCUSTOMCURSOR, OnBtnselcustomcursor)
	ON_BN_CLICKED(IDC_BTNSNAPSHOT, OnBtnsnapshot)
	ON_BN_CLICKED(IDC_BTNSHOWONE2ONE, OnBtnshowone2one)
	ON_BN_CLICKED(IDC_BTNCLOSEONE2ONE2, OnBtncloseone2one2)
	ON_CBN_SELCHANGE(IDC_CBOROTATE, OnSelchangeCborotate)
	ON_BN_CLICKED(IDC_CHKINVERTCOLOR, OnChkinvertcolor)
	ON_BN_CLICKED(IDC_CHKGRAYSCALE, OnChkgrayscale)
	ON_BN_CLICKED(IDC_BTNLIGHTNESSCHANGE, OnBtnlightnesschange)
	ON_BN_CLICKED(IDC_BTNLIGHTDEFAULT, OnBtnlightdefault)
	ON_BN_CLICKED(IDC_BUTTONFADETIME, OnButtonfadetime)
	ON_BN_CLICKED(IDC_BUTTONTEXTCOLOR, OnButtontextcolor)
	ON_BN_CLICKED(IDC_BUTTONBGCOLOR, OnButtonbgcolor)
	ON_BN_CLICKED(IDC_BUTTONCHATPOS, OnButtonchatpos)
	ON_BN_CLICKED(IDC_BUTTONCHATSPEED, OnButtonchatspeed)
	ON_BN_CLICKED(IDC_BUTTONCHATMSGSEND, OnButtonchatmsgsend)
	ON_BN_CLICKED(IDC_CHKFILLBG, OnChkfillbg)
	ON_CBN_SELCHANGE(IDC_CBOSTATE, OnSelchangeCbostate)
	ON_CBN_SELCHANGE(IDC_CBOCHATFONT, OnSelchangeCbochatfont)
	ON_CBN_SELCHANGE(IDC_CBOCHATFONTSIZE, OnSelchangeCbochatfontsize)
	ON_CBN_SELCHANGE(IDC_CBOFONTSTYLE, OnSelchangeCbofontstyle)
	ON_CBN_SELCHANGE(IDC_CBOEFFECTTYPE, OnSelchangeCboeffecttype)
	ON_BN_CLICKED(IDC_BTNSELOVERLAYIMAGE, OnBtnseloverlayimage)
	ON_BN_CLICKED(IDC_BTNOVERLAYIMAGETRANCOLOR, OnBtnoverlayimagetrancolor)
	ON_BN_CLICKED(IDC_BTNOVERLAYIMAGEDRAW, OnBtnoverlayimagedraw)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CTestvideochatsampleDlg message handlers

BOOL CTestvideochatsampleDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
/*	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
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
*/
	m_clrTranColor = RGB(0,0,0);
	m_edtIPAddress.SetWindowText(strIPAddress);
	m_edtPortNo.SetWindowText(strPort);
	m_edtConfNo.SetWindowText(strConfNo);
	m_edtUserID.SetWindowText(strUserID);
	m_edtListenIPAddress.SetWindowText(strListenIPAddress);

	// TODO: Add extra initialization here0
	
	TCHAR cAppPath[MAX_PATH];
	GetCurrentDirectory(MAX_PATH, cAppPath);
	m_strAppPath=CString(cAppPath) ;

	GetDlgItem(IDC_EDIT1)->SetWindowText(m_strAppPath+"\\novideo.bmp");

	GetDlgItem(IDC_EDITOVERLAYIMAGE)->SetWindowText(m_strAppPath+"\\image.bmp");


	GetDlgItem(IDC_EDITCUSTOMCURSOR)->SetWindowText(m_strAppPath+"\\Cursor\\hand-icon.ico");

	int iVideoDeviceCount = m_VideoChat.GetVideoDeviceCount();
	
	for(int i=0; i < iVideoDeviceCount-0; i++)
		m_CboVideoDevice.AddString(m_VideoChat.GetVideoDeviceName(i));

	m_CboVideoDevice.SetCurSel(0);

	int iAudioDeviceCount = m_VideoChat.GetAudioDeviceCount();
	for( i=0; i < iAudioDeviceCount-0; i++)
		m_CboAudioDevice.AddString(m_VideoChat.GetAudioDeviceName(i));

	m_CboAudioDevice.SetCurSel(0);


	m_CboVideoFormat.AddString("160x120");
	m_CboVideoFormat.AddString("176x144");
	m_CboVideoFormat.AddString("320x240");
	m_CboVideoFormat.AddString("352x288");
	m_CboVideoFormat.AddString("640x480");
	m_CboVideoFormat.AddString("1280x720");

	m_CboVideoFormat.SetCurSel(4);


	m_CboAudioComplex.AddString("0");
	m_CboAudioComplex.AddString("1");
	m_CboAudioComplex.AddString("2");
	m_CboAudioComplex.AddString("3");
	m_CboAudioComplex.SetCurSel(0);

	CString str;
	for(i=0;i<=10;i++)
	{
	str.Format("%d",i);
	m_CboAudioQuality.AddString(str);
	}	
	m_CboAudioQuality.SetCurSel(8);
	
	

	m_CboRotate.AddString("No Rotation");
	m_CboRotate.AddString("90-degree rotation without flipping");
	m_CboRotate.AddString("180-degree rotation without flipping");
	m_CboRotate.AddString("270-degree rotation without flipping");
    m_CboRotate.AddString("no rotation and a horizontal flip"); 
    m_CboRotate.AddString("90-degree rotation followed by a horizontal flip");
    m_CboRotate.AddString("180-degree rotation followed by a horizontal flip");
    m_CboRotate.AddString("270-degree rotation followed by a horizontal flip");
    m_CboRotate.AddString("no rotation and a vertical flip");
    m_CboRotate.AddString("90-degree rotation followed by a vertical flip");
    m_CboRotate.AddString("180-degree rotation followed by a vertical flip");
    m_CboRotate.AddString("270-degree rotation followed by a vertical flip");
    m_CboRotate.SetCurSel(0);

	m_CboFont.AddString("Arial");
	m_CboFont.AddString("Impact");
	m_CboFont.AddString("Comic Sans MS");
	m_CboFont.AddString("Courier New");
	m_CboFont.SetCurSel(0);

	int iFontSize;

	CString strFontSize;

	for(i=8;i<80;i++)
	{
		strFontSize.Format("%d",i);
		m_CboFontSize.AddString(strFontSize);
	}
	m_CboFontSize.SetCurSel(24);

	this->m_CboFontStyle.AddString("Regular");
	this->m_CboFontStyle.AddString("Bold");
	this->m_CboFontStyle.AddString("Italic");
	this->m_CboFontStyle.SetCurSel(0);

	m_CboChatBannerState.AddString("Scrolling Banner");
	m_CboChatBannerState.AddString("Stay");
	m_CboChatBannerState.AddString("Hide");
	m_CboChatBannerState.SetCurSel(0);

	m_CboEffectType.AddString("No Effects");
	m_CboEffectType.AddString("Overlay Effects");
	m_CboEffectType.AddString("Chat Banner Plugin");
	m_CboEffectType.SetCurSel(0);

	m_CboChatDir.AddString("Up");
	m_CboChatDir.AddString("Down");
	m_CboChatDir.AddString("Left");
	m_CboChatDir.AddString("Right");
	m_CboChatDir.SetCurSel(2);


	m_ChkChatFillBg.SetCheck(1);

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CTestvideochatsampleDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
/*	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}*/
	CDialog::OnSysCommand(nID, lParam);
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

void CTestvideochatsampleDlg::OnOK() 
{
	// TODO: Add extra validation here
	
	CDialog::OnOK();
}

void CTestvideochatsampleDlg::OnCancel() 
{
	// TODO: Add extra cleanup here
	
	CDialog::OnCancel();
}

void CTestvideochatsampleDlg::OnButton1() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);

	m_VideoChat.ChatBannerDirection(this->m_CboChatDir.GetCurSel());
	
	m_VideoChat.SetOverlayType(this->m_CboEffectType.GetCurSel());

	m_edtConfNo.GetWindowText(strConfNo);

	m_edtUserID.GetWindowText(strUserID);


	m_VideoChat.SetUseDefaultVMR(this->m_bDefaultVMR1);

	if(m_bvFullScreen)
	{
	
		m_VideoChat.VirtualScreenCaptureFullScreen(true);
 
	}
	else
	{

	
		m_VideoChat.VirtualScreenCaptureFullScreen(false);
		
		m_VideoChat.VirtualScreenCaptureArea(m_ivLeft,m_ivTop,m_ivWidth,m_ivHeight);
	}

	if(m_bMouseHighlight)
		m_VideoChat.VirtualScreenShowMouseHighlight(true);
	else
		m_VideoChat.VirtualScreenShowMouseHighlight(false);


	m_VideoChat.VirtualScreenHighlightColor(m_clrCursorHighlight);
	m_VideoChat.VirtualScreenLeftClickColor(m_clrLeftClick);
	m_VideoChat.VirtualScreenRightClickColor(m_clrRightClick);
	
	if(this->m_bUseSysCursor)
		m_VideoChat.VirtualScreenShowSystemCursor(TRUE);
	else
	{
		m_VideoChat.VirtualScreenShowSystemCursor(FALSE);
		m_VideoChat.VirtualScreenCursorFile(m_strCustomCursor);
	}

	m_VideoChat.SetVideoDevice(m_CboVideoDevice.GetCurSel());
	m_VideoChat.SetAudioDevice(m_CboAudioDevice.GetCurSel());


	m_VideoChat.SetVideoFormat(m_CboVideoFormat.GetCurSel());
	m_VideoChat.SetFrameRate(m_iFrameRate);
	m_VideoChat.SetVideoBitrate(m_iVideoBitrate);
	m_VideoChat.SetAudioComplexity(m_CboAudioComplex.GetCurSel());
	m_VideoChat.SetAudioQuality(m_CboAudioQuality.GetCurSel());


	m_VideoChat.SetSendVideoStream(m_bSendVideo);
	m_VideoChat.SetSendAudioStream(m_bSendAudio);

	m_VideoChat.SetConferenceNumber(atol(strConfNo));
	m_VideoChat.SetConferenceUserID(atol(strUserID));

	int iResult= m_VideoChat.Connect(m_strConnectIP,m_iConnectPortNo);

	
	int iSel= this->m_CboEffectType.GetCurSel();
	
	if(iSel==2)
	{
		ChatBannerControlEnable(TRUE);
		OnButtonchatmsgsend();

	}



}

BEGIN_EVENTSINK_MAP(CTestvideochatsampleDlg, CDialog)
    //{{AFX_EVENTSINK_MAP(CTestvideochatsampleDlg)
	ON_EVENT(CTestvideochatsampleDlg, IDC_VIDEOCHATCTRL1, 1 /* SendStream */, OnSendStreamVideochatctrl1, VTS_R4 VTS_R4)
	ON_EVENT(CTestvideochatsampleDlg, IDC_VIDEOCHATRECEIVECTRL1, 1 /* OnNewUserConnection */, OnOnNewUserConnectionVideochatreceivectrl1, VTS_I4 VTS_I4)
	ON_EVENT(CTestvideochatsampleDlg, IDC_VIDEOCHATRECEIVECTRL1, 2 /* OnUserConnectionLost */, OnOnUserConnectionLostVideochatreceivectrl1, VTS_I4 VTS_I4)
	//}}AFX_EVENTSINK_MAP
END_EVENTSINK_MAP()

void CTestvideochatsampleDlg::OnSendStreamVideochatctrl1(float fVideoBitrate, float fAudioBitrate) 
{
	// TODO: Add your control notification handler code here
	CString str1,str2;
	str1.Format("%.2f",fVideoBitrate);
	m_StaticVideoBitrate.SetWindowText(str1);

	str2.Format("%.2f",fAudioBitrate);
	m_StaticAudioBitrate.SetWindowText(str2);

}

void CTestvideochatsampleDlg::OnButton3() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);

	m_VideoChatListen.SetUseDefaultVMR(this->m_bDefaultVMR2);

	if(m_bMaxFirstVideo)
		m_VideoChatListen.SetVideoWindowAutoMax(true);
	else
		m_VideoChatListen.SetVideoWindowAutoMax(false);


	if(m_iAspectRatioType==0)
		m_VideoChatListen.SetVideoWindowAspectRatio(0);
	else if(m_iAspectRatioType==1)
		m_VideoChatListen.SetVideoWindowAspectRatio(1);
	else if(m_iAspectRatioType==2)
		m_VideoChatListen.SetVideoWindowAspectRatio(2);


	if(m_bCaptureToFile)
	{
			m_VideoChatListen.SetCaptureFileType(m_iOutputFileType);

		m_VideoChatListen.SetCaptureMode(true);
		m_VideoChatListen.SetCaptureOutputFolder(m_strOutputFilePath);

		m_VideoChatListen.SetMP4Audiobitrate(this->m_iMP4AudioBitrate);
		m_VideoChatListen.SetMP4Audiochannel(this->m_iMP4AudioChannel);
		m_VideoChatListen.SetMP4AudioSamplerate(this->m_iMP4Audiosamplerate);
		m_VideoChatListen.SetMP4FrameRate(this->m_iMP4Framerate);
		m_VideoChatListen.SetMP4Height(this->m_iMP4Height);
		m_VideoChatListen.SetMP4Width(this->m_iMP4Width);
		m_VideoChatListen.SetMP4Videobitrate(this->m_iMP4VideoBitrate);


	}
	else
	{
		m_VideoChatListen.SetCaptureMode(false);

	}



	m_VideoChatListen.SetReceiveVideoStream(m_bReceiveVideo);
	m_VideoChatListen.SetReceiveAudioStream(m_bReceiveAudio);

	
	m_VideoChatListen.ReceiverVideoNoVideoImage(m_strNoVideoImage);


	m_VideoChatListen.SetConferenceNumber(atol(strConfNo));
	m_VideoChatListen.SetConferenceUserID(atol(strUserID));

	if(m_strPeertoPeerListenIP!= "0")
		m_VideoChatListen.Listen(m_strPeertoPeerListenIP,m_iConnectPortNo);
	else
		m_VideoChatListen.Listen(m_strConnectIP,m_iConnectPortNo);

	GetDlgItem(IDC_BUTTON3)->EnableWindow(FALSE);
	GetDlgItem(IDC_BUTTON4)->EnableWindow(TRUE);
}

void CTestvideochatsampleDlg::OnButton2() 
{
	// TODO: Add your control notification handler code here
	m_VideoChat.Disconnect();
	ChatBannerControlEnable(FALSE);


}

void CTestvideochatsampleDlg::OnButton4() 
{
	// TODO: Add your control notification handler code here
		m_VideoChatListen.Disconnect();

	GetDlgItem(IDC_BUTTON3)->EnableWindow(TRUE);
	GetDlgItem(IDC_BUTTON4)->EnableWindow(FALSE);

}

void CTestvideochatsampleDlg::OnCheck1() 
{
	// TODO: Add your control notification handler code here
		UpdateData(TRUE);
		
		if(m_bvFullScreen)
		{
			m_EdtvLeft.EnableWindow(FALSE);
			m_EdtvTop.EnableWindow(FALSE);
			m_EdtvWidth.EnableWindow(FALSE);
			m_EdtvHeight.EnableWindow(FALSE);
		}
		else
		{
			m_EdtvLeft.EnableWindow(TRUE);
			m_EdtvTop.EnableWindow(TRUE);
			m_EdtvWidth.EnableWindow(TRUE);
			m_EdtvHeight.EnableWindow(TRUE);

		}

		

}

void CTestvideochatsampleDlg::OnButton5() 
{
	// TODO: Add your control notification handler code here
		char szFilter1[]="bmp file(*.bmp)|*.bmp||";

	CFileDialog dlg(FALSE,NULL,NULL,OFN_FILEMUSTEXIST,szFilter1,this);

	if(dlg.DoModal()==IDOK)
	{
		m_strNoVideoImage= dlg.GetPathName();
		UpdateData(FALSE);

	}

}

void CTestvideochatsampleDlg::OnBtnchangecaparea() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);

	if(m_bvFullScreen)
	{
		m_VideoChat.VirtualScreenCaptureFullScreen(true);
 
	
	}
	else
	{
		m_VideoChat.VirtualScreenCaptureFullScreen(false);

		m_VideoChat.VirtualScreenCaptureArea(m_ivLeft,m_ivTop,m_ivWidth,m_ivHeight);
	}
}



void CTestvideochatsampleDlg::OnEditchangeCombo1() 
{
	// TODO: Add your control notification handler code here
	
	
	
}

void CTestvideochatsampleDlg::OnSelchangeCombo1() 
{
	// TODO: Add your control notification handler code here
	int iIndex=m_CboVideoDevice.GetCurSel();

	if(iIndex >0)
	{
		CString str;
		m_CboVideoDevice.GetLBText(iIndex,str);
		if(str=="Viscomsoft Virtual Screen Capture")
		{
			m_BtnVirtualVideoFormat.EnableWindow(TRUE);
			m_ChkvFullScreen.EnableWindow(TRUE);

		}
		else
		{
			m_BtnVirtualVideoFormat.EnableWindow(FALSE);
			m_ChkvFullScreen.EnableWindow(FALSE);

		}
	}
}

void CTestvideochatsampleDlg::OnChkcapturefile() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);

	if(m_bCaptureToFile)
	{
			LPTSTR buffer = new TCHAR[MAX_PATH + 1];
	for(unsigned int i=0 ; i<(MAX_PATH + 1) ; i++)
		buffer[i] = 0x00;

	LPTSTR title = new TCHAR[100 * 1024];
	for(i=0 ; i<100 * 1024 ; i++)
		title[i] = 0x00;
	
	LPTSTR Path = new TCHAR[100 * 1024];
	for(i=0 ; i<100 * 1024 ; i++)
		Path[i] = 0x00;

	BROWSEINFO m_BI;
	_ITEMIDLIST * m_bi2;
	m_BI.pidlRoot = NULL;
	m_BI.hwndOwner = m_hWnd;
	m_BI.pszDisplayName = buffer;
	m_BI.lpszTitle = title;
	m_BI.ulFlags = BIF_RETURNONLYFSDIRS;
	m_BI.lpfn = NULL;
	m_BI.lParam = NULL;
	m_BI.iImage = NULL;

	m_bi2 = SHBrowseForFolder(&m_BI);

	if( m_bi2 != NULL )
	{
		SHGetPathFromIDList(m_bi2,Path);

		m_strOutputFilePath = CString(Path);

		//this->m_ListFolder.AddString(Path);
	
	}

	delete buffer;
	delete title;
	delete Path;	

	}

}

void CTestvideochatsampleDlg::OnBtncursorhighlight() 
{
	// TODO: Add your control notification handler code here
	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{			
		m_clrCursorHighlight =dlg.GetColor();
	}
}

void CTestvideochatsampleDlg::OnBtnleftclickcolor() 
{
	// TODO: Add your control notification handler code here
	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{			
		m_clrLeftClick =dlg.GetColor();
	}
}

void CTestvideochatsampleDlg::OnBtnrightclickcolor() 
{
	// TODO: Add your control notification handler code here
	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{			
		m_clrRightClick =dlg.GetColor();
	}

}

void CTestvideochatsampleDlg::OnChkusesyscursor() 
{
	// TODO: Add your control notification handler code here
		UpdateData(TRUE);

	if(this->m_bUseSysCursor)
	{
		((CButton*)GetDlgItem(IDC_BTNSELCUSTOMCURSOR))->EnableWindow(FALSE);
		((CEdit*)GetDlgItem(IDC_EDITCUSTOMCURSOR))->EnableWindow(FALSE);
		
		
	}
	else
	{
		((CButton*)GetDlgItem(IDC_BTNSELCUSTOMCURSOR))->EnableWindow(TRUE);
		((CEdit*)GetDlgItem(IDC_EDITCUSTOMCURSOR))->EnableWindow(TRUE);
		
	}	

	
}
	

void CTestvideochatsampleDlg::OnBtnselcustomcursor() 
{
	// TODO: Add your control notification handler code here
	char szFilter1[]="Icon file(*.ico)|*.ico|Cursor file(*.cur)|*.cur||";

	CFileDialog dlg(FALSE,NULL,NULL,OFN_FILEMUSTEXIST,szFilter1,this);

	if(dlg.DoModal()==IDOK)
	{
		m_strCustomCursor= dlg.GetPathName();
		UpdateData(FALSE);

	}
}

void CTestvideochatsampleDlg::OnBtnsnapshot() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	
//	AfxMessageBox("a1");

	char szFilter1[]="jpg file(*.jpg)|*.jpg||";

	CFileDialog dlg(FALSE,".jpg",NULL,OFN_FILEMUSTEXIST,szFilter1,this);

//	AfxMessageBox("a2");
	if(dlg.DoModal()==IDOK)
	{
		
		m_VideoChatListen.SnapShot(m_iIndexVideoWnd,dlg.GetPathName());

	
	}

}

void CTestvideochatsampleDlg::OnBtnshowone2one() 
{
	// TODO: Add your control notification handler code here
		UpdateData(TRUE);

	
		m_VideoChatListen.ShowOneToOneMode(this->m_iIndexVideoWnd);


}

void CTestvideochatsampleDlg::OnBtncloseone2one2() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);

	
		m_VideoChatListen.CloseOneToOneMode();

}

void CTestvideochatsampleDlg::OnOnNewUserConnectionVideochatreceivectrl1(long iConferenceNumber, long iUserID) 
{
	// TODO: Add your control notification handler code here

	CString str;

	str.Format("User ID:%d Confere Number:%d" ,iUserID,iConferenceNumber);

	this->m_ListEvent.AddString(str);

}

void CTestvideochatsampleDlg::OnOnUserConnectionLostVideochatreceivectrl1(long iConferenceNumber, long iUserID) 
{
	// TODO: Add your control notification handler code here
	CString str;

	str.Format("Disconnected User ID:%d Confere Number:%d" ,iUserID,iConferenceNumber);

	this->m_ListEvent.AddString(str);

}

void CTestvideochatsampleDlg::OnSelchangeCborotate() 
{
	// TODO: Add your control notification handler code here

	if(m_ChkInvert.GetCheck()==1 || m_ChkGrayScale.GetCheck()==1)
	{
	int iSel=m_CboRotate.GetCurSel();
		
		if(iSel==1 || iSel==3 || iSel==5 || iSel==7 || iSel==9 || iSel==11 )
		{
		AfxMessageBox("You selected rotate value that cannot support grayscale or invert color");
		}
	}

	m_VideoChat.Rotate(m_CboRotate.GetCurSel());
	
}

void CTestvideochatsampleDlg::OnChkinvertcolor() 
{
	// TODO: Add your control notification handler code here
		if(m_ChkInvert.GetCheck()==1)
	{
		int iSel=m_CboRotate.GetCurSel();
		
		if(iSel==1 || iSel==3 || iSel==5 || iSel==7 || iSel==9 || iSel==11 )
		{
		AfxMessageBox("You selected rotate value cannot support invert color");
		return;
		}
		m_VideoChat.InvertColor(TRUE);

	}
	else
		m_VideoChat.InvertColor(FALSE);
}

void CTestvideochatsampleDlg::OnChkgrayscale() 
{
	// TODO: Add your control notification handler code here
		if(m_ChkGrayScale.GetCheck()==1)
	{
		int iSel=m_CboRotate.GetCurSel();
		
		if(iSel==1 || iSel==3 || iSel==5 || iSel==7 || iSel==9 || iSel==11 )
		{
		AfxMessageBox("You selected rotate value that cannot support grayscale");
		return;
		}
		m_VideoChat.GrayScale(TRUE);

	}
	else
		m_VideoChat.GrayScale(FALSE);
	
}

void CTestvideochatsampleDlg::OnBtnlightnesschange() 
{
	// TODO: Add your control notification handler code here
		UpdateData(TRUE);

		int iSel=m_CboRotate.GetCurSel();
		
		if(iSel==1 || iSel==3 || iSel==5 || iSel==7 || iSel==9 || iSel==11 )
		{
		AfxMessageBox("You selected rotate value cannot support this effect");
		return;
		}

		m_VideoChat.Lightness(m_iLightR,m_iLightG,m_iLightB);
	
}

void CTestvideochatsampleDlg::OnBtnlightdefault() 
{
	// TODO: Add your control notification handler code here
	m_VideoChat.Lightness(-1,-1,-1);
}

void CTestvideochatsampleDlg::OnButtonfadetime() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	m_VideoChat.ChatBannerFadeEdge(m_iFadeIn,m_iFadeOut);
}

void CTestvideochatsampleDlg::OnButtontextcolor() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{
		COLORREF clrFontColor=dlg.GetColor();
		m_VideoChat.ChatBannerTextColor(GetRValue(clrFontColor),GetGValue(clrFontColor),GetBValue(clrFontColor),m_iTextAlpha);
	}

	
}

void CTestvideochatsampleDlg::OnButtonbgcolor() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{
		COLORREF clrFontColor=dlg.GetColor();
		m_VideoChat.ChatBannerBgColor(GetRValue(clrFontColor),GetGValue(clrFontColor),GetBValue(clrFontColor),m_iBgTextAlpha);
	}
	
}

void CTestvideochatsampleDlg::OnButtonchatpos() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	m_VideoChat.ChatBannerPos(m_iChatX,m_iChatY);
	
}

void CTestvideochatsampleDlg::OnButtonchatspeed() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);

	m_VideoChat.ChatBannerSpeed(m_iChatSpeed);
	
}

void CTestvideochatsampleDlg::OnButtonchatmsgsend() 
{
	// TODO: Add your control notification handler code here
	
	UpdateData(TRUE);

	ChatFillBg();
	ChatState();

	m_VideoChat.ChatBannerAddText(this->m_strChatMessage);

}

void CTestvideochatsampleDlg::ChatFillBg()
{

	if(m_ChkChatFillBg.GetCheck()==1)
		m_VideoChat.ChatBannerFillBgColor(true);
	else
			m_VideoChat.ChatBannerFillBgColor(false);

}

void CTestvideochatsampleDlg::ChatState()
{

	m_VideoChat.ChatBannerState(this->m_CboChatBannerState.GetCurSel());
}

void CTestvideochatsampleDlg::OnChkfillbg() 
{
	// TODO: Add your control notification handler code here
	ChatFillBg();
	
}

void CTestvideochatsampleDlg::OnSelchangeCbostate() 
{
	// TODO: Add your control notification handler code here
	ChatState();
}

void CTestvideochatsampleDlg::OnSelchangeCbochatfont() 
{
	// TODO: Add your control notification handler code here
	ChatFontUpdate();
	
}

void CTestvideochatsampleDlg::ChatFontUpdate() 
{
	// TODO: Add your control notification handler code here
	int iSel=m_CboFont.GetCurSel();

	CString strFontName,strFontSize;
	m_CboFont.GetLBText(iSel,strFontName);

	iSel=m_CboFontSize.GetCurSel();
	m_CboFontSize.GetLBText(iSel,strFontSize);
	int iFontSize=atoi(strFontSize);

	m_VideoChat.ChatBannerSetFont(strFontName,iFontSize,m_CboFontStyle.GetCurSel());
}


void CTestvideochatsampleDlg::OnSelchangeCbochatfontsize() 
{
	// TODO: Add your control notification handler code here
		ChatFontUpdate();
	
}

void CTestvideochatsampleDlg::OnSelchangeCbofontstyle() 
{
	// TODO: Add your control notification handler code here
	ChatFontUpdate();
	
}
void CTestvideochatsampleDlg::OverlayControlEnable(bool bEnable)
{
	((CComboBox*)GetDlgItem(IDC_CBOROTATE))->EnableWindow(bEnable);
	((CEdit*)GetDlgItem(IDC_EDITLIGHTR))->EnableWindow(bEnable);
	((CEdit*)GetDlgItem(IDC_EDITLIGHTG))->EnableWindow(bEnable);
	((CEdit*)GetDlgItem(IDC_EDITLIGHTG))->EnableWindow(bEnable);
	((CEdit*)GetDlgItem(IDC_EDITOVERLAYIMAGE))->EnableWindow(bEnable);
	((CEdit*)GetDlgItem(IDC_EDITOVERLAYIMAGEX))->EnableWindow(bEnable);
	((CEdit*)GetDlgItem(IDC_EDITOVERLAYIMAGEY))->EnableWindow(bEnable);
	((CEdit*)GetDlgItem(IDC_EDITOVERLAYIMAGEALPHA))->EnableWindow(bEnable);



	((CButton*)GetDlgItem(IDC_CHKINVERTCOLOR))->EnableWindow(bEnable);

	((CButton*)GetDlgItem(IDC_CHKGRAYSCALE))->EnableWindow(bEnable);

	((CButton*)GetDlgItem(IDC_BTNLIGHTNESSCHANGE))->EnableWindow(bEnable);
	((CButton*)GetDlgItem(IDC_BTNLIGHTDEFAULT))->EnableWindow(bEnable);


	((CButton*)GetDlgItem(IDC_BTNSELOVERLAYIMAGE))->EnableWindow(bEnable);
	((CButton*)GetDlgItem(IDC_BTNOVERLAYIMAGEDRAW))->EnableWindow(bEnable);
	((CButton*)GetDlgItem(IDC_BTNOVERLAYIMAGETRANCOLOR))->EnableWindow(bEnable);
	



	



}

void CTestvideochatsampleDlg::ChatBannerControlEnable(bool bEnable)
{
	// TODO: Add your control notification handler code here
	((CButton*)GetDlgItem(IDC_BUTTONCHATMSGSEND))->EnableWindow(bEnable);
	((CEdit*)GetDlgItem(IDC_EDITCHATMESSAGE))->EnableWindow(bEnable);

	((CComboBox*)GetDlgItem(IDC_CBOCHATFONT))->EnableWindow(bEnable);
	((CComboBox*)GetDlgItem(IDC_CBOCHATFONTSIZE))->EnableWindow(bEnable);
	((CComboBox*)GetDlgItem(IDC_CBOFONTSTYLE))->EnableWindow(bEnable);


	

	((CComboBox*)GetDlgItem(IDC_CBOSTATE))->EnableWindow(bEnable);
	


	((CButton*)GetDlgItem(IDC_CHKFILLBG))->EnableWindow(bEnable);

	((CComboBox*)GetDlgItem(IDC_CBOCHATDIR))->EnableWindow(!bEnable);
	((CEdit*)GetDlgItem(IDC_EDITFADEIN))->EnableWindow(bEnable);
	((CEdit*)GetDlgItem(IDC_EDITFADEOUT))->EnableWindow(bEnable);

	((CButton*)GetDlgItem(IDC_BUTTONFADETIME))->EnableWindow(bEnable);

	


	((CEdit*)GetDlgItem(IDC_EDITTEXTALPHA))->EnableWindow(bEnable);

	((CButton*)GetDlgItem(IDC_BUTTONTEXTCOLOR))->EnableWindow(bEnable);
	

	((CEdit*)GetDlgItem(IDC_EDITBGALPHA))->EnableWindow(bEnable);
	((CButton*)GetDlgItem(IDC_BUTTONBGCOLOR))->EnableWindow(bEnable);


	((CEdit*)GetDlgItem(IDC_EDITCHATX))->EnableWindow(bEnable);
	((CEdit*)GetDlgItem(IDC_EDITCHATY))->EnableWindow(bEnable);

	((CButton*)GetDlgItem(IDC_BUTTONCHATPOS))->EnableWindow(bEnable);
	
	((CEdit*)GetDlgItem(IDC_EDITCHATSPEED))->EnableWindow(bEnable);
	((CButton*)GetDlgItem(IDC_BUTTONCHATSPEED))->EnableWindow(bEnable);





	
}


void CTestvideochatsampleDlg::OnSelchangeCboeffecttype() 
{
	// TODO: Add your control notification handler code here
	int iSel= this->m_CboEffectType.GetCurSel();

	if(iSel==0)
	{
		OverlayControlEnable(FALSE);
		ChatBannerControlEnable(FALSE);
	}
	if(iSel==1)
	{
		OverlayControlEnable(TRUE);
		ChatBannerControlEnable(FALSE);
	}

	if(iSel==2)
	{
		OverlayControlEnable(FALSE);
		ChatBannerControlEnable(TRUE);
	}

}

void CTestvideochatsampleDlg::OnBtnseloverlayimage() 
{
	// TODO: Add your control notification handler code here
		char szFilter1[]="bmp file(*.bmp)|*.bmp|JPEG file(*.jpg)|*.jpg|PNG file(*.png)|*.png||";

	CFileDialog dlg(FALSE,NULL,NULL,OFN_FILEMUSTEXIST,szFilter1,this);

	if(dlg.DoModal()==IDOK)
	{
		m_strOverlayImageFile= dlg.GetPathName();
		UpdateData(FALSE);

	}

	
}

void CTestvideochatsampleDlg::OnBtnoverlayimagetrancolor() 
{
	// TODO: Add your control notification handler code here
		CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{
		m_clrTranColor=dlg.GetColor();

		m_VideoChat.SetOverlayImageTransColor(GetRValue(m_clrTranColor),GetGValue(m_clrTranColor),GetBValue(m_clrTranColor),this->m_iOverlayImageAlpha);
	}
}

void CTestvideochatsampleDlg::OnBtnoverlayimagedraw() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	m_VideoChat.SetOverlayImage(this->m_strOverlayImageFile);
	m_VideoChat.SetOverlayImagePos(this->m_iOverlayImageX,this->m_iOverlayImageY);
	m_VideoChat.SetOverlayImageTransColor(GetRValue(m_clrTranColor),GetGValue(m_clrTranColor),GetBValue(m_clrTranColor),this->m_iOverlayImageAlpha);
  

	
}
