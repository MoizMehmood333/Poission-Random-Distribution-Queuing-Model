using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WpfApp1.Models.Repository;

namespace WpfApp1.Models.Cache
{

    public class Cache
    {
        //lists 
        private List<Result> m_lstResult;
        private List<WorkingOfSimulation> m_lstWorkingSimulation;

        //cache singleton instance
        private static Cache m_GetCacheInstance;


        //properties to access the private lists.
        private uint m_UserID;

      
        public List<Result> LstResult
        {
            get{
                if (m_lstResult == null) {
                    m_lstResult = new List<Result>();   
                }
                return m_lstResult; }
            set { m_lstResult = value; }
        }
        public List<WorkingOfSimulation> LstWorkingSimulation
        {
            get { if (m_lstWorkingSimulation == null) {
                    m_lstWorkingSimulation = new List<WorkingOfSimulation>();
                }
                return m_lstWorkingSimulation; }
            set { m_lstWorkingSimulation = value; }
        }

        //property to access the Cache Singleton Class.
        public static Cache GetCache
        {
            get
            {
                if (m_GetCacheInstance == null)
                {
                    m_GetCacheInstance = new Cache();
                }
                return m_GetCacheInstance;
            }
            set { m_GetCacheInstance = value; }
        }



    

    }
}
