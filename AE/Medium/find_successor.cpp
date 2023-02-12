using namespace std;
#include <iostream>

// This is an input class. Do not edit.
class BinaryTree {
public:
  int value;
  BinaryTree* left = nullptr;
  BinaryTree* right = nullptr;
  BinaryTree* parent = nullptr;

  BinaryTree(int value) { this->value = value; }
};

BinaryTree* GetLeftmostChild(BinaryTree* node)
{
  while (node->left != nullptr)
  {
    node = node->left;
  }
  return node;
}

BinaryTree* GetRightmostParent(BinaryTree* node)
{
  while (node->parent != nullptr && node == node->parent->right)
  {
    node = node->parent;
  }
  return node->parent;
}

BinaryTree* findSuccessor(BinaryTree* tree, BinaryTree* node) {
  if (node->right != nullptr)
  {
    return GetLeftmostChild(node->right);
  }
  else
  {
    return GetRightmostParent(node);
  }
}
