using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBusters
{
    public class DVD : Movie
    {
        
        
        
        
        public DVD(string Title, int RunTime, Genre Category) : base(Title, RunTime, Category)
        {
        
        
        }

       

        public override void Play()
        {
            PrintScenes(Scenes);
            
            Console.WriteLine("What scene would you like to watch");
            string selection = Console.ReadLine();
            int selectionNumber = int.Parse(selection);

            Console.WriteLine(Scenes[selectionNumber -1 ]);
           
           
        }

       
    }
}
