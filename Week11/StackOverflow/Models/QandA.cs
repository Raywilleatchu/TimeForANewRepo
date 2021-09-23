using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.Models
{
    public class QandA
    {
        public Questions question { get; set; }
        public Answers answer { get; set; }
        public List<Answers> answers { get; set; }
        public List<Questions> questions { get; set; }

        public QandA()
        {
            //Default
        }

        public QandA(Questions q, List<Answers> aa)
        {
            this.question = q;
            this.answers = aa;
        }

        public QandA(List<Questions> qq)
        {
            this.questions = qq;
        }
    }
}
