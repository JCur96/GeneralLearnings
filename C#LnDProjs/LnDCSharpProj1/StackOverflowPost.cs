using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    class StackOverflowPost
    {
        private int _numUpvotes = 0;
        private int _numDownvotes = 0;
        private string _title;
        private string _description;
        private DateTime _creationTime { get; set; }
        private int _currentVotes = 0;

        public void AddTitle(string input)
        {
            _title = input;
        }

        public void AddDescription(string input)
        {
            _description = input;
        }

        public void CreatePost()
        {
            string inputString;
            _creationTime = DateTime.Now;

            Console.WriteLine("Please enter a title and press enter to confirm: ");
            inputString = Console.ReadLine();
            AddTitle(inputString);
            
            Console.WriteLine("Please enter a description and press enter to confirm: ");
            inputString = Console.ReadLine();
            AddDescription(inputString);
        }

        public void Upvote()
        {
            _numUpvotes++;
            CalculateVotes();
        }

        public void Downvote()
        {
            _numDownvotes++;
            CalculateVotes();
        }

        public void DisplayPost()
        {
            Console.WriteLine(_title);
            Console.WriteLine(_description);
            Console.WriteLine(_creationTime);
            CalculateVotes();
            Console.WriteLine(_currentVotes);
        }

        //Private methods
        private void CalculateVotes()
        {
            _currentVotes = _numUpvotes - _numDownvotes;
        }
    }
}
