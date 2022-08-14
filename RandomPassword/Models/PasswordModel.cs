#pragma warning disable CS8618

namespace RandomPassword.Models;

public class Password
{
    public string Passcode { get; set; }
    public string GeneratePass()
    {
        string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random rand = new Random();
        char[] chars = new char[14];
        for (int i = 0; i < chars.Length; i++) 
        {
            chars[i] = Alphabet[rand.Next(Alphabet.Length)];
        }
        Passcode = new string(chars);
        return Passcode;
    }
}