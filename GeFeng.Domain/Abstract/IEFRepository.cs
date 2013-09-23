using System;
using System.Linq;
using GeFeng.Domain.Entities;

namespace GeFeng.Domain.Abstract
{
    public interface IEFRepository
    {
        IQueryable<Blog> Blogs { get; }
        IQueryable<Contact> Contacts { get; }
        IQueryable<Comment> Comments { get; }

        void SaveBlog(Blog blog);
        Blog DeleteBlog(int BlogId);

        void SaveComment(Comment comment);
        Comment DeleteComment(int CommentId);

        void SaveContact(Contact contact);
        Contact DeleteContact(int ContactId);
    }
}
