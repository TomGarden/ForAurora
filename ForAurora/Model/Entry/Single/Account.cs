using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry
{
    /// <summary>
    /// 用户账户
    /// </summary>
    public class Account :Entry
    {
        private string username;
        private string pwd;
        private string secretQuestion;
        private string secretAnswer;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Pwd
        {
            get
            {
                return pwd;
            }

            set
            {
                pwd = value;
            }
        }

        public string SecretQuestion
        {
            get
            {
                return secretQuestion;
            }

            set
            {
                secretQuestion = value;
            }
        }

        public string SecretAnswer
        {
            get
            {
                return secretAnswer;
            }

            set
            {
                secretAnswer = value;
            }
        }
    }
}
