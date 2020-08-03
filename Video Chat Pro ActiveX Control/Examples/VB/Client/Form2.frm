VERSION 5.00
Begin VB.Form Form2 
   Caption         =   "Select Output Folder"
   ClientHeight    =   3480
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   5190
   LinkTopic       =   "Form2"
   ScaleHeight     =   3480
   ScaleWidth      =   5190
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "OK"
      Height          =   375
      Left            =   3960
      TabIndex        =   1
      Top             =   240
      Width           =   975
   End
   Begin VB.DirListBox Dir1 
      Height          =   2340
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   3495
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Hide
End Sub
