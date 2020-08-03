VERSION 5.00
Begin VB.Form FormConnect 
   Caption         =   "Connect "
   ClientHeight    =   5730
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   7230
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5730
   ScaleWidth      =   7230
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtcurrentIP 
      Height          =   495
      Left            =   4200
      TabIndex        =   13
      Text            =   "127.0.0.1"
      Top             =   2040
      Width           =   2295
   End
   Begin VB.Frame Frame1 
      Caption         =   "Type"
      Height          =   855
      Left            =   240
      TabIndex        =   9
      Top             =   120
      Width           =   6375
      Begin VB.OptionButton Option2 
         Caption         =   "Multiple people video chat"
         Height          =   255
         Left            =   2880
         TabIndex        =   11
         Top             =   360
         Width           =   2295
      End
      Begin VB.OptionButton Option1 
         Caption         =   "One to One video chat"
         Height          =   255
         Left            =   240
         TabIndex        =   10
         Top             =   360
         Value           =   -1  'True
         Width           =   2295
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "OK"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5160
      TabIndex        =   8
      Top             =   4920
      Width           =   1455
   End
   Begin VB.TextBox txtConfUserID 
      Height          =   495
      Left            =   2880
      TabIndex        =   7
      Text            =   "0"
      Top             =   4920
      Width           =   1815
   End
   Begin VB.TextBox txtConfNumber 
      Height          =   615
      Left            =   2880
      TabIndex        =   5
      Text            =   "0"
      Top             =   3840
      Width           =   1815
   End
   Begin VB.TextBox txtServerPortNo 
      Height          =   615
      Left            =   2880
      TabIndex        =   2
      Text            =   "1234"
      Top             =   2880
      Width           =   1815
   End
   Begin VB.TextBox txtServerIP 
      Height          =   495
      Left            =   4200
      TabIndex        =   1
      Text            =   "127.0.0.1"
      Top             =   1200
      Width           =   2295
   End
   Begin VB.Label Label5 
      Caption         =   "IP Addresss of Current computer (For Listening)"
      BeginProperty Font 
         Name            =   "Arial Narrow"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   12
      Top             =   2040
      Width           =   3735
   End
   Begin VB.Label Label4 
      Caption         =   "User ID"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   120
      TabIndex        =   6
      Top             =   4920
      Width           =   2415
   End
   Begin VB.Label Label3 
      Caption         =   "Conference Number"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   120
      TabIndex        =   4
      Top             =   3960
      Width           =   2535
   End
   Begin VB.Label Label2 
      Caption         =   "Port No"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   120
      TabIndex        =   3
      Top             =   2880
      Width           =   2415
   End
   Begin VB.Label Label1 
      Caption         =   "Stream to IP address"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   1200
      Width           =   3975
   End
End
Attribute VB_Name = "FormConnect"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()


If Me.txtServerIP.Text = "" Then
    MsgBox "Please enter Server IP address"
    
     Exit Sub
End If

If Me.txtServerPortNo.Text = "" Then
    MsgBox "Please enter Server Port No."
    
     Exit Sub
End If



If Me.txtConfNumber.Text = "" Then
    
    MsgBox "Please enter Conference Number"
    
    Exit Sub
End If


If Me.txtConfUserID.Text = "" Then
    
    MsgBox "Please enter Conference User ID"
    
     Exit Sub
End If


Load Form1

Form1.txtconnectIP.Text = txtServerIP.Text
Form1.txtConnectPortNo.Text = txtServerPortNo.Text
Form1.txtconfno.Text = txtConfNumber.Text
Form1.txtuserid.Text = txtConfUserID.Text
Form1.txtPeertoPeerListenIP.Text = txtcurrentIP.Text

If txtConfNumber.Text = "0" Then
    Form1.Label7.Caption = "Stream to IP address"

Else
     Form1.Label7.Caption = "IP address of Video Chat Pro server"

End If


Unload Me

Form1.Show


End Sub

Private Sub Option1_Click()
txtConfNumber.Text = "0"
txtConfUserID.Text = "0"
txtConfNumber.Enabled = False
txtConfUserID.Enabled = False

txtcurrentIP.Enabled = True


Label1.Caption = "Stream to IP address "


End Sub

Private Sub Option2_Click()
txtConfNumber.Text = "5000"
txtConfUserID.Text = "10000"
txtcurrentIP.Text = "0"
txtcurrentIP.Enabled = False

Label1.Caption = "IP address of Video Chat Pro server"
txtConfNumber.Enabled = True
txtConfUserID.Enabled = True


End Sub

Private Sub txtConfNumber_Validate(Cancel As Boolean)
If Not IsNumeric(txtConfNumber.Text) Then
    MsgBox "Please enter numbers only"
     txtConfNumber.Text = ""
    Cancel = True
End If

    
End Sub

Private Sub txtConfUserID_Validate(Cancel As Boolean)

If Not IsNumeric(txtConfUserID.Text) Then
    MsgBox "Please enter numbers only"
     txtConfUserID.Text = ""
    Cancel = True
End If


End Sub
