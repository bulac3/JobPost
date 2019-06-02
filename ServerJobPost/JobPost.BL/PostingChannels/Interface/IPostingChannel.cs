using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.BL.PostingChannels.Interface
{
    public interface IPostingChannel
    {
        Task Post();
    }
}
