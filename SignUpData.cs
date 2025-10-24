using System;

public class SignUpData
{
    public string FullName { get; set; }

    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public SignUpData(string fullName, string username, string email, string password)
    {
        FullName = fullName;
        Username = username;
        Email = email;
        Password = password;
    }
}