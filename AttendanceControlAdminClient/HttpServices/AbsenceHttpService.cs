using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using AttendanceControlAdminClient.Session;
using Flurl;
using Flurl.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    /// <summary>
    ///     Cliente http relacionado con las ausencias
    /// </summary>
    class AbsenceHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;

        /// <summary>
        ///     Obtiene la lista de ausencias de un alumno
        /// </summary>
        /// <param name="studentId">
        ///     El id del alumno
        /// </param>
        /// <returns>
        ///     La lista de alumnos
        /// </returns>
        public static async Task<List<Absence>> GetByStudent(int studentId)
        {

            try
            {
                var result = await _baseUrl
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/absences/students/" + studentId)
                    .GetJsonAsync<List<Absence>>();

                return result;
            }
            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

        /// <summary>
        ///     Envia la justificacion de una ausencia
        /// </summary>
        /// <param name="absenceId">
        ///     El id de la ausencia
        /// </param>
        /// <param name="isExcused">
        ///     booleano para justificar o retirar la justificacion
        /// </param>
        /// <returns></returns>
        public static async Task<bool> SetExcused(int absenceId, bool isExcused)
        {

            try
            {
                var result = await _baseUrl
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/absences/" + absenceId)
                    .PutJsonAsync(isExcused)
                    .ReceiveJson<bool>();

                return result;
            }
            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

    }
}
