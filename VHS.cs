using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBusters
{
    public class VHS : Movie  
    {

        public int CurrentScene { get; set; } = 0;


        
        public VHS(string Title, int RunTime, Genre Category) : base(Title, RunTime, Category)
        {
          
           this.CurrentScene = CurrentScene;
        }

        public void Rewind()
        {
            CurrentScene = 0;
        }

        public override void Play()
        {
            Console.WriteLine(Scenes[CurrentScene]);
            CurrentScene += 1;

        }   
    }
}
