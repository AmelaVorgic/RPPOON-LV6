using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6RPPOON
{
    class CareTaker
    {
        List<Memento> State;
        public Memento previous {get; set;}

        public CareTaker() { State = new List<Memento>()}
        
        public void AddState(Memento state)
        {
            State.Add(state);
        }
        
        public void Undo(int i)
        {
            State.RemoveAt(i);
        }
       
        public void Memento getState(int i)
        {
            return.State[i];
        }
       
    }
}
