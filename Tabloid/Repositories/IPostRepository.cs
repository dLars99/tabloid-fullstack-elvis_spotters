﻿using System.Collections.Generic;
using Tabloid.Models;

namespace Tabloid.Repositories
{
    public interface IPostRepository
    {
        List<Post> GetAllPosts();
        List<Post> GetAllPublishedPosts();
        List<Post> GetSubscribedPosts(int userProfileId);
        Post GetPostById(int id);
        List<Post> GetPostsByUserId(int userId);
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
    }
}