using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackOverflow.Models;

namespace StackOverflow.Controllers
{
    public class QandAController : Controller
    {
        //TODO: DATETIME FIX

        //Input Question Details
        public IActionResult AskQuestion(Questions quest)
        {
            if (DAL.CurrentUser == null)
            {
                return Redirect("/");
            }
            else
            { 
                DateTime date = DateTime.Now;
                string formatDate = date.ToString("yyyy-MM-dd hh:mm:ss");
                //quest.posted = formatDate;
                quest.username = DAL.CurrentUser;
                return View(quest);
            }
        }

        //Submit Question Details
        public IActionResult SubmitQuestion(Questions quest)
        {
            DAL.AddQuestion(quest);
            return Redirect("../Home/Index");
        }

        //View Full Question + all answers
        public IActionResult QuestionPage(int qID)
        {
            QandA qa = new QandA();
            qa.question = DAL.GetQuestion(qID);
            qa.answers = DAL.GetAnswers(qID);
            return View(qa);
        }

        //Edit Question
        public IActionResult EditQuestion(int qID)
        {
            Questions q = DAL.GetQuestion(qID);
            return View(q);
        }

        [HttpPost]
        public IActionResult SubmitEditQuestion(Questions q)
        {
            DAL.EditQuestion(q);
            return Redirect($"../QandA/QuestionPage?qID={q.id}");
        }

        //Input Answer Details (Answer's "QuestionID" should be equal to the Question's "ID" on whatever page its on)
        public IActionResult AddAnswer(int qID)
        {
            DateTime date = DateTime.Now;
            string formatDate = date.ToString("yyyy-MM-dd hh:mm:ss");
            //quest.posted = formatDate;
            Answers a = new Answers();
            a.questionID = qID;
            a.username = DAL.CurrentUser;
            return View(a);
        }

        //Submit Answer Details
        public IActionResult SubmitAnswer(Answers a)
        {
            DAL.AddAnswer(a);
            return Redirect($"../QandA/QuestionPage?qID={a.questionID}");
        }

        //Edit Answer
        public IActionResult EditAnswer(int ID)
        {
            Answers a = DAL.GetAnswer(ID);
            return View(a);
        }

        [HttpPost]
        public IActionResult SubmitEditAnswer(Answers a)
        {
            DAL.EditAnswer(a);
            return Redirect($"../QandA/QuestionPage?qID={a.questionID}");
        }

    }
}
