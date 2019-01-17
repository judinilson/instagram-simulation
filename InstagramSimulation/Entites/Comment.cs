using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramSimulation.Entites
{
    class Comment
    {
        public  string text { get; set; }

        public Comment ()
        {

        }

        public Comment(string text)
        {
            this.text = text;
        }
    }
}
