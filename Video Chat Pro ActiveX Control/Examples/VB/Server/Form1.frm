VERSION 5.00
Object = "{36C459D9-51C7-42FC-9463-D3E34EFF12AD}#1.0#0"; "VideoChatServer.ocx"
Begin VB.Form Form1 
   Caption         =   "Video Chat Pro Server"
   ClientHeight    =   8145
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   9210
   LinkTopic       =   "Form1"
   ScaleHeight     =   8145
   ScaleWidth      =   9210
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox Check1 
      Caption         =   "The Conference Number, User ID use Random Number"
      Height          =   495
      Left            =   5160
      TabIndex        =   11
      Top             =   120
      Value           =   1  'Checked
      Width           =   4095
   End
   Begin VB.TextBox txtPort 
      Height          =   375
      Left            =   1920
      TabIndex        =   10
      Text            =   "1234"
      Top             =   120
      Width           =   1455
   End
   Begin VB.TextBox txtSelUserID 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5400
      TabIndex        =   7
      Top             =   3240
      Width           =   3375
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Add User to this Conference "
      Enabled         =   0   'False
      Height          =   495
      Left            =   5160
      TabIndex        =   5
      Top             =   1440
      Width           =   2775
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Create Conference"
      Height          =   495
      Left            =   5160
      TabIndex        =   4
      Top             =   720
      Width           =   2775
   End
   Begin VB.ListBox List2 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   5190
      Left            =   600
      TabIndex        =   3
      Top             =   2400
      Width           =   4455
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1920
      TabIndex        =   1
      Top             =   600
      Width           =   2655
   End
   Begin VideoChatServerLib.VideoChatServer VideoChatServer1 
      Height          =   1695
      Left            =   6000
      TabIndex        =   0
      Top             =   5640
      Width           =   2775
      _Version        =   65536
      _ExtentX        =   4895
      _ExtentY        =   2990
      _StockProps     =   0
   End
   Begin VB.Label Label4 
      Caption         =   "Server Port No."
      Height          =   375
      Left            =   360
      TabIndex        =   9
      Top             =   120
      Width           =   1575
   End
   Begin VB.Label Label3 
      Caption         =   "Selected User ID"
      Height          =   375
      Left            =   5400
      TabIndex        =   8
      Top             =   2760
      Width           =   1575
   End
   Begin VB.Label Label2 
      Caption         =   "User ID  (if the user connected, it will mark *** )"
      Height          =   375
      Left            =   600
      TabIndex        =   6
      Top             =   1800
      Width           =   3975
   End
   Begin VB.Label Label1 
      Caption         =   "Conference Number"
      Height          =   255
      Left            =   360
      TabIndex        =   2
      Top             =   720
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()



End Sub


Private Sub Command2_Click()

End Sub

Private Sub Command3_Click()


Me.VideoChatServer1.InitServer txtPort.Text, 300


If Check1.Value = 1 Then
    Me.VideoChatServer1.UseRandomNumber = True
Else
    Me.VideoChatServer1.UseRandomNumber = False
End If



Text1.Text = VideoChatServer1.CreateConference

List2.Clear

Command3.Enabled = False
Command4.Enabled = True

End Sub

Private Sub Command4_Click()

MyUserID = VideoChatServer1.AddUser(Trim(Text1.Text))


If MyUserID <> 0 Then
    Me.List2.AddItem Str(MyUserID)
Else
    MsgBox "Max is 12 user per Room"
End If




End Sub

Private Sub Command5_Click()


iCount = List2.ListCount - 1

For i = 0 To iCount
    If List2.List(i) = Text2 Then
        List2.RemoveItem i
    End If
    
Next

End Sub



Private Sub Command7_Click()
iCount = List2.ListCount - 1

For i = 0 To iCount
    If List2.List(i) = "888" Then
        List2.List(i) = "888***"
    End If
    
Next
End Sub

Private Sub Form_Load()

Me.VideoChatServer1.LicenseKey = "12345"
End Sub



Private Sub Form_Unload(Cancel As Integer)
Me.VideoChatServer1.UnInitServer
End Sub

Private Sub List2_Click()
txtSelUserID.Text = List2.List(List2.ListIndex)
End Sub

Private Sub VideoChatServer1_AllClientDisconnected(ByVal iConfNumber As Long)

MsgBox "All client disconnected"

List2.Clear

End Sub

Private Sub VideoChatServer1_ClientConnected(ByVal iConfNumber As Long, ByVal iUserID As Long)

iCount = List2.ListCount - 1

For i = 0 To iCount
    If Trim(List2.List(i)) = Trim(Str(iUserID)) Then
              List2.List(i) = Trim(Str(iUserID)) + "***"
  
    End If
    
Next

List2.Refresh


End Sub

Private Sub VideoChatServer1_ClientDisconnected(ByVal iConfNumber As Long, ByVal iUserID As Long)


iCount = List2.ListCount - 1


For i = 0 To iCount
strUserID = Trim(List2.List(i))

       
    If strUserID = Trim(Str(iUserID)) + "***" Then  'update list box , remove ***
                 
              List2.List(i) = Trim(Str(iUserID))
              
  
    End If
    
Next

List2.Refresh


End Sub
