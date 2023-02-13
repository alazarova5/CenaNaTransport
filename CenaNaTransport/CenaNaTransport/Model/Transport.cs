using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenaNaTransport.Model
{
    public class Transport
    {
        private int km;
        private string time;

        public int Km
        {
            get { return this.km; }
            set
            {
                if (km < 0 || km > 5000)
                {
                    Console.WriteLine("error");
                }
                this.km = value;
            }
        }
        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public Transport(int km, string time)
        {
            Km = km;
            Time = time;
        }
        public Transport() : this(0, "") { }
        public void CalculatePrice()
        {
            double taksa = 0;
            double tarifa = 0;
            if (this.Km<20)
            {
                taksa = 0.70;
                if (this.Time=="day")
                {
                    tarifa = 0.79;
                }
                else
                {
                    tarifa = 0.9;
                }
            }
            else if (this.Km<100)
            {
                {
                    tarifa = 0.9;
                }

            }
            else
            {
                tarifa = 0.6;
            }
            return taksa + tarifa * this.Km;
        }
        
        }
	}

