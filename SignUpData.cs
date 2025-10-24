using System;

public class SignUpData
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public SignUpData(string fullName, string email, string password)
    {
        FullName = fullName;
        Email = email;
        Password = password;
    }
}