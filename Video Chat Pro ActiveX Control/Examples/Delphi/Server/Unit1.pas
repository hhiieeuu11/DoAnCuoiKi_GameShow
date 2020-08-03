unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, OleCtrls, VideoChatServerLib_TLB;

type
  TForm1 = class(TForm)
    Label1: TLabel;
    txtPortNo: TEdit;
    Label2: TLabel;
    txtconfnumber: TEdit;
    ListBox1: TListBox;
    Label3: TLabel;
    Button1: TButton;
    Button2: TButton;
    Label4: TLabel;
    txtSelUserID: TEdit;
    CheckBox1: TCheckBox;
    VideoChatServer1: TVideoChatServer;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure VideoChatServer1ClientConnected(ASender: TObject;
      iConfNumber, iUserID: Integer);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure VideoChatServer1ClientDisconnected(ASender: TObject;
      iConfNumber, iUserID: Integer);
    procedure VideoChatServer1AllClientDisconnected(ASender: TObject;
      iConfNumber: Integer);
    procedure ListBox1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
var iconfid : Integer;
begin

VideoChatServer1.InitServer(strtoint(txtPortNo.Text),300);

if checkbox1.Checked then
  VideoChatServer1.UseRandomNumber:=true
else
  VideoChatServer1.UseRandomNumber:=false;

iconfid :=VideoChatServer1.CreateConference;

 txtconfnumber.Text:=Format('%d',[iconfid]);

 ListBox1.Items.Clear();

 Button1.Enabled:=false;
 Button2.Enabled:=true;

end;

procedure TForm1.Button2Click(Sender: TObject);
var iuserid : Integer;
begin


iuserid:=VideoChatServer1.AddUser(strtoint(txtconfnumber.Text));


  if iuserid <> 0 then
           ListBox1.Items.Add(Format('%d',[iuserid]))
  else
         ShowMessage('Max is 12 user per Room');


end;

procedure TForm1.Button3Click(Sender: TObject);
var iCount : Integer;
var i: Integer;
begin



end;

procedure TForm1.VideoChatServer1ClientConnected(ASender: TObject;
  iConfNumber, iUserID: Integer);
var iCount : Integer;
var i: Integer;
begin




  iCount := ListBox1.Items.Count;


 For i:= 0 to iCount-1 do
   begin
        if iUserID =  strtoint(ListBox1.Items[i]) then
         ListBox1.Items[i]:=ListBox1.Items[i]+'***';
   end;




end;

procedure TForm1.FormClose(Sender: TObject; var Action: TCloseAction);
begin
    VideoChatServer1.UnInitServer;    
end;

procedure TForm1.VideoChatServer1ClientDisconnected(ASender: TObject;
  iConfNumber, iUserID: Integer);
var iCount : Integer;
var i: Integer;
var strUserID: String;

begin


iCount := ListBox1.Items.Count;


   For i:= 0 to iCount-1 do
   begin
        strUserID:= Format('%d',[iUserID]);

        if strUserID+'***' = ListBox1.Items[i] then
         ListBox1.Items[i]:= strUserID;
   end;
end;

procedure TForm1.VideoChatServer1AllClientDisconnected(ASender: TObject;
  iConfNumber: Integer);
begin

ShowMessage('All client disconnected');

ListBox1.Clear;

end;

procedure TForm1.ListBox1Click(Sender: TObject);
begin

      txtSelUserID.Text:= ListBox1.Items[ListBox1.ItemIndex];
end;

end.
