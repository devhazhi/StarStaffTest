using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarStaffTest
{
    public static class GeometryCompute
    {
      public static double getTriangleArea(uint nSizeA_, uint nSizeB_, uint nSizeC_) {
         bool bCanComputing = false;
         if (nSizeA_ > nSizeB_ && nSizeA_ > nSizeC_)
            bCanComputing = nSizeA_ <= nSizeB_ + nSizeC_;
         else if (nSizeB_ > nSizeC_)
            bCanComputing = nSizeB_ <= nSizeA_ + nSizeC_;
         else
            bCanComputing = nSizeC_ <= nSizeA_ + nSizeB_;
         if (!bCanComputing)
            throw new ArgumentException("Стороны треугольника заданы неверно!");

         var ffPerimetr2 = (nSizeA_ + nSizeB_ + nSizeC_) / 2.0;
         return 
            Math.Sqrt(
               ffPerimetr2 
                  * (ffPerimetr2 - nSizeA_) 
                  * (ffPerimetr2 - nSizeB_) 
                  * (ffPerimetr2 - nSizeC_));
      }
    }
}
