console.log("Input: ");
let text = DeCode(encode("AfricanJournal"));
console.log(text);

function encode(text)
{
let firstArray = text.substring(0, text.Length / 2);
let secondArray = text.substring(text.Length / 2);

let Odd = "";
let Even = "";

for (let i = 0; i < firstArray.Length; i++)
{
    if (i % 2 == 0)
    {
        Odd += firstArray[i];
        Odd += secondArray[i];
    }
    
}
// Odd += firstArray[firstArray.Length - 1];
for (let i = 0; i < secondArray.Length; i++)
{ 
    if (i % 2 != 0)
    {
        Even += firstArray[i];
        Even += secondArray[i];
    }
}
Even += secondArray[secondArray.Length - 1];
var fullEncode =  Even + Odd;
console.log("Code: " + fullEncode);
return fullEncode;
}



function DeCode(text)
{
let firstArray = text.substring(0, text.Length / 2);
let secondArray = text.substring(text.Length / 2);


let Odd = "";
let Even = "";

for (let i = 0; i < firstArray.Length-1; i++)
{
    if (i % 2 == 0)
    {
        Odd += secondArray[i];
        Odd += firstArray[i];
    }
}
Odd += firstArray[firstArray.Length - 1];
for (let i = 0; i < secondArray.Length -1; i++)
{
    if (i % 2 != 0)
    {
        Even += secondArray[i];
        Even += firstArray[i];
    }

}
Even += secondArray[secondArray.Length - 1];
let fullDecode = Odd + Even;

console.log("Decode: " + fullDecode);
return  fullDecode;
}