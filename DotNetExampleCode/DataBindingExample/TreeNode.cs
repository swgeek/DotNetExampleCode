using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingExample
{
    public class TreeNode
    {
        public string Name { get; set; }
        public ObservableCollection<TreeNode> SubTrees { get; set; }

        public TreeNode()
        {
            Name = "no name set";
            SubTrees = new ObservableCollection<TreeNode>();
        }

        public static TreeNode GetTestData()
        {
            TreeNode root = new TreeNode();
            root.Name = "RootNode";

            for (int i = 0; i < 5; i++)
            {
                TreeNode level1Node = new TreeNode();
                level1Node.Name = "Node_" + i.ToString();
                root.SubTrees.Add(level1Node);

                for (int j=0; j < 4; j++)
                {
                    string name = "Node_";
                    TreeNode level2Node = new TreeNode();
                    level2Node.Name = name + i.ToString() + "_" + j.ToString();
                    level1Node.SubTrees.Add(level2Node);
                }
            }
            return root;
        }
    }
}
