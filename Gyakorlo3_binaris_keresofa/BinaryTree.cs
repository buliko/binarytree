using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo3_binaris_keresofa
{
    class BinaryTree
    {

        private Node rootNode;

        public BinaryTree()
        {
            rootNode = null;
        }

        public void Add(int value)
        {
            if (rootNode == null)
            {
                rootNode = new Node(value, null);
            }
            else
            {
                Node currentNode = rootNode;
                Node parentNode = null;
                
                while(currentNode != null)
                {
                    if (value < currentNode.Key)
                    {
                        parentNode = currentNode;
                        currentNode = currentNode.LeftNode;
                    }
                    else if (value > currentNode.Key)
                    {
                        parentNode = currentNode;
                        currentNode = currentNode.RightNode;
                    }
                    else
                    {   
                        return;
                    }
                }

                currentNode = new Node(value, parentNode);

                if (value < parentNode.Key)
                {
                    parentNode.LeftNode = currentNode;
                }
                else
                {
                    parentNode.RightNode = currentNode;
                }
            }
        }


        public bool Contains(int value)
        {
            Node currentNode = rootNode;


            while (currentNode != null)
            {
                if (currentNode.Key == value)
                {
                    return true;
                }
                else if (value < currentNode.Key)
                {
                    currentNode = currentNode.LeftNode;
                }
                else
                {
                    currentNode = currentNode.RightNode;
                }
            }

            return false;

        }


        
        class Node{

            public Node ParentNode { get; set; }
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }

            public int Key { get; set; }

            public Node(int key, Node parent)
            {
                this.Key = key;
                this.ParentNode = parent;
            }

        }


    }
}
