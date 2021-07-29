using System;
using Microsoft.AspNetCore.Mvc;

namespace  MyBlog.Models{
public class Post 
{
     public int PostId { get; set; }
     public string UserName { get; set; }
        public string Title  { get; set; }
        
        public string Content  { get; set; }
        [BindProperty]
        public DateTime  TimeStamp  { get; set; }



}
}