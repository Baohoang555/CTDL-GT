
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThicuoikyCTDL_GT
{
    public class NodeData
    {
        public NodeData(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string username;
        public string password;
    }

    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public NodeData Data { get; set; }
    }

    public class BinaryTree
    {
        Node Root { get; set; }

        public bool Insert(NodeData data)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (String.Compare(data.username, after.Data.username) > 0)
                {
                    after = after.RightNode;
                }
                else if (String.Compare(data.username, after.Data.username) < 0)
                {
                    after = after.LeftNode;
                }
                else
                {
                    return false;
                }

            }

            Node newNode = new Node();
            newNode.Data = new NodeData(data.username, data.password);

            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (string.Compare(data.username, before.Data.username) < 0)
                {
                    before.LeftNode = newNode;
                }
                else
                {
                    before.RightNode = newNode;
                }
            }

            return true;
        }

        public Node Find(string username)
        {
            return this.FindBaseOnParent(username, this.Root);
        }

        private Node FindBaseOnParent(string username, Node parent)
        {
            if (String.Compare(username, parent.Data.username) == 0) return parent;

            if (String.Compare(username, parent.Data.username) > 0)
                return this.FindBaseOnParent(username, parent.LeftNode);

            if (String.Compare(username, parent.Data.username) < 0)
                return this.FindBaseOnParent(username, parent.RightNode);

            return null;
        }
    }


    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePageForm());
        }
    }
}