VERSION 5.00
Object = "{F9D8E1C3-CDFE-4136-ABF0-36FF5BCA7F83}#1.0#0"; "VideoChatSender.ocx"
Object = "{E1A9DB8F-E712-4705-8A66-4CD75B534552}#1.0#0"; "VideoChatReceiver.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form Form1 
   AutoRedraw      =   -1  'True
   Caption         =   "Video Chat Pro ActiveX SDK"
   ClientHeight    =   9990
   ClientLeft      =   165
   ClientTop       =   555
   ClientWidth     =   18840
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   6.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   9990
   ScaleWidth      =   18840
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtPeertoPeerListenIP 
      Height          =   375
      Left            =   2520
      TabIndex        =   73
      Text            =   "0"
      Top             =   0
      Width           =   1215
   End
   Begin VB.TextBox txtconnectIP 
      Height          =   375
      Left            =   2520
      TabIndex        =   72
      Text            =   "192.168.1.3"
      Top             =   370
      Width           =   1215
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   7560
      Top             =   10680
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.TextBox txtConnectPortNo 
      Height          =   375
      Left            =   6720
      TabIndex        =   38
      Text            =   "1234"
      Top             =   120
      Width           =   855
   End
   Begin VB.TextBox txtconfno 
      Height          =   375
      Left            =   9360
      TabIndex        =   35
      Text            =   "29648574"
      Top             =   120
      Width           =   1215
   End
   Begin VB.TextBox txtuserid 
      Height          =   375
      Left            =   12000
      TabIndex        =   34
      Text            =   "73051174"
      Top             =   120
      Width           =   1335
   End
   Begin VB.Frame Frame2 
      Caption         =   "Listen"
      Height          =   10455
      Left            =   9240
      TabIndex        =   20
      Top             =   720
      Width           =   9495
      Begin VB.ListBox ListEvent 
         Height          =   1500
         Left            =   7320
         TabIndex        =   70
         Top             =   7920
         Width           =   2175
      End
      Begin VB.CommandButton Command8 
         Caption         =   "Close one To One Mode"
         Height          =   375
         Left            =   7440
         TabIndex        =   69
         Top             =   9960
         Width           =   1815
      End
      Begin VB.CommandButton Command7 
         Caption         =   "Show one To One Mode"
         Height          =   375
         Left            =   5520
         TabIndex        =   68
         Top             =   9960
         Width           =   1695
      End
      Begin VB.CommandButton Command6 
         Caption         =   "Snapshot"
         Height          =   375
         Left            =   3480
         TabIndex        =   67
         Top             =   9960
         Width           =   1455
      End
      Begin VB.TextBox txtindexvideowindow 
         Height          =   270
         Left            =   2160
         TabIndex        =   65
         Text            =   "0"
         Top             =   10080
         Width           =   855
      End
      Begin VB.Frame Frame5 
         Caption         =   "Aspect Ratio of Max Video Window"
         Height          =   615
         Left            =   240
         TabIndex        =   61
         Top             =   7200
         Width           =   4815
         Begin VB.OptionButton RadioAspectRatio3 
            Caption         =   "Stretch"
            Height          =   180
            Left            =   3480
            TabIndex        =   64
            Top             =   240
            Width           =   1215
         End
         Begin VB.OptionButton RadioAspectRatio2 
            Caption         =   "16:9"
            Height          =   255
            Left            =   2160
            TabIndex        =   63
            Top             =   240
            Width           =   1095
         End
         Begin VB.OptionButton RadioAspectRatio1 
            Caption         =   "4:3"
            Height          =   180
            Left            =   360
            TabIndex        =   62
            Top             =   240
            Value           =   -1  'True
            Width           =   1095
         End
      End
      Begin VB.Frame Frame4 
         Caption         =   "MP4"
         Height          =   1575
         Left            =   3000
         TabIndex        =   46
         Top             =   7800
         Width           =   4215
         Begin VB.TextBox txtmp4audiosamplerate 
            Height          =   270
            Left            =   3240
            TabIndex        =   60
            Text            =   "44100"
            Top             =   960
            Width           =   855
         End
         Begin VB.TextBox txtmp4framerate 
            Height          =   270
            Left            =   960
            TabIndex        =   58
            Text            =   "25"
            Top             =   960
            Width           =   615
         End
         Begin VB.TextBox txtmp4audiobitrate 
            Height          =   270
            Left            =   3240
            TabIndex        =   56
            Text            =   "96000"
            Top             =   600
            Width           =   855
         End
         Begin VB.TextBox txtmp4videobitrate 
            Height          =   270
            Left            =   960
            TabIndex        =   54
            Text            =   "4600000"
            Top             =   600
            Width           =   975
         End
         Begin VB.TextBox txtaudiochannels 
            Height          =   270
            Left            =   3240
            TabIndex        =   52
            Text            =   "2"
            Top             =   1320
            Width           =   375
         End
         Begin VB.TextBox txtmp4height 
            Height          =   270
            Left            =   2520
            TabIndex        =   50
            Text            =   "480"
            Top             =   240
            Width           =   735
         End
         Begin VB.TextBox txtmp4width 
            Height          =   270
            Left            =   960
            TabIndex        =   48
            Text            =   "720"
            Top             =   240
            Width           =   735
         End
         Begin VB.Label Label22 
            Caption         =   "Audio samplerate"
            Height          =   255
            Left            =   2040
            TabIndex        =   59
            Top             =   960
            Width           =   1095
         End
         Begin VB.Label Label21 
            Caption         =   "Frame rate"
            Height          =   255
            Left            =   120
            TabIndex        =   57
            Top             =   960
            Width           =   735
         End
         Begin VB.Label Label20 
            Caption         =   "Audio bitrate"
            Height          =   255
            Left            =   2160
            TabIndex        =   55
            Top             =   600
            Width           =   855
         End
         Begin VB.Label Label19 
            Caption         =   "Video bitrate"
            Height          =   135
            Left            =   120
            TabIndex        =   53
            Top             =   600
            Width           =   855
         End
         Begin VB.Label Label18 
            Caption         =   "Audio Channel"
            Height          =   135
            Left            =   2040
            TabIndex        =   51
            Top             =   1320
            Width           =   975
         End
         Begin VB.Label Label13 
            Caption         =   "Height"
            Height          =   135
            Left            =   1800
            TabIndex        =   49
            Top             =   240
            Width           =   615
         End
         Begin VB.Label Label12 
            Caption         =   "Width"
            Height          =   255
            Left            =   360
            TabIndex        =   47
            Top             =   240
            Width           =   495
         End
      End
      Begin VB.Frame Frame3 
         Height          =   735
         Left            =   360
         TabIndex        =   43
         Top             =   8400
         Width           =   2535
         Begin VB.OptionButton OptWMV 
            Caption         =   "WMV"
            Height          =   255
            Left            =   1440
            TabIndex        =   45
            Top             =   240
            Width           =   855
         End
         Begin VB.OptionButton OptMP4 
            Caption         =   "MP4"
            Height          =   255
            Left            =   360
            TabIndex        =   44
            Top             =   240
            Value           =   -1  'True
            Width           =   735
         End
      End
      Begin VB.CheckBox ChkMaxfirstvideowindow 
         Caption         =   "Max First Video Window"
         Height          =   255
         Left            =   360
         TabIndex        =   42
         Top             =   8160
         Width           =   2175
      End
      Begin VB.CheckBox ChkCaptureToFile 
         Caption         =   "Capture to File"
         Height          =   375
         Left            =   360
         TabIndex        =   41
         Top             =   7800
         Width           =   1815
      End
      Begin VideoChatReceiverLib.VideoChatReceiver VideoChatReceiver1 
         Height          =   6495
         Left            =   120
         TabIndex        =   33
         Top             =   240
         Width           =   9375
         _Version        =   65536
         _ExtentX        =   16536
         _ExtentY        =   11456
         _StockProps     =   0
      End
      Begin VB.TextBox txtnovideoimage 
         Height          =   375
         Left            =   5760
         TabIndex        =   31
         Top             =   6840
         Width           =   3135
      End
      Begin VB.CommandButton Command5 
         Caption         =   "Get IP Address"
         Height          =   495
         Left            =   4200
         TabIndex        =   29
         Top             =   9360
         Width           =   1335
      End
      Begin VB.CommandButton Command4 
         Caption         =   "Disconnect"
         Enabled         =   0   'False
         Height          =   495
         Left            =   2400
         TabIndex        =   24
         Top             =   9360
         Width           =   1575
      End
      Begin VB.CommandButton Command3 
         Caption         =   "Start Listening"
         Height          =   495
         Left            =   360
         TabIndex        =   23
         Top             =   9360
         Width           =   1815
      End
      Begin VB.CheckBox chkreceiveaudio 
         Caption         =   "Received Audio Stream"
         Height          =   255
         Left            =   2040
         TabIndex        =   22
         Top             =   6840
         Value           =   1  'Checked
         Width           =   1935
      End
      Begin VB.CheckBox chkreceivevideo 
         Caption         =   "Receive Video Stream"
         Height          =   255
         Left            =   120
         TabIndex        =   21
         Top             =   6840
         Value           =   1  'Checked
         Width           =   1815
      End
      Begin VB.Label Label24 
         Caption         =   "Events"
         Height          =   255
         Left            =   7440
         TabIndex        =   71
         Top             =   7560
         Width           =   855
      End
      Begin VB.Label Label23 
         Caption         =   "Index of Video Windows"
         Height          =   255
         Left            =   240
         TabIndex        =   66
         Top             =   10080
         Width           =   1695
      End
      Begin VB.Label Label9 
         Caption         =   "Display Image when no video stream"
         Height          =   375
         Left            =   3960
         TabIndex        =   30
         Top             =   6840
         Width           =   1695
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Connect"
      Height          =   9615
      Left            =   0
      TabIndex        =   0
      Top             =   720
      Width           =   9015
      Begin VB.Frame Frame7 
         Height          =   2535
         Left            =   240
         TabIndex        =   99
         Top             =   4560
         Width           =   2775
         Begin VB.TextBox txtchatspeed 
            Height          =   270
            Left            =   1320
            TabIndex        =   120
            Text            =   "4"
            Top             =   2280
            Width           =   495
         End
         Begin VB.CommandButton cmdspeed 
            Caption         =   "set"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2160
            TabIndex        =   119
            Top             =   2280
            Width           =   495
         End
         Begin VB.TextBox txtchatposx 
            Height          =   270
            Left            =   480
            TabIndex        =   114
            Text            =   "0"
            Top             =   1920
            Width           =   495
         End
         Begin VB.TextBox txtchatposy 
            Height          =   270
            Left            =   1440
            TabIndex        =   113
            Text            =   "0"
            Top             =   1920
            Width           =   615
         End
         Begin VB.CommandButton cmdpos 
            Caption         =   "set"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2160
            TabIndex        =   112
            Top             =   1920
            Width           =   495
         End
         Begin VB.TextBox txtchatfadein 
            Enabled         =   0   'False
            Height          =   270
            Left            =   1680
            TabIndex        =   106
            Text            =   "0.1"
            Top             =   240
            Width           =   495
         End
         Begin VB.CommandButton cmdfadetime 
            Caption         =   "Set"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2160
            TabIndex        =   105
            Top             =   600
            Width           =   495
         End
         Begin VB.TextBox txtchatfadeout 
            Enabled         =   0   'False
            Height          =   270
            Left            =   1680
            TabIndex        =   104
            Text            =   "0.4"
            Top             =   600
            Width           =   495
         End
         Begin VB.CommandButton cmdfonttextcolor 
            Caption         =   "Select"
            Enabled         =   0   'False
            Height          =   255
            Left            =   1920
            TabIndex        =   103
            Top             =   1080
            Width           =   735
         End
         Begin VB.TextBox txtchattextalpha 
            Height          =   270
            Left            =   1080
            TabIndex        =   102
            Text            =   "255"
            Top             =   1080
            Width           =   375
         End
         Begin VB.TextBox txtchatbgalpha 
            Height          =   270
            Left            =   1080
            TabIndex        =   101
            Text            =   "255"
            Top             =   1440
            Width           =   375
         End
         Begin VB.CommandButton cmdfontbgcolor 
            Caption         =   "Select"
            Enabled         =   0   'False
            Height          =   255
            Left            =   1920
            TabIndex        =   100
            Top             =   1440
            Width           =   735
         End
         Begin VB.Label Label38 
            Caption         =   "Speed (1-6)"
            Height          =   255
            Left            =   240
            TabIndex        =   121
            Top             =   2280
            Width           =   975
         End
         Begin VB.Label Label28 
            Caption         =   "X"
            Height          =   135
            Left            =   240
            TabIndex        =   116
            Top             =   1920
            Width           =   255
         End
         Begin VB.Label Label29 
            Caption         =   "Y"
            Height          =   255
            Left            =   1080
            TabIndex        =   115
            Top             =   1920
            Width           =   375
         End
         Begin VB.Label Label30 
            Caption         =   "Fade In Time (0-1)"
            Height          =   255
            Left            =   120
            TabIndex        =   111
            Top             =   240
            Width           =   1455
         End
         Begin VB.Label Label31 
            Caption         =   "Fade out Time (0-1)"
            Height          =   255
            Left            =   120
            TabIndex        =   110
            Top             =   600
            Width           =   1455
         End
         Begin VB.Label Label32 
            Caption         =   "Text Color"
            Height          =   255
            Left            =   120
            TabIndex        =   109
            Top             =   1080
            Width           =   1095
         End
         Begin VB.Label Label35 
            Caption         =   "Alpha (0-255)"
            Height          =   255
            Left            =   1080
            TabIndex        =   108
            Top             =   840
            Width           =   855
         End
         Begin VB.Label Label36 
            Caption         =   "Bg Color"
            Height          =   255
            Left            =   120
            TabIndex        =   107
            Top             =   1440
            Width           =   855
         End
      End
      Begin VB.Frame Frame6 
         Caption         =   "Chat Banner"
         Height          =   1215
         Left            =   240
         TabIndex        =   89
         Top             =   3480
         Width           =   8775
         Begin VB.ComboBox cbochatdir 
            Height          =   300
            Left            =   5520
            Style           =   2  'Dropdown List
            TabIndex        =   118
            Top             =   840
            Width           =   2535
         End
         Begin VB.ComboBox cbochatfontstyle 
            Enabled         =   0   'False
            Height          =   300
            Left            =   7560
            Style           =   2  'Dropdown List
            TabIndex        =   98
            Top             =   360
            Width           =   855
         End
         Begin VB.CheckBox chkchatfillbg 
            Caption         =   "Fill background"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2880
            TabIndex        =   97
            Top             =   720
            Value           =   1  'Checked
            Width           =   1575
         End
         Begin VB.ComboBox cbochatfontsize 
            Enabled         =   0   'False
            Height          =   300
            Left            =   6720
            Style           =   2  'Dropdown List
            TabIndex        =   96
            Top             =   360
            Width           =   735
         End
         Begin VB.ComboBox cbochatfont 
            Enabled         =   0   'False
            Height          =   300
            Left            =   5520
            Style           =   2  'Dropdown List
            TabIndex        =   95
            Top             =   360
            Width           =   975
         End
         Begin VB.ComboBox cbochatstate 
            Enabled         =   0   'False
            Height          =   300
            Left            =   1200
            Style           =   2  'Dropdown List
            TabIndex        =   93
            Top             =   720
            Width           =   1455
         End
         Begin VB.CommandButton cmdchatsend 
            Caption         =   "Send"
            Enabled         =   0   'False
            Height          =   375
            Left            =   4440
            TabIndex        =   92
            Top             =   240
            Width           =   735
         End
         Begin VB.TextBox txtchat 
            Enabled         =   0   'False
            Height          =   375
            Left            =   1200
            TabIndex        =   91
            Text            =   "Enter your message"
            Top             =   240
            Width           =   3015
         End
         Begin VB.Label Label37 
            Caption         =   "Direction"
            Height          =   255
            Left            =   4680
            TabIndex        =   117
            Top             =   840
            Width           =   975
         End
         Begin VB.Label Label27 
            Caption         =   "State"
            Height          =   375
            Left            =   240
            TabIndex        =   94
            Top             =   720
            Width           =   735
         End
         Begin VB.Label Label26 
            Caption         =   "Text"
            Height          =   255
            Left            =   240
            TabIndex        =   90
            Top             =   240
            Width           =   735
         End
      End
      Begin VB.ComboBox cbooverlaytype 
         Height          =   300
         Left            =   240
         Style           =   2  'Dropdown List
         TabIndex        =   88
         Top             =   1920
         Width           =   3015
      End
      Begin VB.Frame Frame10 
         Caption         =   "Overlay"
         Height          =   1215
         Left            =   240
         TabIndex        =   75
         Top             =   2400
         Width           =   8775
         Begin VB.CommandButton cmddrawimage 
            Caption         =   "Draw"
            Enabled         =   0   'False
            Height          =   255
            Left            =   7680
            TabIndex        =   132
            Top             =   600
            Width           =   975
         End
         Begin VB.CommandButton cmdoverlayimagetranscolor 
            Caption         =   "Trans Color"
            Enabled         =   0   'False
            Height          =   255
            Left            =   7680
            TabIndex        =   131
            Top             =   880
            Width           =   975
         End
         Begin VB.TextBox txtoverlayimagealpha 
            Enabled         =   0   'False
            Height          =   270
            Left            =   7200
            TabIndex        =   130
            Text            =   "255"
            Top             =   600
            Width           =   375
         End
         Begin VB.CommandButton cmdoverlayimageset 
            Caption         =   "Set"
            Enabled         =   0   'False
            Height          =   255
            Left            =   8160
            TabIndex        =   128
            Top             =   240
            Width           =   495
         End
         Begin VB.TextBox txtoverlayimagey 
            Enabled         =   0   'False
            Height          =   270
            Left            =   6240
            TabIndex        =   127
            Text            =   "0"
            Top             =   600
            Width           =   375
         End
         Begin VB.TextBox txtoverlayimagex 
            Enabled         =   0   'False
            Height          =   270
            Left            =   5520
            TabIndex        =   125
            Text            =   "0"
            Top             =   600
            Width           =   375
         End
         Begin VB.TextBox txtoverlayimage 
            Enabled         =   0   'False
            Height          =   270
            Left            =   5520
            TabIndex        =   123
            Top             =   240
            Width           =   2535
         End
         Begin VB.ComboBox cborotate 
            Enabled         =   0   'False
            Height          =   300
            Left            =   840
            Style           =   2  'Dropdown List
            TabIndex        =   84
            Top             =   240
            Width           =   2055
         End
         Begin VB.CheckBox chkinvertcolor 
            Caption         =   "On"
            Enabled         =   0   'False
            Height          =   255
            Left            =   1080
            TabIndex        =   83
            Top             =   600
            Width           =   615
         End
         Begin VB.CheckBox chkgrayscale 
            Caption         =   "On"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2520
            TabIndex        =   82
            Top             =   600
            Width           =   495
         End
         Begin VB.TextBox txlightnessb 
            Enabled         =   0   'False
            Height          =   315
            Left            =   4080
            TabIndex        =   81
            Text            =   "0"
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txlightnessg 
            Enabled         =   0   'False
            Height          =   315
            Left            =   3600
            TabIndex        =   80
            Text            =   "100"
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txlightnessr 
            Enabled         =   0   'False
            Height          =   315
            Left            =   3120
            TabIndex        =   79
            Text            =   "255"
            Top             =   360
            Width           =   375
         End
         Begin VB.CommandButton Command14 
            Caption         =   "change"
            Enabled         =   0   'False
            Height          =   255
            Left            =   3120
            TabIndex        =   78
            Top             =   720
            Width           =   855
         End
         Begin VB.CommandButton Command15 
            Caption         =   "default"
            Enabled         =   0   'False
            Height          =   255
            Left            =   4080
            TabIndex        =   77
            Top             =   720
            Width           =   855
         End
         Begin VB.CheckBox chklightness 
            Caption         =   "Ligthness"
            Enabled         =   0   'False
            Height          =   255
            Left            =   3120
            TabIndex        =   76
            Top             =   120
            Width           =   975
         End
         Begin VB.Label Label43 
            Caption         =   "Alpha"
            Height          =   255
            Left            =   6720
            TabIndex        =   129
            Top             =   600
            Width           =   375
         End
         Begin VB.Label Label42 
            Caption         =   "Y"
            Height          =   255
            Left            =   6000
            TabIndex        =   126
            Top             =   600
            Width           =   255
         End
         Begin VB.Label Label41 
            Caption         =   "X"
            Height          =   255
            Left            =   5280
            TabIndex        =   124
            Top             =   600
            Width           =   255
         End
         Begin VB.Label Label40 
            Caption         =   "Image"
            Height          =   255
            Left            =   5040
            TabIndex        =   122
            Top             =   240
            Width           =   495
         End
         Begin VB.Label Label33 
            Caption         =   "Rotate"
            Height          =   255
            Left            =   120
            TabIndex        =   87
            Top             =   240
            Width           =   735
         End
         Begin VB.Label Label34 
            Caption         =   "Invert Color"
            Height          =   255
            Left            =   120
            TabIndex        =   86
            Top             =   600
            Width           =   855
         End
         Begin VB.Label Label39 
            Caption         =   "GrayScale"
            Height          =   255
            Left            =   1680
            TabIndex        =   85
            Top             =   600
            Width           =   735
         End
      End
      Begin VideoChatSenderLib.VideoChatSender VideoChatSender1 
         Height          =   4335
         Left            =   3120
         TabIndex        =   32
         Top             =   4920
         Width           =   5415
         _Version        =   65536
         _ExtentX        =   9551
         _ExtentY        =   7646
         _StockProps     =   0
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Disconnect"
         BeginProperty Font 
            Name            =   "Arial Black"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   7560
         TabIndex        =   19
         Top             =   1800
         Width           =   1335
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Connect"
         BeginProperty Font 
            Name            =   "Arial Black"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   6120
         TabIndex        =   18
         Top             =   1800
         Width           =   1335
      End
      Begin VB.CheckBox chksendaudio 
         Caption         =   "Send Audio Stream"
         Height          =   255
         Left            =   5400
         TabIndex        =   17
         Top             =   1440
         Value           =   1  'Checked
         Width           =   1695
      End
      Begin VB.ComboBox cboaudioquality 
         Height          =   300
         Left            =   7200
         Style           =   2  'Dropdown List
         TabIndex        =   16
         Top             =   1080
         Width           =   1575
      End
      Begin VB.ComboBox cboaudiocomplex 
         Height          =   300
         Left            =   7200
         Style           =   2  'Dropdown List
         TabIndex        =   14
         Top             =   600
         Width           =   1575
      End
      Begin VB.CheckBox chksendvideo 
         Caption         =   "Send Video Stream"
         Height          =   255
         Left            =   3480
         TabIndex        =   12
         Top             =   1440
         Value           =   1  'Checked
         Width           =   1815
      End
      Begin VB.TextBox txtVideobitrate 
         Height          =   270
         Left            =   1560
         TabIndex        =   10
         Text            =   "1280000"
         Top             =   1440
         Width           =   1215
      End
      Begin VB.TextBox txtframerate 
         Height          =   270
         Left            =   4440
         TabIndex        =   8
         Text            =   "15"
         Top             =   960
         Width           =   735
      End
      Begin VB.ComboBox cbovideoformat 
         Height          =   300
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   6
         Top             =   960
         Width           =   1695
      End
      Begin VB.ComboBox cboaudiodevice 
         Height          =   300
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   4
         Top             =   600
         Width           =   3735
      End
      Begin VB.ComboBox cbovideodevice 
         Height          =   300
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   2
         Top             =   240
         Width           =   3735
      End
      Begin VB.Label lblaudiobitrate 
         Caption         =   "0"
         Height          =   255
         Left            =   2040
         TabIndex        =   28
         Top             =   7800
         Width           =   1095
      End
      Begin VB.Label Label15 
         Caption         =   "Audio bitrate (bit/sec)"
         Height          =   255
         Left            =   240
         TabIndex        =   27
         Top             =   7800
         Width           =   1455
      End
      Begin VB.Label lblvideobitrate 
         Caption         =   "0"
         Height          =   255
         Left            =   2040
         TabIndex        =   26
         Top             =   7200
         Width           =   975
      End
      Begin VB.Label Label14 
         Caption         =   "Video bitrate (bit/sec)"
         Height          =   255
         Left            =   240
         TabIndex        =   25
         Top             =   7200
         Width           =   1455
      End
      Begin VB.Label Label11 
         Caption         =   "Audio Quality"
         Height          =   375
         Left            =   5640
         TabIndex        =   15
         Top             =   1080
         Width           =   1215
      End
      Begin VB.Label Label10 
         Caption         =   "Audio Complexity"
         Height          =   375
         Left            =   5640
         TabIndex        =   13
         Top             =   600
         Width           =   1215
      End
      Begin VB.Label Label6 
         Caption         =   "bits"
         Height          =   255
         Left            =   2880
         TabIndex        =   11
         Top             =   1440
         Width           =   495
      End
      Begin VB.Label Label5 
         Caption         =   "Video Bitrate"
         Height          =   375
         Left            =   240
         TabIndex        =   9
         Top             =   1440
         Width           =   975
      End
      Begin VB.Label Label4 
         Caption         =   "Frame Rate"
         Height          =   255
         Left            =   3360
         TabIndex        =   7
         Top             =   960
         Width           =   855
      End
      Begin VB.Label Label3 
         Caption         =   "Video Format"
         Height          =   255
         Left            =   240
         TabIndex        =   5
         Top             =   1080
         Width           =   1095
      End
      Begin VB.Label Label2 
         Caption         =   "Audio Device"
         Height          =   255
         Left            =   240
         TabIndex        =   3
         Top             =   720
         Width           =   1095
      End
      Begin VB.Label Label1 
         Caption         =   "Video Device"
         Height          =   255
         Left            =   240
         TabIndex        =   1
         Top             =   360
         Width           =   975
      End
   End
   Begin VB.Label Label25 
      Caption         =   "Listening IP (For one to one mode)"
      Height          =   320
      Left            =   240
      TabIndex        =   74
      Top             =   0
      Width           =   1815
   End
   Begin VB.Label Label7 
      Caption         =   "Video Chat Pro Server IP Address"
      Height          =   375
      Left            =   240
      TabIndex        =   40
      Top             =   480
      Width           =   2175
   End
   Begin VB.Label Label8 
      Caption         =   "Video Chat Pro Server Port No."
      Height          =   375
      Left            =   4440
      TabIndex        =   39
      Top             =   120
      Width           =   2175
   End
   Begin VB.Label Label16 
      Caption         =   "Conference Number"
      Height          =   255
      Left            =   7920
      TabIndex        =   37
      Top             =   120
      Width           =   1335
   End
   Begin VB.Label Label17 
      Caption         =   "User ID"
      Height          =   375
      Left            =   11160
      TabIndex        =   36
      Top             =   120
      Width           =   735
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim strSelPath As String
Dim ImageTrancolor

Private Sub OverlayControlEnable(bEnable As Boolean)

cborotate.Enabled = bEnable
chkinvertcolor.Enabled = bEnable
chkgrayscale.Enabled = bEnable
chklightness.Enabled = bEnable

txtoverlayimage.Enabled = bEnable
cmdoverlayimageset.Enabled = bEnable
txtoverlayimagex.Enabled = bEnable
txtoverlayimagey.Enabled = bEnable
txtoverlayimagealpha.Enabled = bEnable
cmdoverlayimagetranscolor.Enabled = bEnable
cmddrawimage.Enabled = bEnable
Command14.Enabled = bEnable
Command15.Enabled = bEnable



End Sub

Private Sub ChatBannerControlEnable(bEnable As Boolean)
txtchat.Enabled = bEnable
cmdchatsend.Enabled = bEnable
cbochatstate.Enabled = bEnable
chkchatfillbg.Enabled = bEnable
cbochatfont.Enabled = bEnable
cbochatfontsize.Enabled = bEnable
cbochatfontstyle.Enabled = bEnable
cbochatdir.Enabled = Not bEnable
cmdfadetime.Enabled = bEnable
cmdfonttextcolor.Enabled = bEnable
cmdfontbgcolor.Enabled = bEnable
cmdpos.Enabled = bEnable
cmdspeed.Enabled = bEnable
txtchatfadein.Enabled = bEnable
txtchatfadeout.Enabled = bEnable

End Sub
Private Sub chkpopup_Click()


End Sub

Private Sub UpdateChatBannerFont()
VideoChatSender1.ChatBannerSetFont cbochatfont.List(cbochatfont.ListIndex), Val(cbochatfontsize.List(cbochatfontsize.ListIndex)), cbochatfontstyle.ListIndex

End Sub

Private Sub cbochatfont_Click()

UpdateChatBannerFont
End Sub

Private Sub cbochatfontsize_Click()
UpdateChatBannerFont
End Sub

Private Sub cbochatfontstyle_Click()
UpdateChatBannerFont
End Sub

Private Sub cbochatstate_Click()
VideoChatSender1.ChatBannerState Me.cbochatstate.ListIndex
End Sub

Private Sub cbooverlaytype_Click()
If cbooverlaytype.ListIndex = 0 Then
        OverlayControlEnable False
        ChatBannerControlEnable False
End If

If cbooverlaytype.ListIndex = 1 Then
        OverlayControlEnable True
        ChatBannerControlEnable False
        
End If


If cbooverlaytype.ListIndex = 2 Then
         OverlayControlEnable False
        ChatBannerControlEnable True
        
End If



End Sub

Private Sub cborotate_Click()




If cborotate.ListIndex = 1 Or cborotate.ListIndex = 3 Or cborotate.ListIndex = 5 Or cborotate.ListIndex = 7 Or cborotate.ListIndex = 9 Or cborotate.ListIndex = 11 Then

    If chkinvertcolor.Value = 1 Then
    
        MsgBox "You selected rotate value that cannot support invert color"
        Exit Sub
    End If
    
    If chkgrayscale.Value = 1 Then
    
        MsgBox "You selected rotate value that cannot support grayscale color"
        Exit Sub
        
    End If
    
End If

VideoChatSender1.Rotate cborotate.ListIndex

End Sub

Private Sub ChkCaptureToFile_Click()

If ChkCaptureToFile.Value = 1 Then
    Form2.Show 1
    strSelPath = Form2.Dir1.Path
    

End If

End Sub

Private Sub chkchatfillbg_Click()
If chkchatfillbg.Value = 1 Then
    Me.VideoChatSender1.ChatBannerFillBgColor True
Else
   Me.VideoChatSender1.ChatBannerFillBgColor False
End If

End Sub

Private Sub chkgrayscale_Click()
If chkgrayscale.Value = 1 Then
    
    If cborotate.ListIndex = 1 Or cborotate.ListIndex = 3 Or cborotate.ListIndex = 5 Or cborotate.ListIndex = 7 Or cborotate.ListIndex = 9 Or cborotate.ListIndex = 11 Then
        MsgBox "You selected rotate value cannot support grayscale"
    End If
    
    VideoChatSender1.GrayScale True
Else
   VideoChatSender1.GrayScale False
End If
End Sub

Private Sub chkhue_Click()
If chkhue.Value = 1 Then

    txthuer.Enabled = True
    txthueg.Enabled = True
    txthueb.Enabled = True


Else
    txthuer.Enabled = False
    txthueg.Enabled = False
    txthueb.Enabled = False
End If

End Sub

Private Sub chkinvertcolor_Click()
If chkinvertcolor.Value = 1 Then
    
    If cborotate.ListIndex = 1 Or cborotate.ListIndex = 3 Or cborotate.ListIndex = 5 Or cborotate.ListIndex = 7 Or cborotate.ListIndex = 9 Or cborotate.ListIndex = 11 Then
        MsgBox "You selected rotate value cannot support invert color"
    End If
    
    VideoChatSender1.InvertColor True
Else
    VideoChatSender1.InvertColor False
End If

End Sub

Private Sub chklightness_Click()

If chklightness.Value = 1 Then

    txlightnessr.Enabled = True
    txlightnessg.Enabled = True
    txlightnessb.Enabled = True


Else
    txlightnessr.Enabled = False
    txlightnessg.Enabled = False
    txlightnessb.Enabled = False
End If

End Sub

Private Sub cmdchatsend_Click()

chkchatfillbg_Click
cbochatstate_Click

Me.VideoChatSender1.ChatBannerAddText txtchat
End Sub

Private Sub cmddrawimage_Click()

VideoChatSender1.SetOverlayImage txtoverlayimage.Text
VideoChatSender1.SetOverlayImagePos txtoverlayimagex.Text, txtoverlayimagey.Text
VideoChatSender1.SetOverlayImageTransColor Red(ImageTrancolor), Green(ImageTrancolor), Blue(ImageTrancolor), txtoverlayimagealpha.Text

End Sub

Private Sub cmdfadetime_Click()
VideoChatSender1.ChatBannerFadeEdge txtchatfadein, txtchatfadeout
End Sub

Private Sub cmdfontbgcolor_Click()
 CommonDialog1.ShowColor

Bgfontcolor = CommonDialog1.Color

VideoChatSender1.ChatBannerBgColor Red(Bgfontcolor), Green(Bgfontcolor), Blue(Bgfontcolor), txtchatbgalpha

End Sub

Private Sub cmdfonttextcolor_Click()
 CommonDialog1.ShowColor

Textfontcolor = CommonDialog1.Color

VideoChatSender1.ChatBannerTextColor Red(Textfontcolor), Green(Textfontcolor), Blue(Textfontcolor), txtchattextalpha
End Sub

Private Sub cmdoverlayimageset_Click()
Me.CommonDialog1.Filter = "Bitmap File (*.bmp)|*.bmp|JPEG File (*.jpg)|*.jpg|Gif File (*.gif)|*.gif"
Me.CommonDialog1.ShowSave
txtoverlayimage.Text = CommonDialog1.FileName
VideoChatSender1.SetOverlayImage txtoverlayimage.Text
VideoChatSender1.SetOverlayImagePos txtoverlayimagex.Text, txtoverlayimagey.Text
End Sub

Private Sub cmdoverlayimagetranscolor_Click()
CommonDialog1.ShowColor

ImageTrancolor = CommonDialog1.Color

VideoChatSender1.SetOverlayImageTransColor Red(ImageTrancolor), Green(ImageTrancolor), Blue(ImageTrancolor), txtoverlayimagealpha.Text

End Sub

Private Sub cmdpos_Click()
VideoChatSender1.ChatBannerPos txtchatposx, txtchatposy
End Sub


Private Function Red(ByVal Color As Long) As Integer
    Red = Color Mod &H100
End Function

'-->RETURNS THE GREEN COLOR VALUE
Private Function Green(ByVal Color As Long) As Integer
    Green = (Color \ &H100) Mod &H100
End Function

'-->RETURNS THE BLUE COLOR VALUE
Private Function Blue(ByVal Color As Long) As Integer
    Blue = (Color \ &H10000) Mod &H100
End Function

Private Sub cmdspeed_Click()
VideoChatSender1.ChatBannerSpeed txtchatspeed
End Sub

Private Sub Command1_Click()


VideoChatSender1.ChatBannerDirection cbochatdir.ListIndex


VideoChatSender1.OverlayType = cbooverlaytype.ListIndex



VideoChatSender1.VideoDevice = cbovideodevice.ListIndex
VideoChatSender1.AudioDevice = cboaudiodevice.ListIndex

VideoChatSender1.VideoFormat = cbovideoformat.ListIndex
VideoChatSender1.FrameRate = txtframerate
VideoChatSender1.VideoBitrate = txtVideobitrate
VideoChatSender1.AudioComplexity = cboaudiocomplex.ListIndex
VideoChatSender1.AudioQuality = cboaudioquality.ListIndex
VideoChatSender1.SendVideoStream = chksendvideo.Value
VideoChatSender1.SendAudioStream = chksendaudio.Value

VideoChatSender1.ConferenceNumber = txtconfno.Text
VideoChatSender1.ConferenceUserID = txtuserid.Text

Label1.Caption = ""

iresult = VideoChatSender1.Connect(txtconnectIP.Text, txtConnectPortNo.Text)


If cbooverlaytype.ListIndex = 2 Then
 ChatBannerControlEnable True
 cmdchatsend_Click
End If



End Sub

Private Sub Command12_Click()

 If cborotate.ListIndex = 1 Or cborotate.ListIndex = 3 Or cborotate.ListIndex = 5 Or cborotate.ListIndex = 7 Or cborotate.ListIndex = 9 Or cborotate.ListIndex = 11 Then
        MsgBox "You selected rotate value cannot support this effect"
    End If
    
VideoChatSender1.Hue txthuer.Text, txthueg.Text, txthueb.Text
End Sub

Private Sub Command13_Click()
Me.VideoChatSender1.Hue -1, -1, -1
txthuer.Text = -1
txthueg.Text = -1
txthueb.Text = -1

End Sub

Private Sub Command10_Click()
Me.VideoChatSender1.ChatBannerDirection 2
End Sub

Private Sub Command14_Click()

 If cborotate.ListIndex = 1 Or cborotate.ListIndex = 3 Or cborotate.ListIndex = 5 Or cborotate.ListIndex = 7 Or cborotate.ListIndex = 9 Or cborotate.ListIndex = 11 Then
        MsgBox "You selected rotate value cannot support this effect"
    End If

VideoChatSender1.Lightness txlightnessr.Text, txlightnessg.Text, txlightnessb.Text
End Sub

Private Sub Command15_Click()
VideoChatSender1.Lightness -1, -1, -1

txlightnessr.Text = -1
txlightnessg.Text = -1
txlightnessb.Text = -1

End Sub

Private Sub Command2_Click()
VideoChatSender1.Disconnect

 ChatBannerControlEnable False
End Sub

Private Sub Command3_Click()



VideoChatReceiver1.ReceiveVideoStream = chkreceivevideo.Value
VideoChatReceiver1.ReceiveAudioStream = chkreceiveaudio.Value
VideoChatReceiver1.ReceiverVideoNoVideoImage txtnovideoimage


VideoChatReceiver1.ConferenceNumber = txtconfno.Text
VideoChatReceiver1.ConferenceUserID = txtuserid.Text

If ChkMaxfirstvideowindow.Value = True Then
            VideoChatReceiver1.VideoWindowAutoMax = True
Else
           VideoChatReceiver1.VideoWindowAutoMax = False
 End If
        
        
If RadioAspectRatio1.Value = True Then

    VideoChatReceiver1.VideoWindowAspectRatio = 0

ElseIf RadioAspectRatio2.Value = True Then

    VideoChatReceiver1.VideoWindowAspectRatio = 1

Else

 VideoChatReceiver1.VideoWindowAspectRatio = 2

End If


If OptMP4.Value = True Then
    VideoChatReceiver1.CaptureFileType = 0
Else
    VideoChatReceiver1.CaptureFileType = 1

End If


If ChkCaptureToFile.Value = 1 Then
    
    VideoChatReceiver1.CaptureMode = True
    VideoChatReceiver1.CaptureOutputFolder = strSelPath
    
    VideoChatReceiver1.MP4Width = txtmp4width
    VideoChatReceiver1.MP4Height = txtmp4height
    VideoChatReceiver1.MP4Audiochannel = txtaudiochannels
    VideoChatReceiver1.MP4Videobitrate = txtmp4videobitrate
    VideoChatReceiver1.MP4Audiobitrate = txtmp4audiobitrate
    VideoChatReceiver1.MP4FrameRate = txtmp4framerate
    VideoChatReceiver1.MP4AudioSamplerate = txtmp4audiosamplerate
    
    
    
    
Else

    VideoChatReceiver1.CaptureMode = False


End If

If txtPeertoPeerListenIP <> "0" Then
bresult = VideoChatReceiver1.Listen(txtPeertoPeerListenIP.Text, txtConnectPortNo.Text)

Else

bresult = VideoChatReceiver1.Listen(txtconnectIP.Text, txtConnectPortNo.Text)
End If

If bresult <> True Then
    
    MsgBox "fail"

End If


Command3.Enabled = False
Command4.Enabled = True

End Sub

Private Sub Command4_Click()
VideoChatReceiver1.Disconnect

Command3.Enabled = True
Command4.Enabled = False

End Sub

Private Sub Command5_Click()
MsgBox VideoChatSender1.GetIPAddress

End Sub

Private Sub Command6_Click()

On Error Resume Next
Me.CommonDialog1.Filter = "JPEG File (*.jpg)|*.jpg"
Me.CommonDialog1.ShowSave

Me.VideoChatReceiver1.SnapShot txtindexvideowindow, CommonDialog1.FileName
End Sub

Private Sub Command7_Click()
Me.VideoChatReceiver1.ShowOneToOneMode txtindexvideowindow
End Sub

Private Sub Command8_Click()
Me.VideoChatReceiver1.CloseOneToOneMode
End Sub

Private Sub Command9_Click()
Me.VideoChatSender1.ChatBannerDirection 0

End Sub

Private Sub Form_Load()

ImageTrancolor = RGB(0, 0, 0)

cbochatdir.AddItem "Up"
cbochatdir.AddItem "Down"
cbochatdir.AddItem "Left"
cbochatdir.AddItem "Right"
cbochatdir.ListIndex = 2


cbochatfont.AddItem "Arial"
cbochatfont.AddItem "Impact"
cbochatfont.AddItem "Comic Sans MS"
cbochatfont.AddItem "Courier New"

cbochatfont.ListIndex = 0

cbochatfontstyle.AddItem "Regular"
cbochatfontstyle.AddItem "Bold"
cbochatfontstyle.AddItem "Italic"
cbochatfontstyle.ListIndex = 0




For i = 8 To 80 Step 2
    cbochatfontsize.AddItem Trim(Str(i))

Next
cbochatfontsize.ListIndex = 30


cbochatstate.AddItem "Scrolling Banner"
cbochatstate.AddItem "Stay"
cbochatstate.AddItem "Hide"
cbochatstate.ListIndex = 0

cbooverlaytype.AddItem "No Effects"
cbooverlaytype.AddItem "Overlay Effects"
cbooverlaytype.AddItem "Chat Banner Plugin"
cbooverlaytype.ListIndex = 0

cborotate.AddItem "No Rotation"
cborotate.AddItem "90-degree rotation without flipping"
cborotate.AddItem "180-degree rotation without flipping"
cborotate.AddItem "270-degree rotation without flipping"
cborotate.AddItem "no rotation and a horizontal flip"
cborotate.AddItem "90-degree rotation followed by a horizontal flip"
cborotate.AddItem "180-degree rotation followed by a horizontal flip"
cborotate.AddItem "270-degree rotation followed by a horizontal flip"
cborotate.AddItem "no rotation and a vertical flip"
cborotate.AddItem "90-degree rotation followed by a vertical flip"
cborotate.AddItem "180-degree rotation followed by a vertical flip"
cborotate.AddItem "270-degree rotation followed by a vertical flip"
cborotate.ListIndex = 0



Me.txtnovideoimage.Text = App.Path + "\novideo.bmp"
Me.txtoverlayimage.Text = App.Path + "\image.bmp"
ivideodevicecount = VideoChatSender1.GetVideoDeviceCount

For i = 0 To ivideodevicecount - 1
    cbovideodevice.AddItem (VideoChatSender1.GetVideoDeviceName(i))
Next

If cbovideodevice.ListCount > 0 Then
    cbovideodevice.ListIndex = 0
End If

iaudiodevicecount = VideoChatSender1.GetAudioDeviceCount

For i = 0 To iaudiodevicecount - 1
    cboaudiodevice.AddItem (VideoChatSender1.GetAudioDeviceName(i))
Next

If cboaudiodevice.ListCount > 0 Then
    cboaudiodevice.ListIndex = 0
End If

cbovideoformat.AddItem ("160x120")
cbovideoformat.AddItem ("176x144")
cbovideoformat.AddItem ("320x240")
cbovideoformat.AddItem ("352x288")
cbovideoformat.AddItem ("640x480")
cbovideoformat.AddItem ("1280x720")
cbovideoformat.ListIndex = 4

cboaudiocomplex.AddItem ("0")
cboaudiocomplex.AddItem ("1")
cboaudiocomplex.AddItem ("2")
cboaudiocomplex.AddItem ("3")
cboaudiocomplex.ListIndex = 0

For i = 0 To 10
    cboaudioquality.AddItem (Trim(Str(i)))
Next
cboaudioquality.ListIndex = 8










End Sub

Private Sub Form_Unload(Cancel As Integer)
VideoChatSender1.Disconnect
VideoChatReceiver1.Disconnect

End Sub

Private Sub VideoChatReceiver1_OnNewUserConnection(ByVal iConferenceNumber As Long, ByVal iUserID As Long)
Me.ListEvent.AddItem "User ID:" + Str(iUserID) + " Confer :" + Str(iConferenceNumber)
End Sub

Private Sub VideoChatReceiver1_OnUserConnectionLost(ByVal iConferenceNumber As Long, ByVal iUserID As Long)
Me.ListEvent.AddItem "Disconnected User ID:" + Str(iUserID) + " Confer :" + Str(iConferenceNumber)

End Sub

Private Sub VideoChatSender1_SendStream(ByVal fVideoBitrate As Single, ByVal fAudioBitrate As Single)
lblvideobitrate.Caption = fVideoBitrate
lblaudiobitrate.Caption = fAudioBitrate
End Sub
