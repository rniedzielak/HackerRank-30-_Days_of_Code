using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{

	static void levelOrder(Node root)
    {
  		//Write your code here
        if(root.left == null && root.right == null)
        {
            Console.WriteLine(root.data);
        }
        Console.Write(root.data + " ");
        List<Node> level_of_tree = new List<Node>();
        level_of_tree.Add(root);
        int pointer = 0;
        while(pointer < level_of_tree.Count)
        {
            if(level_of_tree.ElementAt(pointer).left != null)
            {
                level_of_tree.Add(level_of_tree.ElementAt(pointer).left);
                Console.Write(level_of_tree.ElementAt(pointer).left.data + " ");
            }
            if(level_of_tree.ElementAt(pointer).right != null) // this is no next but additional "if" and it is necessery to write "if not "else if"...
            {
                level_of_tree.Add(level_of_tree.ElementAt(pointer).right);
                Console.Write(level_of_tree.ElementAt(pointer).right.data + " ");
            }
            pointer++;
        }   
    }

	static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        levelOrder(root);
        
    }
}
