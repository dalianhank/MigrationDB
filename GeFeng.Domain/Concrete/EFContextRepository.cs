using System;
using System.Linq;
using GeFeng.Domain.Entities;
using GeFeng.Domain.Abstract;

namespace GeFeng.Domain.Concrete
{
    public class EFContextRepository: IEFRepository
    {
        private EFDbContext db = new EFDbContext();

        public IQueryable<Blog> Blogs {
            get { return db.Blogs; }
        }

        public IQueryable<Comment> Comments
        {
            get { return db.Comments; }
        }

        public IQueryable<Contact> Contacts
        {
            get { return db.Contacts; }
        }

        public void SaveBlog(Blog blog) 
        {
            if (blog.BlogId == 0)
            {
                db.Blogs.Add(blog);
            }
            else
            {
                Blog dbEntry = db.Blogs.Find(blog.BlogId);
                if (dbEntry != null) 
                {
                    dbEntry.BlogTitle = blog.BlogTitle;
                    dbEntry.BlogContent = blog.BlogContent;
                    dbEntry.BlogCategory = blog.BlogCategory;
                    dbEntry.BlogCreateDate = DateTime.Now;
                    dbEntry.BlogImageData = blog.BlogImageData;
                    dbEntry.BlogImageMimeType = blog.BlogImageMimeType;
                }
            }
            db.SaveChanges();
          }

        public Blog DeleteBlog(int blogId) 
        {
            Blog dbEntry = db.Blogs.Find(blogId);
            if (dbEntry != null)
            {
                db.Blogs.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }

        /*** SaveComment***********/
        public void SaveComment(Comment comment)
        {
            if (comment.CommentId == 0)
            {
                db.Comments.Add(comment);
            }
            else
            {
                Comment dbEntry = db.Comments.Find(comment.CommentId);
                if (dbEntry != null)
                {
                    dbEntry.CommentCotent = comment.CommentCotent;
                    dbEntry.CommentUser= comment.CommentUser;
                    dbEntry.CommentCreateDate = comment.CommentCreateDate;
                    
                }
            }
            db.SaveChanges();
        }

        public Comment DeleteComment(int commentId)
        {
            Comment dbEntry = db.Comments.Find(commentId);
            if (dbEntry != null)
            {
                db.Comments.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveContact(Contact contact)
        {
            if (contact.ContactId == 0)
            {
                db.Contacts.Add(contact);
            }
            else
            {
                Contact dbEntry = db.Contacts.Find(contact.ContactId);
                if (dbEntry != null)
                {
                    dbEntry.ContactEmail = contact.ContactEmail;
                    dbEntry.ContactMessage = contact.ContactMessage;
                    dbEntry.ContactCreateDate = DateTime.Now;
                                    }
            }
            db.SaveChanges();
        }

        public Contact DeleteContact(int contactId)
        {
            Contact dbEntry = db.Contacts.Find(contactId);
            if (dbEntry != null)
            {
                db.Contacts.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        } 
    }
}
