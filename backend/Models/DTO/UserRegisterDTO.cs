namespace UdemyCloneBackend.Models
{
    public class UserRegisterDTO
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }  // Será transformado em hash ao salvar
    }
}