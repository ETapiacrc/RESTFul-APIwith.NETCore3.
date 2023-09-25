using BPark.infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPark.infrastructure.Interface
{
    
        public interface IPostRepository
        {
            Task<IEnumerable<Post>> GetPosts();
        }
    
}


