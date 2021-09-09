using JAP_Task_Backend.DTO;
using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Interfaces
{
    public interface IVideoService
    {
        List<VideoDto> GetTopTenVideos(VideoType videoType);
        List<VideoDto> GetAllVideos(VideoType videoType);
    }
}
