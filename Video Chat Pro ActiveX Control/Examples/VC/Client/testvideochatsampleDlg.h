// testvideochatsampleDlg.h : header file
//
//{{AFX_INCLUDES()
#include "videochat.h"
#include "videochatreceiver.h"
//}}AFX_INCLUDES

#if !defined(AFX_TESTVIDEOCHATSAMPLEDLG_H__057A812A_700D_48A3_B5DF_2E89309F8BE0__INCLUDED_)
#define AFX_TESTVIDEOCHATSAMPLEDLG_H__057A812A_700D_48A3_B5DF_2E89309F8BE0__INCLUDED_

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

	void ChatBannerControlEnable(bool bEnable);
	void OverlayControlEnable(bool bEnable);

	COLORREF m_clrTranColor;


// Dialog Data
	//{{AFX_DATA(CTestvideochatsampleDlg)
	enum { IDD = IDD_TESTVIDEOCHATSAMPLE_DIALOG };
	CButton	m_ChkChatFillBg;
	CComboBox	m_CboChatDir;
	CComboBox	m_CboEffectType;
	CComboBox	m_CboChatBannerState;
	CComboBox	m_CboFontStyle;
	CComboBox	m_CboFontSize;
	CComboBox	m_CboFont;
	CButton	m_ChkGrayScale;
	CButton	m_ChkInvert;
	CComboBox	m_CboRotate;
	CEdit	m_edtListenIPAddress;
	CListBox	m_ListEvent;
	CButton	m_ChkvFullScreen;
	CButton	m_BtnVirtualVideoFormat;
	CButton	m_BtnCaptureArea;
	CEdit	m_EdtvHeight;
	CEdit	m_EdtvWidth;
	CEdit	m_EdtvTop;
	CEdit	m_EdtvLeft;
	CEdit	m_edtUserID;
	CEdit	m_edtConfNo;
	CEdit	m_edtPortNo;
	CEdit	m_edtIPAddress;
	CStatic	m_StaticAudioBitrate;
	CStatic	m_StaticVideoBitrate;
	CComboBox	m_CboAudioQuality;
	CComboBox	m_CboAudioComplex;
	CComboBox	m_CboVideoComplex;
	CComboBox	m_CboVideoFormat;
	CComboBox	m_CboAudioDevice;
	CComboBox	m_CboVideoDevice;
	Cvideochat	m_VideoChat;
	long	m_iVideoBitrate;
	CString	m_strConnectIP;
	int		m_iConnectPortNo;
	int		m_iFrameRate;
	BOOL	m_bSendVideo;
	BOOL	m_bSendAudio;
	BOOL	m_bReceiveVideo;
	BOOL	m_bReceiveAudio;
	BOOL	m_bPopUp;
	int		m_iLeft;
	int		m_iTop;
	int		m_iWidth;
	int		m_iHeight;
	CString	m_strNoVideoImage;
	CVideoChatReceiver	m_VideoChatListen;
	long	m_ivLeft;
	long	m_ivTop;
	long	m_ivWidth;
	long	m_ivHeight;
	BOOL	m_bvFullScreen;
	long	m_iMP4Width;
	long	m_iMP4Height;
	long	m_iMP4AudioChannel;
	long	m_iMP4VideoBitrate;
	long	m_iMP4AudioBitrate;
	int		m_iMP4Framerate;
	long	m_iMP4Audiosamplerate;
	int		m_iAspectRatioType;
	int		m_iOutputFileType;
	BOOL	m_bMaxFirstVideo;
	BOOL	m_bCaptureToFile;
	CString	m_strCustomCursor;
	BOOL	m_bUseSysCursor;
	int		m_iIndexVideoWnd;
	CString	m_strPeertoPeerListenIP;
	BOOL	m_bDefaultVMR1;
	BOOL	m_bDefaultVMR2;
	BOOL	m_bMouseHighlight;
	int		m_iLightR;
	int		m_iLightG;
	int		m_iLightB;
	double	m_iFadeIn;
	double	m_iFadeOut;
	CString	m_strChatMessage;
	int		m_iTextAlpha;
	int		m_iBgTextAlpha;
	int		m_iChatX;
	int		m_iChatY;
	int		m_iChatSpeed;
	int		m_iOverlayImageAlpha;
	CString	m_strOverlayImageFile;
	long	m_iOverlayImageX;
	long	m_iOverlayImageY;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTestvideochatsampleDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL
	CString m_strOutputFilePath;
	CString m_strAppPath;
	BOOL m_bClickChangeVideoFormat;
	COLORREF m_clrCursorHighlight;
	COLORREF m_clrLeftClick;
	COLORREF m_clrRightClick;

	void ChatFillBg();
	void ChatState();
	void ChatFontUpdate();
	

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CTestvideochatsampleDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	virtual void OnOK();
	virtual void OnCancel();
	afx_msg void OnButton1();
	afx_msg void OnSendStreamVideochatctrl1(float fVideoBitrate, float fAudioBitrate);
	afx_msg void OnButton3();
	afx_msg void OnButton2();
	afx_msg void OnButton4();
	afx_msg void OnCheck1();
	afx_msg void OnButton5();
	afx_msg void OnBtnchangecaparea();
	afx_msg void OnEditchangeCombo1();
	afx_msg void OnSelchangeCombo1();
	afx_msg void OnChkcapturefile();
	afx_msg void OnBtncursorhighlight();
	afx_msg void OnBtnleftclickcolor();
	afx_msg void OnBtnrightclickcolor();
	afx_msg void OnChkusesyscursor();
	afx_msg void OnBtnselcustomcursor();
	afx_msg void OnBtnsnapshot();
	afx_msg void OnBtnshowone2one();
	afx_msg void OnBtncloseone2one2();
	afx_msg void OnOnNewUserConnectionVideochatreceivectrl1(long iConferenceNumber, long iUserID);
	afx_msg void OnOnUserConnectionLostVideochatreceivectrl1(long iConferenceNumber, long iUserID);
	afx_msg void OnSelchangeCborotate();
	afx_msg void OnChkinvertcolor();
	afx_msg void OnChkgrayscale();
	afx_msg void OnBtnlightnesschange();
	afx_msg void OnBtnlightdefault();
	afx_msg void OnButtonfadetime();
	afx_msg void OnButtontextcolor();
	afx_msg void OnButtonbgcolor();
	afx_msg void OnButtonchatpos();
	afx_msg void OnButtonchatspeed();
	afx_msg void OnButtonchatmsgsend();
	afx_msg void OnChkfillbg();
	afx_msg void OnSelchangeCbostate();
	afx_msg void OnSelchangeCbochatfont();
	afx_msg void OnSelchangeCbochatfontsize();
	afx_msg void OnSelchangeCbofontstyle();
	afx_msg void OnSelchangeCboeffecttype();
	afx_msg void OnBtnseloverlayimage();
	afx_msg void OnBtnoverlayimagetrancolor();
	afx_msg void OnBtnoverlayimagedraw();
	DECLARE_EVENTSINK_MAP()
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_TESTVIDEOCHATSAMPLEDLG_H__057A812A_700D_48A3_B5DF_2E89309F8BE0__INCLUDED_)
