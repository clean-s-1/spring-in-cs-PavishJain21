using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class EmailAlert :IAlerter
    {
        public bool emailSent { get; set; } 

        public void Alert(bool message)
        {
            emailSent = message;
        }
    }
}
