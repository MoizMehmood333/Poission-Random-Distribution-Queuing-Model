using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models.Repository
{
    public class WorkingOfSimulation
    {
        private double m_noOfTimeBetweenArrival;
        private double m_commutativeProb;
        private double m_commutativeProbLookup;
        private double m_Arrival;
        private double m_interArrival;
        private  double m_serviceTime;
        public double NoOfTimeBetweenArrival { get { return m_noOfTimeBetweenArrival; } set { m_noOfTimeBetweenArrival= value; } }
        public double CommutativeProbablity { get { return m_commutativeProb; } set { m_commutativeProb= value; } }
        public double CommutativeProbablityLookup{ get { return m_commutativeProbLookup; } set { m_commutativeProbLookup = value; } }
        public double Arrival{ get { return m_Arrival; } set { m_Arrival= value; } }
        public double InterArrival { get { return m_interArrival; } set { m_interArrival= value; } }
        public double ServiceTime{ get { return m_serviceTime; } set { m_serviceTime= value; } }









    }
}
