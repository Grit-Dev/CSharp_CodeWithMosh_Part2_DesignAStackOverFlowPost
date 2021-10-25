using System;

namespace ConsoleApp4
{
    public class Post
    {
        public string _Title { get; set; }
        public string _Description { get; set; }
        public  DateTime _DateTime { get; set; } = DateTime.Now;
        private int _UpVote { get; set; }
        private int _DownVote { get; set; }
        public int _TotalVote => _UpVote - _DownVote; //I only have this in because of the exercise challenge
        //I could of got rid of the private downvote as well. But I wanted to challenge myself 


        public void SetUpVote(int pVote)
        {

          
            _UpVote = pVote;
            
        }

        public int GetUpVote()
        {
            return _UpVote;
        }

        public void SetDownVote(int pDownVote)
        {


            _DownVote = pDownVote;

        }

        public int GetDownVote()
        {
            
            return _DownVote;
        }

        public void UpVote(Post pPost)
        {

            const int UPVOTEVALUE = 1;
            int holder = 0;


            holder = pPost.GetUpVote();

            holder = holder + UPVOTEVALUE;


            pPost.SetUpVote(holder);


        }

        public void DownVote(Post pPost)
        {

            const int UPVOTEVALUE = 1;
            int holder = 0;

            holder = pPost.GetDownVote();

            holder = holder + UPVOTEVALUE;

            pPost.SetDownVote(holder);


        }

        public Post EnterTitle(Post pPost)
        {
            string userInput;
            bool isTrue = true;

            while (isTrue)
            {

                Console.WriteLine("Please enter in the Title of the post");
                userInput = Console.ReadLine();
                pPost._Title = userInput;

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("You have not entered a title! \n");
                }
                else
                {

                    isTrue = false;
                }
            }



            return pPost;
        }

        public Post EnterDescription(Post pPost)
        {
            string userInput;
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("Please enter in the Description of the post");
                userInput = Console.ReadLine();
                pPost._Description = userInput;

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("You have not entered in a decription ! \n");
                }
                else
                {

                    isTrue = false;
                }
            }

            return pPost;

        }

    }
}
