using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestBSTinBinaryTree
{
    class LargestBST
    {
        public int FindlargestBST(Node root)
        {
            MinMax m = Largest(root);
            return m.Size;
        }
        private MinMax Largest(Node root)
        {
            if (root == null)
                return new MinMax();

            MinMax leftMinMax = Largest(root.left);
            MinMax rightMinMax = Largest(root.right);

            MinMax M = new MinMax();

            if(leftMinMax.IsBTS == false || rightMinMax.IsBTS == false || root.data < leftMinMax.Max || root.data >= rightMinMax.Min)
            {
                M.IsBTS = false;
                M.Size = Math.Max(leftMinMax.Size, rightMinMax.Size);
                return M;
            }

            M.Size = leftMinMax.Size + rightMinMax.Size + 1;
            M.IsBTS = true;
            M.Min = root.left != null ? root.left.data : root.data;
            M.Max = root.right != null ? root.right.data : root.data;

            return M;
        }

        
    }

    class MinMax
    {
        public int Min;
        public int Max;
        public int Size;
        public bool IsBTS;

        public MinMax()
        {
            this.Max = int.MinValue;
            this.Min = int.MaxValue;
            this.IsBTS = true;
            this.Size = 0;
        }
    }
}
