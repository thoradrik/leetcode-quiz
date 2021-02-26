using System;
using System.Collections.Generic;

namespace Quiz {
    public class ZigzagIterator {

        private int m_Rank;
        
        private IList<int>[] m_Data;
        
        private int[] m_Counts;
        
        private int[] m_Ptr;
        
        private int m_Index;
        
        private int m_Current;
        
        private int m_Total;

        public ZigzagIterator(IList<int> v1, IList<int> v2) {
            m_Rank = 2;
            m_Data = new[] { v1, v2 };
            m_Counts = new[] { v1.Count, v2.Count };
            m_Total = v1.Count + v2.Count;
            m_Ptr = new int[m_Rank];
            m_Index = 0;
        }

        public bool HasNext() {
            return m_Current < m_Total;
        }

        public int Next() {
            if (m_Index >= m_Rank) {
                m_Index = 0;
            }
            
            while (m_Index < m_Rank && m_Ptr[m_Index] >= m_Counts[m_Index]) {
                m_Index++;
            }
            
            if (m_Index >= m_Rank) {
                m_Index = 0;
            }
            
            while (m_Index < m_Rank && m_Ptr[m_Index] >= m_Counts[m_Index]) {
                m_Index++;
            }
            
            if (m_Index >= m_Rank) {
                throw new NotImplementedException();
            }

            m_Current++;
            
            return m_Data[m_Index][m_Ptr[m_Index++]++];
        }

    }
}
