using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPost
{
    class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime PostedTime { get; private set; }
        public int Vote { get; private set; }
        public Post (string title)
        {
            this.Title = title;
            this.PostedTime = DateTime.Now;

        }
        public Post (string titel, string description) 
            :this(titel)
        {
            this.Description = description;
        }

        public void UpWote()
        {
            this.Vote += 1;

        }
        public void DownWote()
        {
            this.Vote -= 1;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Post stackPost = new Post("hey");
            stackPost.UpWote();
            stackPost.UpWote();
            Console.WriteLine(stackPost.Vote);
            stackPost.UpWote();
            Console.WriteLine(stackPost.Vote);
            stackPost.UpWote();
            Console.WriteLine(stackPost.Vote);
            stackPost.DownWote();
            Console.WriteLine(stackPost.Vote); 
        }
    }
}
