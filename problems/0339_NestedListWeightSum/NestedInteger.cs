using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz {
    public class NestedInteger : IFormattable {

        private int? m_Value;

        public NestedInteger(int value) {
            m_Value = value;
        }

        public bool IsInteger() => m_Value.HasValue;

        public int GetInteger() => m_Value.Value;

        public void SetInteger(int value) => m_Value = value;

        private IList<NestedInteger> m_List;

        public NestedInteger(IList<NestedInteger> list) {
            m_List = list;
        }

        public IList<NestedInteger> GetList() => m_List;

        public void Add(NestedInteger ni) {
            if (m_List == null) {
                m_List = new List<NestedInteger>();
            }
            
            m_List.Add(ni);
        }

        public string ToString(string format, IFormatProvider format_provider) {
            if (m_Value.HasValue) {
                return m_Value.Value.ToString();
            } else {
                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                for (int index = 0; index < m_List.Count; index++) {
                    NestedInteger item = m_List[index];
                    if (index > 0) {
                        sb.Append(",");
                    }

                    sb.Append(item.ToString(format, format_provider));
                }

                sb.Append("]");
                return sb.ToString();
            }
        }

    }
}