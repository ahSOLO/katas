using System;
using System.Collections.Generic;

public class Program {
	// Do not edit the class below except for the
	// PopulateSuffixTrieFrom and Contains methods.
	// Feel free to add new properties and methods
	// to the class.
	public class TrieNode {
		public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
	}

	public class SuffixTrie {
		public TrieNode root = new TrieNode();
		public char endSymbol = '*';

		public SuffixTrie(string str) {
			PopulateSuffixTrieFrom(str);
		}

		public void PopulateSuffixTrieFrom(string str) {
			TrieNode curNode = root;
            
            for (int startIdx = 0; startIdx < str.Length; startIdx++)
            {
                curNode = root;
                for (int curIdx = startIdx; curIdx <= str.Length; curIdx++)
                {
                    if (curIdx == str.Length)
                    {
                        curNode.Children.Add(endSymbol, null);
                        break;
                    }                    
                    if (curNode.Children.ContainsKey(str[curIdx]))
                    {
                        curNode = curNode.Children[str[curIdx]];
                        continue;
                    }
                    else
                    {
                        var newNode = new TrieNode();
                        curNode.Children.Add(str[curIdx], newNode);
                        curNode = newNode;
                    }
                }
            }
            
		}

		public bool Contains(string str) {
			int i = 0;
            TrieNode searchNode = root;
            while (searchNode.Children.ContainsKey(str[i]))
            {
                searchNode = searchNode.Children[str[i]];
                if (i < str.Length - 1)
                {
                    i++;
                }
                else if (i == str.Length - 1 && searchNode.Children.ContainsKey(endSymbol))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
		}
	}
}
