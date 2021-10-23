using Blog5._0.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog5._0.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID =1,
                    UserName = "ali"
                },
                new UserComment
                {
                    ID=2,
                    UserName="yunus"
                },
                new UserComment
                {
                    ID=3,
                    UserName="bilmem kim"
                }
            };
            return View(commentValues);
        }
    }
}
