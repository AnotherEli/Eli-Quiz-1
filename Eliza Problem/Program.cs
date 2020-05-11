using System;

namespace Eliza_Problem
{
    class Program
    {
        static string[] continueTalking = { "Please, go on. ", "Tell me more. ", "Continue. ", "Go on... ", "I see... Continue. " };
        static Random rando = new Random();

        static void Main(string[] args)
        {
            string str;
            bool c = true;
            Console.WriteLine("Welcome, please sit down... If you would like to stop, please type 'stop'\n");
            do
            {
                Console.WriteLine(continueTalking[rando.Next(0, continueTalking.Length - 1)]);
                //get input
                str = Console.ReadLine();
                //check to see if 
                if (str.Equals("stop"))
                    c = false;
                //output
                if (c)
                    Console.WriteLine(CreateElizaResponse(str));
            } while (c);
        }

        /* 
         * If the client's statement contains the word "my", 
         * (I am having trouble with my brother), respond with 
         * "Tell me more about your " followed by the noun in 
         * the statements (Tell me more about your brother).
         * 
         * If the client's statement contains the word love or 
         * hate, respond with "You have strong feelings about 
         * that!"
         * 
         * If neither of the above responses is appropriate, 
         * respond with one of the following "Please go on.", 
         * "Tell me more" or "Continue".
         * 
         */
        public static string CreateElizaResponse(string str)
        {
            string strongFeels = "You have strong feelings about that. ";
            string tellMe = "Tell me more about your ";

            bool tell = false;
            bool feel = false;

            str = str.ToLower();

            string[] thinker = str.Split();

            string response = "";


            for (int i = 0; i < thinker.Length; i++)
            {
                //tell me about your...
                if (!feel)
                {
                    if (thinker[i].Equals("love") || thinker[i].Equals("hate"))
                    {
                        feel = true;
                        response += strongFeels;
                    }
                }
                if (thinker[i].Equals("my"))
                {
                    tell = true;
                    response += tellMe + thinker[i + 1] + ". ";
                }
                if (tell)
                    break;
            }

            return response;
        }
    }
}
