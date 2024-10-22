using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int[] AsteroidCollision(int[] asteroids) {
            var list = new List<int>(asteroids.Length);

            foreach (int asteroid in asteroids) {
                if (asteroid < 0) {
                    while (list.Count > 0) {
                        int prev = list[^1];
                        if (prev < 0) {
                            break;
                        }

                        if (prev < -asteroid) {
                            list.RemoveAt(list.Count - 1);
                        } else {
                            if (prev == -asteroid) {
                                list.RemoveAt(list.Count - 1);
                            }

                            goto next_asteroid;
                        }
                    }
                }

                list.Add(asteroid);

            next_asteroid:
                ;
            }

            return list.ToArray();
        }

        /*

        public int[] AsteroidCollision(int[] asteroids) {
            bool[] exploded = new bool[asteroids.Length];

            bool was_explodes;
            do {
                was_explodes = false;

                for (int i = 0; i < asteroids.Length; i++) {
                    if (exploded[i]) {
                        continue;
                    }

                    int i_mass = asteroids[i];
                    if (i_mass < 0) {
                        continue;
                    }

                    for (int j = i + 1; j < asteroids.Length; j++) {
                        if (exploded[j]) {
                            continue;
                        }

                        int j_mass = asteroids[j];
                        if (j_mass < 0) {
                            int d = i_mass + j_mass;
                            if (d == 0) {
                                was_explodes = true;
                                exploded[i] = true;
                                exploded[j] = true;
                                i = j;
                                break;
                            } else if (d < 0) {
                                was_explodes = true;
                                exploded[i] = true;
                                i = j - 1;
                                break;
                            } else {
                                was_explodes = true;
                                exploded[j] = true;
                            }
                        } else {
                            i = j - 1;
                            break;
                        }
                    }
                }
            } while (was_explodes);

            List<int> list = new List<int>();

            for (int index = 0; index < asteroids.Length; index++) {
                if (!exploded[index]) {
                    list.Add(asteroids[index]);
                }
            }

            return list.ToArray();
        }

        */
    }

}
