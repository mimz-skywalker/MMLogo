using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorMateLogo
{
    class Logo
    {
        public int N { protected set; get; }
        public char[,] MMLogo { protected set; get; }
        
        public Logo(int n)
        {
     
            this.N = n;

            //array contains only one M
            MMLogo = new char[N + 1, N * 5];
        }


        //Draw function to fill the array
        public void Draw()
        {
            int temp = N;
            bool switcher = true;

            //populating the array with '-'
            for (int i=0; i <N+1;i++)
            {
                for(int j=0; j<N*5; j++)
                {
                    MMLogo[i, j] = '-';
                }
            }
 
           //switching the '-' to '*'
           for(int i = 0; i<=N*4; i++)
           {
                for(int k=i; k<N+i; k++)
                { 
                    MMLogo[temp, k] = '*';
                }

                if(temp==0)
                {
                    switcher = false;
                }

                if(temp==N)
                {
                    switcher = true;

                }

                if (switcher)
                {
                    --temp;
                }
                else
                {
                    ++temp;
                }

            }
      
                    
        }

        //Print function to print the array
        public void Print()
        {
            for(int i=0; i<N+1; i++)
            {
                //to print the same array twice
                for(int count = 0; count <2; count++)
                {
                    for(int j=0; j<N*5; j++)
                    {
                        Console.Write(MMLogo[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }


    }
}
