using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExceptions
{
    public class YouTubeException:Exception
    {
        public YouTubeException(string message, Exception innerException)
            :base(message, innerException)
        {
                
        }
    }
    public class YouTubeAPI
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //access youtube web service
                //read the data
                //create a list of video objects
                throw new Exception("Oops");
                return new List<Video>();
            }
            catch (Exception ex )
            {
                //log
                throw new YouTubeException("Could not fetch the videos from youtube.", ex);
            }
        }            
    }
    public class Video
    {
    }
}
