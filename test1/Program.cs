using System;
using System.Text;

public class PasswordGenerator
{
    // Função para gerar a senha
    public static string GeneratePassword(int length)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        StringBuilder password = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            password.Append(validChars[random.Next(validChars.Length)]);
        }

        return password.ToString();
    }

    // Main method apenas para teste    // Main method apenas para teste
    static void Main()
    {
        Console.WriteLine("Sua senha gerada é: " + GeneratePassword(10)); // Gera uma senha de 10 caracteres
    }
}
