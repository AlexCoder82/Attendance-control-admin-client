using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    public class StudentHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;

   
        public static async Task<List<Student>> GetByPageAndLasttName(string lastname, int page)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/students/"+page)
                   .SetQueryParam("lastname", lastname)
                   .GetJsonAsync<List<Student>>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                try
                {
                    APIError error = await flurlHttpException.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }

        public static async Task<Student> Save(Student student)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/students")
                   .PostJsonAsync(student)
                   .ReceiveJson<Student>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                try
                {
                    APIError error = await flurlHttpException.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }

        public static async Task<Student> Update(Student student)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/students")
                   .PutJsonAsync(student)
                   .ReceiveJson<Student>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                try
                {
                    APIError error = await flurlHttpException.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }

        public static async Task<Student> UpdateCourse(int studentId, int courseId)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)
                    .AppendPathSegment("/students/" + studentId + "/courses/" + courseId)
                   .PutAsync(null)
                   .ReceiveJson<Student>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                try
                {
                    APIError error = await flurlHttpException.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }

        public static async Task<bool> RemoveCourse(int studentId)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)
                   .AppendPathSegment("/students/" + studentId + "/courses")
                   .PutAsync(null)
                   .ReceiveJson<bool>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                try
                {
                    APIError error = await flurlHttpException.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }

        public static async Task<Student> UpdateSubjects(int studentId, int[] subjectIds)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)
                    .AppendPathSegment("/students/" + studentId + "/subjects")
                    .SetQueryParam("subjectIds", subjectIds)
                    .PutAsync(null)
                    .ReceiveJson<Student>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                try
                {
                    APIError error = await flurlHttpException.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }
    }
}
