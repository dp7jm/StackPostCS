using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPost
{
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
