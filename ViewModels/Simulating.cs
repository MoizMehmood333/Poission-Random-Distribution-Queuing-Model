using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Markup;
using WpfApp1.Models.Cache;
using WpfApp1.Models.Repository;

namespace WpfApp1.ViewModels
{
    public class Simulating
    {
        public static Cache m_cacheInstance = Cache.GetCache;
        public static void simultate(double lambda, double meu)
        {
            if (m_cacheInstance.LstWorkingSimulation.Count != 0)
            {
                m_cacheInstance.LstResult = new List<Result>();
                double totalNumOfCustomers = m_cacheInstance.LstWorkingSimulation.Count;
                double totalServiceTime = 0;
                double totalArrivalTime = 0;
                double totalInterArrivalTime = 0;
                foreach (var item in m_cacheInstance.LstWorkingSimulation)
                {
                    totalInterArrivalTime += item.InterArrival;
                    totalServiceTime += item.ServiceTime;
                    totalArrivalTime += item.Arrival;

                }
                double averageTimeBetweenArrival = totalInterArrivalTime / totalNumOfCustomers;
                double averageNumberOfCustomersInSystem = Math.Abs(Math.Round(lambda / (meu - lambda)));
                double averageNumberOfCustomersInQueue = Math.Abs(Math.Round(Math.Pow(lambda, 2) / (meu * (meu - lambda))));
                double averageWaitingTimeInQueue = Math.Abs(lambda / (meu * (meu - lambda)));
                double averageTimeInSystem = Math.Abs(1 / (meu - lambda));
                double probabilityNoOfCustomerInTheSystem = Math.Abs((1 - (lambda / meu)));
                double averageNoOfCustomerInQueueNotEmpty = Math.Abs(meu / (meu - lambda)) ;
                double utilizationFactor = Math.Abs(1-(lambda/ meu));



                m_cacheInstance.LstResult.Add(new Result { Description = "Total Number Of Cutomers", Results = totalNumOfCustomers });
                m_cacheInstance.LstResult.Add(new Result { Description = "Total Service Time", Results = totalServiceTime });
                m_cacheInstance.LstResult.Add(new Result { Description = "Total InterArrival Time", Results = totalInterArrivalTime });
                m_cacheInstance.LstResult.Add(new Result { Description = "Average Time Between Arrival", Results = averageTimeBetweenArrival });
                m_cacheInstance.LstResult.Add(new Result { Description = "Average Number Of Customers In the System", Results = averageNumberOfCustomersInSystem });
                m_cacheInstance.LstResult.Add(new Result { Description = "Average Number Of Customers in Queue", Results = averageNumberOfCustomersInQueue });
                m_cacheInstance.LstResult.Add(new Result { Description = "Average Waiting Time In Queue", Results = averageWaitingTimeInQueue });
                m_cacheInstance.LstResult.Add(new Result { Description = "Average Time In System", Results = averageTimeInSystem });
                m_cacheInstance.LstResult.Add(new Result { Description = "Probability of No Of Customer In The System", Results = probabilityNoOfCustomerInTheSystem });
                m_cacheInstance.LstResult.Add(new Result { Description = "Average No Of Customers In Queue When It Is Not Empty", Results = averageNoOfCustomerInQueueNotEmpty });
                m_cacheInstance.LstResult.Add(new Result { Description = "Utilization Factor", Results = utilizationFactor });





            }
        }

    }
}

