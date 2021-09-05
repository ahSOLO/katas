using System;
using System.Collections.Generic;

public class Program {
	// Do not edit the class below except
	// for the BreadthFirstSearch method.
	// Feel free to add new properties
	// and methods to the class.
	public class Node {
		public string name;
		public List<Node> children = new List<Node>();

		public Node(string name) {
			this.name = name;
		}

		public List<string> BreadthFirstSearch(List<string> array) {
			Queue<Node> nodeQ = new Queue<Node>();
			nodeQ.Enqueue(this);
			while (nodeQ.Count > 0)
			{
				var current = nodeQ.Dequeue();
				array.Add(current.name);
				foreach (Node child in current.children)
					nodeQ.Enqueue(child);
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
