using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections;

namespace StackOverflow.Models
{
    public class DAL
    {
        public static string CurrentUser;
        public static MySqlConnection DB;

        //Gets Question
        public static Questions GetQuestion(int id)
        {
            return DB.Get<Questions>(id);
        }

        //Gets Answer (May need to update to pinpoint which answer to what question)
        public static Answers GetAnswer(int id)
        {
            return DB.Get<Answers>(id);
        }

        //Gets All Questions
        public static List<Questions> GetQuestions()
        {
            return DB.GetAll<Questions>().ToList();
        }

        //Gets All Answers
        public static List<Answers> GetAnswers(int qID)
        {
            var obj = new { qID = qID };
            string str = "select * from answers where QuestionID = @qID";
            return DB.Query<Answers>(str, obj).ToList();
        }

        //Add Question
        public static void AddQuestion(Questions q)
        {
            string sql = $"call GetDateTime(@posted)";
            //var keyvalues = new { posted = q.posted };
            q.username = CurrentUser;
            q.status = 1;
            //IEnumerable a = DB.Query<Questions>(sql, keyvalues);
            //q.posted = a;
            DB.Insert(q);
        }
        
        //Edit Question
        public static void EditQuestion(Questions q)
        {
            DB.Update(q);
        }

        //Add Answer
        public static void AddAnswer(Answers a)
        {
            a.username = CurrentUser;
            DB.Insert(a);
        }

        //Edit Answer
        public static void EditAnswer(Answers a)
        {
            //Problem: Object for Answers showing an id of 0. Should match the id of edited answer(id=1)
            a.username = CurrentUser;
            DB.Update(a);
        }

        //Upvotes
        public static void Upvote()
        {
            // Code Later
        }

        public static List<Questions> SearchQuestion(string str)
        {
            var keyvaluepair = new { search = $"%{str}%" };
            string sql = "select * from questions where title like @search or username like @search";
            return DB.Query<Questions>(sql, keyvaluepair).ToList();
        }

    }
}
