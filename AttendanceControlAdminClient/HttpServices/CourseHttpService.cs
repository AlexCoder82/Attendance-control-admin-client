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
    class CourseHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;

        /// <summary>
        ///     PUT /api/courss
        ///     Envia al servidor un curso modificado 
        /// </summary>
        /// <param name="course"></param>
        /// <returns>
        ///     Retorna el curso modificado 
        /// </returns>
        public static async Task<bool> AssignSubject(int courseId,int subjectId)
        {
            try
            {
                var result = await _baseUrl.AppendPathSegment("/courses/"+courseId+"/subjects/"+subjectId)
                   .PutAsync(null).ReceiveJson<bool>();

               
                return result;
            }
            catch (FlurlHttpException ex)
            {
                try
                {
                    APIError error = await ex.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }

        public static async Task<bool> RemoveAssignedSubject(int courseId, int subjectId)
        {
            try
            {
                var result = await _baseUrl.AppendPathSegment("/courses/" + courseId + "/subjects/" + subjectId)
                   .DeleteAsync().ReceiveJson<bool>();


                return result;
            }
            catch (FlurlHttpException ex)
            {
                try
                {
                    APIError error = await ex.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }

        public static async Task<List<Course>> GetAll()
        {
            try
            {
                var result = await _baseUrl.AppendPathSegment("/courses")
                   .GetJsonAsync<List<Course>>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                try
                {
                    APIError error = await ex.GetResponseJsonAsync<APIError>();

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
