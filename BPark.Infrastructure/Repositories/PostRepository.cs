using BPark.infrastructure.Entities;
using BPark.infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPark.infrastructure.Interface;

namespace BPark.infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BparkContext _context;

        public PostRepository(BparkContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = await _context.Publicacion.ToListAsync();
            return posts;
        }
    }
}
