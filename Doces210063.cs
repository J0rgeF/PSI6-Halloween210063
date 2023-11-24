using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI6_Halloween210063
{
	public class Sweets210063
    {
        private bool answered;
        private int candyQuantity;
        private string door;

        public bool Opened
        {
            get { return answered; }
        }

        public string Door
        {
            get { return door; }
        }

        public int Quantity
        {
            get { return candyQuantity; }
        }

        public Sweets210063(bool a, int b, string c)
        {
            answered = a;
            candyQuantity = b;
            door = c;
        }

        public string Classification()
        {
            return candyQuantity > 10 ? "Great" : candyQuantity < 10 && candyQuantity > 5 ? "Good" : candyQuantity <= 5 ? "Gross" : null;
        }
    }
}
