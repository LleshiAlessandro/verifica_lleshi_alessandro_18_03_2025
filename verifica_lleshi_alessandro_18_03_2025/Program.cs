using System.Net.Http.Headers;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

int[,] riempi_temperatura(int[,] m) //es A
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        Random rnd = new Random();
        for (int j = 0; j < m.GetLength(1); j++)
        {
            if (i == 0)
            {
                m[0, j] = rnd.Next(-10, 36);
            }
        }
    }
    return m;
}

float media_matrice(int[,] m2, int s, float media)//es B
{
    int k = -1;
    for (int i = 0; i < m2.GetLength(0); i++)
    {
        for (int j = 0; j < m2.GetLength(1); j++)
        {
            if (k < j)
            {
                s += m2[i, 0];
                media = s / (j+1);
            }
        }
    }
    return media;
}
int temp_massima(int[,] m2, int max)
{
    for (int i = 0; i < m2.GetLength(0); i++)
    {
        for (int j = 0; j < m2.GetLength(1); j++)
        {
            if (max < m2[i, j])
            {
                max = m2[i, j];
            }
        }
    }
    return max;
}


bool caratteri_diversi(string caratteri)//es D
{

    for (int i = 0; i < caratteri.Length; i++)
    {
        for (int j = 0; j < caratteri.Length; j++)
        {
            if (i != j)
            {
                if (caratteri[i] == caratteri[j])
                {
                    return false;
                }
            }


        }
    }
    return true;
}
int[,] m = new int[2, 12];
Console.WriteLine(riempi_temperatura(m));
int[,] m2 = { {-5, 2, 10,8, 21,24,27,15, 10, -8,2, 3 }, {-5,-1 ,2,4,7,10,12,13,12,10,10,9}};
int s = 0, max = -100000;
float media = 0;
string caratteri = "123456789";
string parola = "ilmatnohrbc";
char[] alfabeto = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
//es A
for (int i = 0; i < m.GetLength(0); i++)
{
    for (int j = 0; j < m.GetLength(1); j++)
    {

        Console.Write("[" + m[i, j] + "]");
    }
    Console.WriteLine();
}
//es B
Console.WriteLine(media_matrice(m2, s, media));
Console.WriteLine(temp_massima(m2, max));