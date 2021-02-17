namespace AlgorithmLib {
    public interface IBinaryTreeNode<T> : IBinaryTreeNode {

        new T Value { get; }

        new IBinaryTreeNode<T> Left { get; }

        new IBinaryTreeNode<T> Right { get; }

        object IBinaryTreeNode.Value => Value;

        IBinaryTreeNode IBinaryTreeNode.Left => Left;

        IBinaryTreeNode IBinaryTreeNode.Right => Right;

    }
}