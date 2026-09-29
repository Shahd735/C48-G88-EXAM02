using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_OOP
{
    public class TFQuestion : Question
    {
        public TFQuestion(string body, int mark) : base("True or False Question", body, mark)
        {
            AnswerList = new Answer[2]
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }
    }
}
