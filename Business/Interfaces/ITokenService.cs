using BusinessLayer.DTOs;

namespace BusinessLayer.Interfaces
{
    public interface ITokenService
    {
        string CreateJwtToken(UserDTO userDTO);
    }
}
