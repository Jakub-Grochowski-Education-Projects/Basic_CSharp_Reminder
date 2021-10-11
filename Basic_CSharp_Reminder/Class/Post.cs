using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp_Reminder.Class
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public readonly DateTime _createdTime;
        private  int _voteValue;

        public int GetVoteValue
        {
            get { return _voteValue; }
        }

        public Post()
        {
            _createdTime = DateTime.Now;
            _voteValue = 0;
        }
        public Post(string title,string description)
        :this()
        {
            Title = title;
            Description = description;
        }

        public void UpVote()
        {
            _voteValue++;
        }
        public void DownVote()
        {
            _voteValue--;
        }

        public string ToString()
        {
            return Title + "\r\n data utworzenia:" + _createdTime + " \r\n " + Description + " \r\n ocena: " + _voteValue + "\r\n";
        }
    }
}
