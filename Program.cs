Console.Write("Input: ");
string text = "foiraalAJrucnn";
Console.WriteLine(DeCode(text));

static string encode(string text)
{
char[] firstArray = text.Substring(0, text.Length / 2).ToCharArray();
char[] secondArray = text.Substring(text.Length / 2).ToCharArray();

string Odd = "";
string Even = "";

for (int i = 0; i < firstArray.Length; i++)
{
    if (i % 2 == 0)
    {
        Odd += firstArray[i];
        Odd += secondArray[i];
    }
}
for (int i = 0; i < secondArray.Length; i++)
{ 
    if (i % 2 != 0)
    {
        Even += firstArray[i];
        Even += secondArray[i];
    }
}
Even += secondArray[secondArray.Length - 1];
var fullEncode =  Even + Odd;
Console.WriteLine("Code: " + fullEncode);
return fullEncode;
}



static string DeCode(string text)
{
char[] firstArray = text.Substring(0, text.Length / 2).ToCharArray();
char[] secondArray = text.Substring(text.Length / 2).ToCharArray();


string Odd = "";
string Even = "";

for (int i = 0; i < firstArray.Length-1; i++)
{
    if (i % 2 == 0)
    {
        Odd += secondArray[i];
        Odd += firstArray[i];
    }
}
Odd += firstArray[firstArray.Length - 1];
for (int i = 0; i < secondArray.Length -1; i++)
{
    if (i % 2 != 0)
    {
        Even += secondArray[i];
        Even += firstArray[i];
    }

}
Even += firstArray[firstArray.Length - 1];
string fullDecode = Odd + Even;

Console.WriteLine("Decode: " + fullDecode);
return  fullDecode;
}