using System;


namespace pluem
{
    class task2
    {        
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int genderSinger;
            int test1;
            int test2;
            int Ans;

            for(int i=0;i<N;i++)
            {
                genderSinger = int.Parse(Console.ReadLine());
                test1 = int.Parse(Console.ReadLine());
                test2 = int.Parse(Console.ReadLine());
                Ans = Score(test1,test2,genderSinger);
                if(Ans != 0)
                {
                    Console.WriteLine("{0} {1}",i+1,Ans);
                }

            }
        }

        static int genderCheck(int gender)
        {
            if(gender == 1)
            {
                return 1;
            }
            else return 2;
            
        }
        static int Score(int test1,int test2,int gender)
        {
            if(test1 >= 8 && test2 < 8)
            {
                return 1;
            }
            else if(test2 >= 8 && test1 < 8)
            {
                return 2;
            }
            else if(test2 >= 8 && test1 >= 8)
            {
                return genderCheck(gender);
            }
            else return 0;
        }
        
    }
}