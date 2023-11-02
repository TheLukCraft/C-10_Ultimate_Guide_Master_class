//inplicit casting - rzutowanie niejawne
//sbyte
sbyte a = 10;

//int
int b;

//not working, because higher value
//uint b;

//copy the value from "a" to "b"
b = a;

Console.WriteLine(a); //10
Console.WriteLine(b); //10

//-------------------------------------
//explicit casting - rzutowanie jawne
int x = 100;

float y;

y = (float)x;

int c = 500;

byte d;

d = (byte)c;

//-------------------------------------
//Parsing - only numbers. You can't convert characters or strings.
string f = "100";
//int.Parse(a);

//But you can do that. If string contains spaces, other characters then you can't.
int g;
g = int.Parse(f);

//-------------------------------------
string h;
Console.WriteLine("Enter a number: ");
h = Console.ReadLine();

//TryParse
bool k = int.TryParse(h, out int j);
if (k == true)
    Console.WriteLine("Conversion is successful");
else
    Console.WriteLine("Conversion failed");