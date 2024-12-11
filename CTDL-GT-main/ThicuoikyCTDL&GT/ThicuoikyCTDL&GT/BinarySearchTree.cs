using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThicuoikyCTDL_GT
{
    public class NodeData
    {
        public string username { get; set; }
        public string password { get; set; }

        public string fullname { get; set; }
        public string identifier { get; set; }
        public string phoneNumber { get; set; }
    }

    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public NodeData Data { get; set; }
    }

    public static class BinaryTreeManager
    {
        public static Node Root { get; private set; }


        public static bool Insert(NodeData data)
        {
            Node before = null, after = Root;

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
            newNode.Data = data;

            if (Root == null)
            {
                Root = newNode;
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

        public static void TranverseInOrder(Node parent)
        {
            if(parent != null)
            {
                TranverseInOrder(parent.LeftNode);
                MessageBox.Show("username: " +  parent.Data.username 
                    + ", password: " + parent.Data.password
                    + ", fullname: " + parent.Data.fullname
                    + ", phone: " + parent.Data.phoneNumber
                    + ", identifier: " + parent.Data.identifier);
                TranverseInOrder(parent.RightNode);
            }
        }

        public static Node Find(string username)
        {
            return FindBaseOnParent(username, BinaryTreeManager.Root);
        }

        private static Node FindBaseOnParent(string username, Node parent)
        {
            if (parent != null)
            {
                MessageBox.Show("username: " + parent.Data.username
                    + ", password: " + parent.Data.password
                    + ", fullname: " + parent.Data.fullname
                    + ", phone: " + parent.Data.phoneNumber
                    + ", identifier: " + parent.Data.identifier);
                if (String.Compare(username, parent.Data.username) == 0) return parent;

                if (String.Compare(username, parent.Data.username) < 0)
                    return FindBaseOnParent(username, parent.LeftNode);
                else return FindBaseOnParent(username, parent.RightNode);
                //if (String.Compare(username, parent.Data.username) > 0)
                //    return FindBaseOnParent(username, parent.RightNode);
            }

            return null;
        }
    }

}
