int dec, rem;
char [] hexchars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
String hex = "";
Console.Write("Entrez un entier ");
dec = int.Parse(Console.ReadLine());



while (dec > 0)
{
    rem = dec % 16;
    hex = hexchars[rem] + hex;
    dec = dec / 16;
}

Console.Write("La conversion hexadecimale est "+hex);