
namespace AttendanceControlAdminClient.Models
{
    /// <summary>
    ///     Objeto que contiene los datos retornados por el servidor cuando
    ///     el administrador se conecta al sistema
    /// </summary>
    public class SignInResponse
    {
        public  string Token { get; set; }
        public  string Role { get; set; }      
    }
}
