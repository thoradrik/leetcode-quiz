using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        private class Envelope {

            public Envelope(int[] n) {
                m_Width = n[0];
                m_Height = n[1];
            }

            private int m_Width;

            private int m_Height;

            public override string ToString() {
                return String.Format("[{0}:{1}]", m_Width, m_Height);
            }

            public bool CanEnvelop(Envelope e) {
                return m_Width > e.m_Width && m_Height > e.m_Height;
            }
            
            public class Comparer : IComparer<Envelope> {

                public int Compare(Envelope x, Envelope y) {
                    if (ReferenceEquals(x, y)) return 0;
                    if (x.m_Width < y.m_Width && x.m_Height < y.m_Height) {
                        return -1;
                    } else if (x.m_Width > y.m_Width && x.m_Height > y.m_Height) {
                        return 1;
                    } else {
                        int x_square = x.m_Width * x.m_Height;
                        int y_square = y.m_Width * y.m_Height;
                        return x_square.CompareTo(y_square);
                    }
                }

            }

        }
        
        private Envelope[] m_ES;
        
        private int[] m_Maxes;

        private readonly Envelope.Comparer m_Comparer = new Envelope.Comparer();
        
        public int MaxEnvelopes(int[][] envelopes) {
            m_ES = Array.ConvertAll(envelopes, e => new Envelope(e));
            m_Maxes = new int[m_ES.Length];

            Array.Sort(m_ES, m_Comparer);

            int max_path = 0;
            
            for (int i = m_ES.Length - 1; i >= 0; i--) {
                int path = FindMaxPath(i);
                if (path > max_path) {
                    max_path = path;
                }
            }

            return max_path;
        }

        public int FindMaxPath(int e_i) {
            if (m_Maxes[e_i] > 0) {
                return m_Maxes[e_i];
            }
            
            int max_path = 0;
            
            for (int i = e_i + 1; i < m_ES.Length; i++) {
                if (m_ES[i].CanEnvelop(m_ES[e_i])) {
                    int path = FindMaxPath(i);    
                    if (path > max_path) {
                        max_path = path;
                    }
                }
            }

            int result = max_path + 1;
            
            m_Maxes[e_i] = result;
        
            return result;
        }

    }
}