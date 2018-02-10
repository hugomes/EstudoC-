using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0525Evento.Library
{
    public class VideoEncode
    {
        //public delegate void VideoEncodedHandler(Video video);
        //public event VideoEncodedHandler Encoded;
        public event EventHandler<VideoEventArgs> EncodedDelegate;

        public void Encode(Video video) {
            EncodedDelegate(null, new VideoEventArgs() { Video = video});
        }
    }

    public class VideoEventArgs : EventArgs{
        public Video Video { get; set; }
    }
}
