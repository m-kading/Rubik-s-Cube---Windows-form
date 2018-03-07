using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubiks
{
    public class Cube
    {
        public int[,] cubeArr;


        public Cube()
        {
            // Initializing all positions in cube
            cubeArr = new int[,]
            {
                {0, 0, 0, 1, 1, 1, 0, 0, 0},
                {0, 0, 0, 1, 1, 1, 0, 0, 0},
                {0, 0, 0, 1, 1, 1, 0, 0, 0},
                {2, 2, 2, 3, 3, 3, 4, 4, 4},
                {2, 2, 2, 3, 3, 3, 4, 4, 4},
                {2, 2, 2, 3, 3, 3, 4, 4, 4},
                {0, 0, 0, 5, 5, 5, 0, 0, 0},
                {0, 0, 0, 5, 5, 5, 0, 0, 0},
                {0, 0, 0, 5, 5, 5, 0, 0, 0},
                {0, 0, 0, 6, 6, 6, 0, 0, 0},
                {0, 0, 0, 6, 6, 6, 0, 0, 0},
                {0, 0, 0, 6, 6, 6, 0, 0, 0}
            };
        }

        public void VRotate()
        {
            int[,] tempArr;
            tempArr = new int[,]
            {
                /*                                */{0, 0, 0, cubeArr[9, 3], cubeArr[9, 4], cubeArr[9, 5], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[10,3], cubeArr[10,4], cubeArr[10,5], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[11,3], cubeArr[11,4], cubeArr[11,5], 0, 0, 0},
                {cubeArr[5, 0], cubeArr[4, 0], cubeArr[3, 0], cubeArr[0, 3], cubeArr[0, 4], cubeArr[0, 5], cubeArr[3, 8], cubeArr[4, 8], cubeArr[5, 8]},
                {cubeArr[5, 1], cubeArr[4, 1], cubeArr[3, 1], cubeArr[1, 3], cubeArr[1, 4], cubeArr[1, 5], cubeArr[3, 7], cubeArr[4, 7], cubeArr[5, 7]},
                {cubeArr[5, 2], cubeArr[4, 2], cubeArr[3, 2], cubeArr[2, 3], cubeArr[2, 4], cubeArr[2, 5], cubeArr[3, 6], cubeArr[4, 6], cubeArr[5, 6]},
                /*                                */{0, 0, 0, cubeArr[3, 3], cubeArr[3, 4], cubeArr[3, 5], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[4, 3], cubeArr[4, 4], cubeArr[4, 5], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[5, 3], cubeArr[5, 4], cubeArr[5, 5], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[6, 3], cubeArr[6, 4], cubeArr[6, 5], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[7, 3], cubeArr[7, 4], cubeArr[7, 5], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[8, 3], cubeArr[8, 4], cubeArr[8, 5], 0, 0, 0}
            };

            cubeArr = tempArr;
        }
        public void HRotate()
        {
            int[,] tempArr;
            tempArr = new int[,]
            {
                /*                                */{0, 0, 0, cubeArr[0, 5], cubeArr[1, 5], cubeArr[2, 5], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[0, 4], cubeArr[1, 4], cubeArr[2, 4], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[0, 3], cubeArr[1, 3], cubeArr[2, 3], 0, 0, 0},
                {cubeArr[11,5], cubeArr[11,4], cubeArr[11,3], cubeArr[3, 0], cubeArr[3, 1], cubeArr[3, 2], cubeArr[3, 3], cubeArr[3, 4], cubeArr[3, 5]},
                {cubeArr[10,5], cubeArr[10,4], cubeArr[10,3], cubeArr[4, 0], cubeArr[4, 1], cubeArr[4, 2], cubeArr[4, 3], cubeArr[4, 4], cubeArr[4, 5]},
                {cubeArr[9, 5], cubeArr[9, 4], cubeArr[9, 3], cubeArr[5, 0], cubeArr[5, 1], cubeArr[5, 2], cubeArr[5, 3], cubeArr[5, 4], cubeArr[5, 5]},
                /*                                */{0, 0, 0, cubeArr[8, 3], cubeArr[7, 3], cubeArr[6, 3], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[8, 4], cubeArr[7, 4], cubeArr[6, 4], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[8, 5], cubeArr[7, 5], cubeArr[6, 5], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[5, 8], cubeArr[5, 7], cubeArr[5, 6], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[4, 8], cubeArr[4, 7], cubeArr[4, 6], 0, 0, 0},
                /*                                */{0, 0, 0, cubeArr[3, 8], cubeArr[3, 7], cubeArr[3, 6], 0, 0, 0}
            };

            cubeArr = tempArr;
        }

        public void FrontTurn()
        {
            int[,] tempArr;
            tempArr = new int[,]
            {
                                                    {0, 0, 0, cubeArr[0, 3], cubeArr[0, 4], cubeArr[0, 5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[1, 3], cubeArr[1, 4], cubeArr[1, 5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[5, 2], cubeArr[4, 2], cubeArr[3, 2], 0, 0, 0},
                {cubeArr[3, 0], cubeArr[3, 1], cubeArr[6, 3], cubeArr[5, 3], cubeArr[4, 3], cubeArr[3, 3], cubeArr[2, 3], cubeArr[3, 7], cubeArr[3, 8]},
                {cubeArr[4, 0], cubeArr[4, 1], cubeArr[6, 4], cubeArr[5, 4], cubeArr[4, 4], cubeArr[3, 4], cubeArr[2, 4], cubeArr[4, 7], cubeArr[4, 8]},
                {cubeArr[5, 0], cubeArr[5, 1], cubeArr[6, 5], cubeArr[5, 5], cubeArr[4, 5], cubeArr[3, 5], cubeArr[2, 5], cubeArr[5, 7], cubeArr[5, 8]},
                                                    {0, 0, 0, cubeArr[5, 6], cubeArr[4, 6], cubeArr[3, 6], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[7, 3], cubeArr[7, 4], cubeArr[7, 5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[8, 3], cubeArr[8, 4], cubeArr[8, 5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[9, 3], cubeArr[9, 4], cubeArr[9, 5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[10,3], cubeArr[10,4], cubeArr[10,5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[11,3], cubeArr[11,4], cubeArr[11,5], 0, 0, 0}
            };

            cubeArr = tempArr;
        }

        /* hello 
                                                    {0, 0, 0, cubeArr[0, 3], cubeArr[0, 4], cubeArr[0, 5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[1, 3], cubeArr[1, 4], cubeArr[1, 5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[2, 3], cubeArr[2, 4], cubeArr[2, 5], 0, 0, 0},
                {cubeArr[3, 0], cubeArr[3, 1], cubeArr[3, 2], cubeArr[3, 3], cubeArr[3, 4], cubeArr[3, 5], cubeArr[3, 6], cubeArr[3, 7], cubeArr[3, 8]},
                {cubeArr[4, 0], cubeArr[4, 1], cubeArr[4, 2], cubeArr[4, 3], cubeArr[4, 4], cubeArr[4, 5], cubeArr[4, 6], cubeArr[4, 7], cubeArr[4, 8]},
                {cubeArr[5, 0], cubeArr[5, 1], cubeArr[5, 2], cubeArr[5, 3], cubeArr[5, 4], cubeArr[5, 5], cubeArr[5, 6], cubeArr[5, 7], cubeArr[5, 8]},
                                                    {0, 0, 0, cubeArr[6, 3], cubeArr[6, 4], cubeArr[6, 5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[7, 3], cubeArr[7, 4], cubeArr[7, 5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[8, 3], cubeArr[8, 4], cubeArr[8, 5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[9, 3], cubeArr[9, 4], cubeArr[9, 5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[10,3], cubeArr[10,4], cubeArr[10,5], 0, 0, 0},
                                                    {0, 0, 0, cubeArr[11,3], cubeArr[11,4], cubeArr[11,5], 0, 0, 0}
       */
    }

}


