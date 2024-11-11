using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public class VectorPractice
    {
        public static double Find3dvectorDotProduct(int ax, int ay, int az,
                                                    int bx, int by, int bz)
        {

            double dotProduct = (ax * bx) + (ay * by) + (az * bz);
            return dotProduct;

        }
        public static (List<double>,List<double>) find3dvectorProjection(int ax, int ay, int az,
                                                    int bx, int by, int bz)
        {
            //let u = ax + ay + az and v = bx + by + bz
            double dotProduct = (ax * bx) + (ay * by) + (az * bz);
            double magnitudeU = Math.Sqrt((ax*ax) + (ay*ay) + (az*az));
            double magnitudeV = Math.Sqrt((bx*bx) + (by*by) + (bz*bz));

            List<double> projUuntoV = new List<double>
            {
                (dotProduct/ (magnitudeU * magnitudeU)) * ax,
                (dotProduct/ (magnitudeU * magnitudeU)) * ay,
                (dotProduct/ (magnitudeU * magnitudeU)) * az
            };

            List<double> projVuntoU = new List<double>
            {
                (dotProduct/ (magnitudeV * magnitudeV)) * bx,
                (dotProduct/ (magnitudeV * magnitudeV)) * by,
                (dotProduct/ (magnitudeV * magnitudeV)) * bz
            };
            return (projUuntoV, projVuntoU);



        }
    }
}
