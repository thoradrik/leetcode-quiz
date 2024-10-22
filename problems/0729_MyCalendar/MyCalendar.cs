using System;

namespace Quiz {
    public class MyCalendar {

        public MyCalendar() {

        }

        private class Interval {

            public Interval(int start, int end, int count) {
                m_Start = start;
                m_End = end;
                m_Count = count;
            }

            private int m_Start;

            private int m_End;

            private int m_Count;

            private Interval m_L;

            private Interval m_R;

            private void Precede(Interval interval) {
                if (m_L == null) {
                    m_L = interval;
                    interval.m_R = this;
                } else if (m_L.m_End <= interval.m_Start) {
                    interval.m_L = m_L;
                    interval.m_R = this;
                    m_L.m_R = interval;
                    m_L = interval;
                } else {
                    m_L.Overlap(interval);
                }
            }

            private void Follow(Interval interval) {
                if (m_R == null) {
                    m_R = interval;
                    interval.m_L = this;
                } else if (interval.m_End <= m_R.m_Start) {
                    interval.m_L = this;
                    interval.m_R = m_R;
                    m_R.m_L = interval;
                    m_R = interval;
                } else {
                    m_R.Overlap(interval);
                }
            }

            private void Join(Interval interval) {
                if (interval.m_Start < m_Start) {
                    var before = new Interval(interval.m_Start, m_Start, interval.m_Count);

                    Precede(before);

                    interval = new Interval(m_Start, interval.m_End, interval.m_Count);
                }

                if (m_End < interval.m_End) {
                    var after = new Interval(m_End, interval.m_End, interval.m_Count);

                    Follow(after);

                    interval = new Interval(interval.m_Start, m_End, interval.m_Count);
                }

                if (m_Start < interval.m_Start) {
                    var before = new Interval(m_Start, interval.m_Start, m_Count);

                    before.m_L = m_L;
                    before.m_R = this;
                    if (m_L != null) {
                        m_L.m_R = before;
                    }
                    m_L = before;

                    m_Start = interval.m_Start;
                }

                if (interval.m_End < m_End) {
                    var after = new Interval(interval.m_End, m_End, m_Count);

                    after.m_L = this;
                    after.m_R = m_R;
                    if (m_R != null) {
                        m_R.m_L = after;
                    }
                    m_R = after;

                    m_End = interval.m_End;
                }

                m_Count += interval.m_Count;
            }

            public void Overlap(Interval interval) {
                if (interval.m_End <= m_Start) {
                    Precede(interval);
                } else if (interval.m_Start >= m_End) {
                    Follow(interval);
                } else {
                    Join(interval);
                }
            }

            public bool CheckOverlap(Interval interval, int threshold) {
                if (interval.m_End <= m_Start) {
                    if (m_L == null) {
                        return true;
                    } else if (m_L.m_End <= interval.m_Start) {
                        return true;
                    } else {
                        return m_L.CheckOverlap(interval, threshold);
                    }
                } else if (m_End <= interval.m_Start) {
                    if (m_R == null) {
                        return true;
                    } else if (interval.m_End <= m_R.m_Start) {
                        return true;
                    } else {
                        return m_R.CheckOverlap(interval, threshold);
                    }
                } else {
                    if (interval.m_Start < m_Start) {
                        var before = new Interval(interval.m_Start, m_Start, interval.m_Count);

                        if (!CheckOverlap(before, threshold)) {
                            return false;
                        }
                    }

                    if (m_End < interval.m_End) {
                        var after = new Interval(m_End, interval.m_End, interval.m_Count);

                        if (!CheckOverlap(after, threshold)) {
                            return false;
                        }
                    }

                    return m_Count + interval.m_Count < threshold;
                }
            }

            public void Print(bool process_before, bool process_after) {
                if (process_before) {
                    if (m_L != null) {
                        m_L.Print(true, false);
                    }
                }

                // Console.WriteLine("  {0} = {1}", this, m_Count);

                if (process_after) {
                    if (m_R != null) {
                        m_R.Print(false, true);
                    }
                }
            }

            public override string ToString() {
                return String.Format("[{0}, {1})", m_Start, m_End);
            }

        }

        private Interval m_Interval;

        public bool Book(int start, int end) {
            var interval = new Interval(start, end, 1);

            if (m_Interval == null) {
                m_Interval = interval;
            } else {
                if (!m_Interval.CheckOverlap(interval, 2)) {
                    return false;
                }

                m_Interval.Overlap(interval);

                m_Interval.Print(true, true);
            }

            return true;
        }

    }
}
