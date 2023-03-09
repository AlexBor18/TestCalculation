using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calcalution
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            double productkoeff;
            double materialkoeff;
            int square;
            int quntity;
            switch(productType)
            {
                case 1:
                    productkoeff = 1.1;
                    break;
                case 2:
                    productkoeff = 2.5;
                    break;
                case 3:
                    productkoeff = 8.43;
                    break;
                default:
                    return -1;
            }
            switch(materialType)
            {
                case 1:
                    materialkoeff = 1.003;
                    break;
                case 2:
                    materialkoeff = 1.0012;
                    break;
                default:
                    return -1;
            }

            try
            {
                return (int)Math.Ceiling(productkoeff * materialkoeff * count * width * length);
            }
            catch(Exception)
            {
                return -1;
            }
        }
    }
}
