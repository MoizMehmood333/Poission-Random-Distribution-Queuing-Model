using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Markup;
using WpfApp1.Models.Cache;
using WpfApp1.Models.Repository;

namespace WpfApp1.ViewModels
{
    public class Working
    {
        public static Cache m_cacheInstance = Cache.GetCache;
        public static void SimulationWorkingCode(double nArrivalRate, double nServiceRate)
        {
            double commutativeProbablity = 0;
            double commutativeProbablityLookUp = 0;
            double customerNo = 0;
            double factorial;
            double serviceTime;
            int arrivalTime = 0;
            double interArrivalTime = 0;
            Random random = new Random();

            bool IstInitialInterarrivalTimeSet = false;

            while (commutativeProbablity < 0.99999)
            {
                
                factorial = Factorial(customerNo);
                commutativeProbablity += ((Math.Pow(nArrivalRate, customerNo)) * (Math.Pow(Math.E, -nArrivalRate))) / (factorial);
                serviceTime = Math.Round(Math.Abs((-nServiceRate) * Math.Log10(nServiceRate) * random.Next(20))) ;
                arrivalTime += random.Next(4);
                if (IstInitialInterarrivalTimeSet)
                {
                    interArrivalTime = arrivalTime;
                    IstInitialInterarrivalTimeSet = true;
                }
                else { 
                    interArrivalTime = arrivalTime - interArrivalTime;
                }
                m_cacheInstance.LstWorkingSimulation.Add(new WorkingOfSimulation
                {
                    NoOfTimeBetweenArrival = customerNo,
                    CommutativeProbablity =  Math.Round(commutativeProbablity, 5),
                    CommutativeProbablityLookup =  Math.Round(commutativeProbablityLookUp,5) ,
                    Arrival = arrivalTime,
                    InterArrival = interArrivalTime,
                    ServiceTime = serviceTime

                });
                commutativeProbablityLookUp = commutativeProbablity;
                interArrivalTime = arrivalTime;
                customerNo++;
            }


        }


        public static double Factorial(double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
