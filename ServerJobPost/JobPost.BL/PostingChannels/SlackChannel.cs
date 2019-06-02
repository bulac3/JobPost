using JobPost.BL.PostingChannels.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.BL.PostingChannels
{
    public class SlackChannel : IPostingChannel
    {
        public Task Post()
        {



            return Task.CompletedTask;
        }
    }
}
