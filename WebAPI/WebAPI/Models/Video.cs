
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Video
    {
        public int VideoId { get; set; }
        public string VideoName { get; set; }
        public string Description { get; set; }
        public string DateOfRelease { get; set; }
        public string PhotoFileName { get; set; }

    }
}
