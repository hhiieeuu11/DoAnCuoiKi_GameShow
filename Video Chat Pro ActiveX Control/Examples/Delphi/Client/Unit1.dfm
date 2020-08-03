object Form1: TForm1
  Left = 141
  Top = 212
  Width = 1222
  Height = 619
  Caption = 'Video Chat Pro ActiveX Control'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnActivate = FormActivate
  OnClose = FormClose
  PixelsPerInch = 96
  TextHeight = 13
  object Label4: TLabel
    Left = 24
    Top = 8
    Width = 95
    Height = 13
    Caption = 'Conference Number'
  end
  object Label16: TLabel
    Left = 328
    Top = 8
    Width = 36
    Height = 13
    Caption = 'User ID'
  end
  object GroupBox1: TGroupBox
    Left = 16
    Top = 40
    Width = 601
    Height = 537
    Caption = 'Connect'
    TabOrder = 0
    object Label1: TLabel
      Left = 16
      Top = 32
      Width = 64
      Height = 13
      Caption = 'Video Device'
    end
    object Label2: TLabel
      Left = 16
      Top = 56
      Width = 64
      Height = 13
      Caption = 'Audio Device'
    end
    object Label3: TLabel
      Left = 16
      Top = 88
      Width = 62
      Height = 13
      Caption = 'Video Format'
    end
    object Label5: TLabel
      Left = 392
      Top = 64
      Width = 80
      Height = 13
      Caption = 'Audio Complexity'
    end
    object Label6: TLabel
      Left = 264
      Top = 88
      Width = 55
      Height = 13
      Caption = 'Frame Rate'
    end
    object Label7: TLabel
      Left = 392
      Top = 96
      Width = 62
      Height = 13
      Caption = 'Audio Quality'
    end
    object Label8: TLabel
      Left = 16
      Top = 120
      Width = 60
      Height = 13
      Caption = 'Video Bitrate'
    end
    object Label9: TLabel
      Left = 160
      Top = 120
      Width = 16
      Height = 13
      Caption = 'bits'
    end
    object Label10: TLabel
      Left = 16
      Top = 152
      Width = 106
      Height = 13
      Caption = 'Connect to IP Address'
    end
    object Label11: TLabel
      Left = 264
      Top = 152
      Width = 36
      Height = 13
      Caption = 'Port No'
    end
    object Label12: TLabel
      Left = 16
      Top = 192
      Width = 101
      Height = 13
      Caption = 'Video bitrate (bit/sec)'
    end
    object lblvideobitrate: TLabel
      Left = 144
      Top = 192
      Width = 6
      Height = 13
      Caption = '0'
    end
    object Label13: TLabel
      Left = 272
      Top = 192
      Width = 101
      Height = 13
      Caption = 'Audio bitrate (bit/sec)'
    end
    object lblaudiobitrate: TLabel
      Left = 384
      Top = 192
      Width = 6
      Height = 13
      Caption = '0'
    end
    object cbovideodevice: TComboBox
      Left = 96
      Top = 32
      Width = 273
      Height = 21
      Style = csDropDownList
      ItemHeight = 13
      TabOrder = 0
    end
    object cboaudiodevice: TComboBox
      Left = 96
      Top = 56
      Width = 273
      Height = 21
      Style = csDropDownList
      ItemHeight = 13
      TabOrder = 1
    end
    object cbovideoformat: TComboBox
      Left = 96
      Top = 88
      Width = 161
      Height = 21
      Style = csDropDownList
      ItemHeight = 13
      TabOrder = 2
    end
    object cboaudiocomplex: TComboBox
      Left = 480
      Top = 64
      Width = 105
      Height = 21
      Style = csDropDownList
      ItemHeight = 13
      TabOrder = 3
    end
    object txtframerate: TEdit
      Left = 328
      Top = 88
      Width = 49
      Height = 21
      TabOrder = 4
      Text = '15'
    end
    object cboaudioquality: TComboBox
      Left = 480
      Top = 96
      Width = 105
      Height = 21
      Style = csDropDownList
      ItemHeight = 13
      TabOrder = 5
    end
    object txtVideobitrate: TEdit
      Left = 96
      Top = 120
      Width = 57
      Height = 21
      TabOrder = 6
      Text = '90000'
    end
    object chksendvideo: TCheckBox
      Left = 200
      Top = 120
      Width = 121
      Height = 17
      Caption = 'Send Video Stream'
      Checked = True
      State = cbChecked
      TabOrder = 7
    end
    object chksendaudio: TCheckBox
      Left = 336
      Top = 120
      Width = 121
      Height = 17
      Caption = 'Send Audio Stream'
      Checked = True
      State = cbChecked
      TabOrder = 8
    end
    object txtconnectIP: TEdit
      Left = 128
      Top = 152
      Width = 121
      Height = 21
      TabOrder = 9
      Text = '127.0.0.1'
    end
    object txtConnectPortNo: TEdit
      Left = 320
      Top = 152
      Width = 65
      Height = 21
      TabOrder = 10
      Text = '7000'
    end
    object Button1: TButton
      Left = 400
      Top = 152
      Width = 89
      Height = 33
      Caption = 'Connect'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = [fsBold]
      ParentFont = False
      TabOrder = 11
      OnClick = Button1Click
    end
    object Button2: TButton
      Left = 504
      Top = 152
      Width = 75
      Height = 33
      Caption = 'Disconnect'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = [fsBold]
      ParentFont = False
      TabOrder = 12
      OnClick = Button2Click
    end
    object VideoChatSender1: TVideoChatSender
      Left = 40
      Top = 232
      Width = 513
      Height = 297
      TabOrder = 13
      ControlData = {
        0000010005350000B21E0000000000000444656D6F000001010000102700000F
        000000080000000000000000000000000000}
    end
  end
  object GroupBox2: TGroupBox
    Left = 624
    Top = 40
    Width = 537
    Height = 537
    Caption = 'Listen'
    TabOrder = 1
    object Label14: TLabel
      Left = 24
      Top = 392
      Width = 54
      Height = 13
      Caption = 'Listen From'
    end
    object Label15: TLabel
      Left = 184
      Top = 392
      Width = 36
      Height = 13
      Caption = 'Port No'
    end
    object txtListenIP: TEdit
      Left = 88
      Top = 392
      Width = 89
      Height = 21
      TabOrder = 0
      Text = '127.0.0.1'
    end
    object txtlistenportno: TEdit
      Left = 232
      Top = 392
      Width = 57
      Height = 21
      TabOrder = 1
      Text = '7000'
    end
    object chkreceivevideo: TCheckBox
      Left = 24
      Top = 440
      Width = 129
      Height = 25
      Caption = 'Receive Video Stream'
      Checked = True
      State = cbChecked
      TabOrder = 2
    end
    object chkreceiveaudio: TCheckBox
      Left = 168
      Top = 440
      Width = 145
      Height = 25
      Caption = 'Received Audio Stream'
      Checked = True
      State = cbChecked
      TabOrder = 3
    end
    object Button3: TButton
      Left = 16
      Top = 480
      Width = 97
      Height = 33
      Caption = 'Start Listening'
      TabOrder = 4
      OnClick = Button3Click
    end
    object Button4: TButton
      Left = 120
      Top = 480
      Width = 97
      Height = 33
      Caption = 'Disconnect'
      TabOrder = 5
      OnClick = Button4Click
    end
    object Button5: TButton
      Left = 224
      Top = 480
      Width = 97
      Height = 33
      Caption = 'Read IP'
      TabOrder = 6
      OnClick = Button5Click
    end
    object VideoChatReceiver1: TVideoChatReceiver
      Left = 16
      Top = 16
      Width = 505
      Height = 369
      TabOrder = 7
      ControlData = {00000100313400002326000000000000000444656D6F000000000000000000}
    end
  end
  object txtConfNumber: TEdit
    Left = 144
    Top = 8
    Width = 129
    Height = 21
    TabOrder = 2
  end
  object txtUserID: TEdit
    Left = 392
    Top = 8
    Width = 113
    Height = 21
    TabOrder = 3
  end
end
