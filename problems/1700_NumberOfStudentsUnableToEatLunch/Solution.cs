﻿namespace Quiz;

public class Solution {
    
    public int CountStudents(int[] students, int[] sandwiches) {
        var student_queue = new Queue<int>(students);
        var sandwich_queue = new Queue<int>(sandwiches);

        var iterations = 0;
        
        while (student_queue.TryDequeue(out int student) && sandwich_queue.TryPeek(out int sandwich)) {
            if (student == sandwich) {
                sandwich_queue.Dequeue();
                iterations = 0;
            } else {
                student_queue.Enqueue(student);
                iterations++;
            }

            if (iterations > sandwich_queue.Count) {
                break;
            }
        }

        return sandwich_queue.Count;
    }
}