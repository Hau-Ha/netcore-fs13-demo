namespace NETCoreDemo.DTOs;

public class UserSignInResponseDTO
{
    public string Token { get; set; } = null!;
    public DateTime Expiration { get; set; }
}