unit Unit2;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm2 = class(TForm)
    Label1: TLabel;
    txtIPServer: TEdit;
    Label2: TLabel;
    txtPortNo: TEdit;
    Label3: TLabel;
    txtConfNumber: TEdit;
    Label4: TLabel;
    Button1: TButton;
    txtUserID: TEdit;
    Label5: TLabel;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;

implementation

uses Unit1;

{$R *.dfm}

procedure TForm2.Button1Click(Sender: TObject);
begin


    if txtconfnumber.Text ='' then
    begin
      showmessage('Please enter conference number');
      exit;
    end;

    if txtUserID.Text ='' then
    begin
      showmessage('Please enter UserID');
      exit;
    end;


    Form1.txtconnectIP.Text:= txtIPServer.Text;
    Form1.txtConnectPortNo.Text:=txtPortNo.Text;
    Form1.txtListenIP.text := txtIPServer.Text;
    Form1.txtlistenportno.text :=txtPortNo.Text;
    Form1.txtConfNumber.text :=txtconfnumber.Text;
    Form1.txtUserID.text :=txtUserID.Text;

   
    Form1.Show


end;

end.
