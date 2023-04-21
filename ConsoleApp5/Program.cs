using System.Reflection.Metadata.Ecma335;

string  latin = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
foreach (char c in latin)
{
    //pomiń wszystkie znaki poza literami z alfabetu łacińskiego
    if (c >= 65 && c <= 90)
    {
        //wyciągamy kod ascii danej liery
        //w języku c# rzutowanie jawne z char na int powoduje pobranie wartości ascii
        int asciiCode = (int)c;
        //sprawdzamy czy nie przekroczxyliśmy ostatniego znaku (z, 90)
        if (c == 65)
            asciiCode += 3;
        if (c == 69)
            asciiCode += 3;
        if (c == 73)
            asciiCode += 3;
        if (c == 79)
            asciiCode += 3;
        if (c == 89)
            asciiCode -= 23;
        if (c == 79)
            asciiCode += 3;
        if (c == 66)
            asciiCode += 25;
        if (c == 85)
            asciiCode += 3;
        if (c == 67)
            asciiCode -= 2;
        if (c == 68)
            asciiCode -= 2;
        if (c == 70)
            asciiCode -= 2;
        if (c == 71)
            asciiCode -= 2;
        if (c == 72)
            asciiCode -= 2;
        if (c == 74)
            asciiCode -= 2;
        if (c == 75)
            asciiCode -= 2;
        if (c == 76)
            asciiCode -= 2;
        if (c == 77)
            asciiCode -= 2;
        if (c == 78)
            asciiCode -= 2;
        if (c == 80)
            asciiCode -= 2;
        if (c == 81)
            asciiCode -= 2;
        if (c == 82)
            asciiCode -= 2;
        if (c == 83)
            asciiCode -= 2;
        if (c == 84)
            asciiCode -= 2;
        if (c ==86)
            asciiCode -= 2;
        if (c == 87)
            asciiCode -= 2;
        if (c == 88)
            asciiCode -= 2;
        if (c == 90)
            asciiCode += 24;
        char encryptedChar = (char)asciiCode;
        encryptedChar += encryptedChar;

    }
}

//zamieniamy na wielkie litery


string toAsciiCaesar(String latin)
{
    string encryptedText = "";
    foreach (char c in latin)
    {
        //pomiń wszystkie znaki poza literami z alfabetu łacińskiego
        if (c >= 65 && c <= 90)
        {
            //wyciągamy kod ascii danej liery
            //w języku c# rzutowanie jawne z char na int powoduje pobranie wartości ascii
            int asciiCode = (int)c;
            //sprawdzamy czy nie przekroczxyliśmy ostatniego znaku (z, 90)
            if (c == 65)
                asciiCode += 3;
            if (c == 69)
                asciiCode += 3;
            if (c == 73)
                asciiCode += 3;
            if (c == 79)
                asciiCode += 3;
            if (c == 89)
                asciiCode -= 23;
            if (c == 79)
                asciiCode += 3;
            if (c == 66)
                asciiCode += 24;
            if (c == 85)
                asciiCode += 3;
            if (c == 67)
                asciiCode -= 2;
            if (c == 68)
                asciiCode -= 2;
            if (c == 70)
                asciiCode -= 2;
            if (c == 71)
                asciiCode -= 2;
            if (c == 72)
                asciiCode -= 2;
            if (c == 74)
                asciiCode -= 2;
            if (c == 75)
                asciiCode -= 2;
            if (c == 76)
                asciiCode -= 2;
            if (c == 77)
                asciiCode -= 2;
            if (c == 78)
                asciiCode -= 2;
            if (c == 80)
                asciiCode -= 2;
            if (c == 81)
                asciiCode -= 2;
            if (c == 82)
                asciiCode -= 2;
            if (c == 83)
                asciiCode -= 2;
            if (c == 84)
                asciiCode -= 2;
            if (c == 86)
                asciiCode -= 2;
            if (c == 87)
                asciiCode -= 2;
            if (c == 88)
                asciiCode -= 2;
            if (c == 90)
                asciiCode -= 2;
            char encryptedChar = (char)asciiCode;
            encryptedText += encryptedChar;


        }
    }
    return encryptedText;
}
Console.WriteLine("Zaszyfrowany tekst: " + toAsciiCaesar(latin)) ;
string wic = Console.ReadLine();
Console.WriteLine("tekst od wica : " + toAsciiCaesar(wic));
