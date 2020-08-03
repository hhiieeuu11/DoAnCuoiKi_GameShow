object Form1: TForm1
  Left = 492
  Top = 259
  Width = 639
  Height = 472
  Caption = 'Video Chat Pro Server'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnClose = FormClose
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 16
    Top = 16
    Width = 73
    Height = 13
    Caption = 'Server Port No.'
  end
  object Label2: TLabel
    Left = 16
    Top = 40
    Width = 95
    Height = 13
    Caption = 'Conference Number'
  end
  object Label3: TLabel
    Left = 16
    Top = 72
    Width = 220
    Height = 13
    Caption = 'User ID  (if the user connected, it will mark *** )'
  end
  object Label4: TLabel
    Left = 392
    Top = 144
    Width = 84
    Height = 13
    Caption = 'Selected  User ID'
  end
  object txtPortNo: TEdit
    Left = 120
    Top = 8
    Width = 97
    Height = 21
    TabOrder = 0
    Text = '1234'
  end
  object txtconfnumber: TEdit
    Left = 120
    Top = 32
    Width = 97
    Height = 21
    TabOrder = 1
  end
  object ListBox1: TListBox
    Left = 16
    Top = 112
    Width = 313
    Height = 305
    ItemHeight = 13
    TabOrder = 2
    OnClick = ListBox1Click
  end
  object Button1: TButton
    Left = 392
    Top = 40
    Width = 153
    Height = 33
    Caption = 'Create Conference'
    TabOrder = 3
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 392
    Top = 88
    Width = 153
    Height = 41
    Caption = 'Add User to this Conference '
    Enabled = False
    TabOrder = 4
    OnClick = Button2Click
  end
  object txtSelUserID: TEdit
    Left = 384
    Top = 168
    Width = 161
    Height = 21
    TabOrder = 6
  end
  object CheckBox1: TCheckBox
    Left = 328
    Top = 8
    Width = 289
    Height = 17
    Caption = 'The Conference Number, User ID use Random Number'
    Checked = True
    State = cbChecked
    TabOrder = 5
  end
  object VideoChatServer1: TVideoChatServer
    Left = 392
    Top = 248
    Width = 65
    Height = 65
    TabOrder = 7
    ControlData = {00000100B8060000B806000000000000000444656D6F}
  end
end
