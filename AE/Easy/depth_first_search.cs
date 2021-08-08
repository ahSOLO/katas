using System;
using System.Collections.Generic;

public class Program {
	// Do not edit the class below except
	// for the DepthFirstSearch method.
	// Feel free to add new properties
	// and methods to the class.
	public class Node {
		public string name;
		public List<Node> children = new List<Node>();

		public Node(string name) {
			this.name = name;
		}

		public List<string> DepthFirstSearch(List<string> array) {
			return DepthFirstSearch(array, this);
		}
		
		public List<string> DepthFirstSearch(List<string> array, Node node) {
			array.Add(node.name);
			foreach (Node _node in node.children) {
				DepthFirstSearch(array, _node);
			}
			return array;
		}

		public Node AddChild(string name) {
			Node child = new Node(name);
			children.Add(child);
			return this;
		}
	}
}
