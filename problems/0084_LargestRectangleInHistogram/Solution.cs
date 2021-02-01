using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        private class Rect {

            public Rect(int height, int length) {
                Height = height;
                Length = length;
            }

            public int Height { get; }

            public int Length { get; set; }

            public int Area => Length * Height;

        } 
        
        public int LargestRectangleArea(int[] heights) {
            int max_area = 0;

            List<Rect> rects = null;

            for (int i = 0; i < heights.Length; i++) {
                int height = heights[i];

                int max_length = 0;

                List<Rect> new_rects = new List<Rect>();

                if (rects != null) {
                    foreach (Rect rect in rects) {
                        if (rect.Height < height) {
                            rect.Length += 1;
                            new_rects.Add(rect);
                        } else {
                            max_area = Math.Max(max_area, rect.Area);
                            max_length = Math.Max(max_length, rect.Length);
                        }
                    }
                }
                
                if (height > 0) {
                    if (max_length > 0) {
                        new_rects.Add(new Rect(height, max_length + 1));
                    } else {
                        new_rects.Add(new Rect(height, 1));
                    }
                }

                rects = new_rects;
            }

            if (rects != null) {
                foreach (Rect rect in rects) {
                    max_area = Math.Max(max_area, rect.Area);
                }
            }

            return max_area;
        }
        
    }
}