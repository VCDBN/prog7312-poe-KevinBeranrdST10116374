using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10116374_PROG7312_POE
{
    internal class TreeNode<T> where T : IComparable<T>
    {
        
        public T Data { get; set; }

        // List for treenode/child
        public List<TreeNode<T>> Children { get; set; }
        public TreeNode() { }

        public TreeNode(T data)
        {
            Data = data;
            Children = new List<TreeNode<T>>();
        }

        // List used for child of the tree list
        public void AddChild(T Data)
        {
            this.Children.Add(new TreeNode<T>(Data));
        }
    }
}
