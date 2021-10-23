using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Abstract
{
   public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void categorydelete(category category);
        //void categoryupdate(category category);
        List<Comment> GetList(int id);
       // Category GetByID(int id);
    }
}
