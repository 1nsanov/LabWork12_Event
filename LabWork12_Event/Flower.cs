using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork12_Event
{
    public class Flower
    {
        public event Action removeLeafEvent = null;
        public event Action removeLastLeafEvent = null;
        public static int LeftCount { get; set; } = 7;

        public void RemoveLeafEvent()
        {
            if (removeLeafEvent != null)
            {
                removeLeafEvent.Invoke();
            }
        }
        public void RemoveLastLeafEvent ()
        {
            if (removeLastLeafEvent != null)
            {
                removeLastLeafEvent.Invoke();
            }
        }

        public void GenerateEvents()
        {
            if (LeftCount > 1)
            {
                LeftCount--;
                RemoveLastLeafEvent();
            }
            else
            {
                RemoveLastLeafEvent();
            }
        }

    }
}
