using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models.Repository
{
    public class Result
    {
        public string m_description;
        public double m_results;  
        public string  Description { get { return m_description; } set { m_description= value; } }
        public double Results { get { return m_results; } set { m_results= value; } }
    }
}
