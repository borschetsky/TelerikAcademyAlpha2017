using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Contracts;
using Dealership.Common.Enums;

namespace Dealership.Models
{
    public class Comment : IComment
    {
        //Fields
        private string content;
        private string author;
        //Const
        public Comment(string content)
        {
            this.Content = content;   
        }
        //Prop
        public string Content
        {
            get {return this.content; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (value.Length < 3 || value.Length > 200)
                {
                    throw new ArgumentException("Content must be between 3 and 200 characters long!");
                }
                this.content = value;
            }
        }

        public string Author { get { return this.author; } set { this.author = value; } }


        public override string ToString()
        {
            StringBuilder currComment = new StringBuilder();
            
            currComment.AppendLine("    ----------");
            currComment.AppendLine($"    {this.Content}");
            currComment.AppendLine($"      User: {this.Author}");
            currComment.AppendLine("    ----------");
            return currComment.ToString();

        }
    }
}
