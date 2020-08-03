object Form2: TForm2
  Left = 339
  Top = 183
  Width = 425
  Height = 238
  Caption = 'Video Chat Pro Server Information'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 16
    Top = 24
    Width = 171
    Height = 13
    Caption = 'IP Address of Video Chat Pro Server'
  end
  object Label2: TLabel
    Left = 16
    Top = 64
    Width = 36
    Height = 13
    Caption = 'Port No'
  end
  object Label3: TLabel
    Left = 16
    Top = 104
    Width = 95
    Height = 13
    Caption = 'Conference Number'
  end
  object Label4: TLabel
    Left = 16
    Top = 128
    Width = 36
    Height = 13
    Caption = 'User ID'
  end
  object Label5: TLabel
    Left = 232
    Top = 96
    Width = 164
    Height = 13
    Caption = 'Enter 0 for Peer to Peer video chat'
  end
  object txtIPServer: TEdit
    Left = 216
    Top = 16
    Width = 97
    Height = 21
    TabOrder = 0
    Text = '127.0.0.1'
  end
  object txtPortNo: TEdit
    Left = 128
    Top = 64
    Width = 97
    Height = 21
    TabOrder = 1
    Text = '1234'
  end
  object txtConfNumber: TEdit
    Left = 128
    Top = 96
    Width = 97
    Height = 21
    TabOrder = 2
  end
  object txtUserID: TEdit
    Left = 128
    Top = 128
    Width = 97
    Height = 21
    TabOrder = 3
  end
  object Button1: TButton
    Left = 232
    Top = 144
    Width = 89
    Height = 33
    Caption = 'OK'
    TabOrder = 4
    OnClick = Button1Click
  end
end
