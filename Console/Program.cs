// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Console.Write("Lütfen Adınızı giriniz: ");
//var ad = Console.ReadLine();
//Console.WriteLine("Müşteri Adı: "+ad);
#region Değişkenler

int deger = 12; //4 byte
string name = null;
name = "Selim BAYINDIR";
string ver = "Merhaba";
byte b = 255; //1 byte 
sbyte c = 127; //1buyte
short s = 32767;//2 byte
ushort u = 5; //2 byte
Int16 i16 = 11; //2 BYTE
Int32 i32 = 11; //4 BYTE
Int64 i64 = 11; //8 BYTE
long l = 4;// 8 byte
ulong ul = 4; //8 byte
float f = 4; //4 byte
double d = 5; //8 byte
decimal x = 8;//16 byte

DateTime dt = new DateTime();
dt=DateTime.Now;
Console.WriteLine("Saat: "+dt.Hour);
string datetimehour = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
Console.WriteLine(datetimehour);
Console.WriteLine(deger+" "+ver+" "+name);


#endregion
#region Operatörler
int a = 2;
int y = 3;
y += 2;
Console.WriteLine(y);
y /= 1;
Console.WriteLine(y);
a += 3;
Console.WriteLine(a);
///MANTIKSAL OPERATORLER
bool isSuccess =true;
bool isCompleted = true;
if (isCompleted && isSuccess)
    Console.WriteLine("Perfect");
if (isCompleted || isSuccess)
    Console.WriteLine("Great");
if (isCompleted && !isSuccess)
    Console.WriteLine("Fine");
/// iLİŞKİSEL OPERATORLER
//<,>,<=,=>,==,!=
int xc= 7;
int cx = 8;
bool sonuc = xc < cx;
if (sonuc)
    Console.WriteLine($"xc({xc}) - cx({cx}) küçüktür..");
  
else 
{
    Console.WriteLine($"xc({xc}) - cx({cx}) büyüktür..");

}
#endregion
