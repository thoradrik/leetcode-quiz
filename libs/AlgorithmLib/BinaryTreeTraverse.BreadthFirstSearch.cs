namespace AlgorithmLib;

public static class BinaryTreeTraverse {

    public static void BreadthFirstSearch<T>(T node, Func<T, T> get_left, Func<T, T> get_right, Action<int, T> output) where T : class {
        Queue<T> next = new Queue<T>();
        next.Enqueue(node);

        int level = 0;
        do {
            Queue<T> current = next;

            next = new Queue<T>();
                
            while (current.TryDequeue(out T item)) {
                output(level, item);

                T left = get_left(item);
                if (left != null) {
                    next.Enqueue(left);
                }

                T right = get_right(item);
                if (right != null) {
                    next.Enqueue(right);
                }
            }
        } while (next.Count > 0);
    } 

    public static void BreadthFirstSearch<T>(IBinaryTreeNode<T> node, Action<int, IBinaryTreeNode<T>> output) where T : IBinaryTreeNode<T> {
        Queue<IBinaryTreeNode<T>> next = new Queue<IBinaryTreeNode<T>>();
        next.Enqueue(node);

        int level = 0;
        do {
            Queue<IBinaryTreeNode<T>> current = next;

            next = new Queue<IBinaryTreeNode<T>>();
                
            while (current.TryDequeue(out IBinaryTreeNode<T> item)) {
                output(level, item);

                if (item.Left != null) {
                    next.Enqueue(item.Left);
                }

                if (item.Right != null) {
                    next.Enqueue(item.Right);
                }
            }
        } while (next.Count > 0);
    } 

    public static void BreadthFirstSearch<T>(IBinaryTreeNode<T> node, Action<int, T> output) where T : IBinaryTreeNode<T> {
        Queue<IBinaryTreeNode<T>> next = new Queue<IBinaryTreeNode<T>>();
        next.Enqueue(node);

        int level = 0;
        do {
            Queue<IBinaryTreeNode<T>> current = next;

            next = new Queue<IBinaryTreeNode<T>>();
                
            while (current.TryDequeue(out IBinaryTreeNode<T> item)) {
                output(level, item.Value);

                if (item.Left != null) {
                    next.Enqueue(item.Left);
                }

                if (item.Right != null) {
                    next.Enqueue(item.Right);
                }
            }
        } while (next.Count > 0);
    } 

}