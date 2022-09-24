// Найти третье число

int ReadData(string line)
{
Console.WriteLine(line);
int number = int.Parse(Console.ReadLine() ?? "");
return number;
}

char ThirdNumChar(string inputNumber)
{
char[] simbols = inputNumber.ToCharArray();
return simbols[2];
}

int ThirdNumInt(int number)
{
int lenNum = (int)Math.Log10(number);
int outNumber = (int)(number/Math.Pow(10,lenNum-2))%10;
return outNumber;
}

void PrintData(string prefix, string value)
{
Console.WriteLine(prefix + value);
}


int number = ReadData("Введите число: ");
if (number < 100)
{
PrintData("Такой цифры нет", "");
}
else
{
char thirdSimbol = ThirdNumChar(number.ToString());
PrintData("Введенное вами число: ", thirdSimbol.ToString());

int thirdSimbolInt = ThirdNumInt(number);
PrintData("Введенное вами число: ", thirdSimbolInt.ToString());
}

