using System;
using System.Collections.Generic;
using System.Text;

namespace Expert.A_Tester
{
    class RecchercheMotif
    {
        public static int[] Solve(int imageWidth, int imageHeight, string[] image, int patternWidth, int patternHeight, string[] pattern)
        {
            int[] result = new int[2];
            int[,] img = new int[(int)Math.Sqrt(image.Length),(int)Math.Sqrt(image.Length)];
            int[,] pat = new int[(int)Math.Sqrt(pattern.Length),(int)Math.Sqrt(pattern.Length)];
            for (int i =0;i<Math.Sqrt(image.Length);i++)
            {
                for(int j=0;i<Math.Sqrt(image.Length);j++)
                {
                    img[i, j] = int.Parse(image[j]);
                }
            }

            for (int i = 0; i < Math.Sqrt(pattern.Length); i++)
            {
                for (int j = 0; i < Math.Sqrt(pattern.Length); j++)
                {
                    pat[i, j] = int.Parse(pattern[j]);
                }
            }


            if ((patternWidth >= 1) && (patternWidth <= 400) &&
                (patternHeight >= 1) && (patternHeight <= 400) &&
                (imageWidth >= 1) && (imageWidth <= 400) &&
                (imageHeight >= 1) && (imageHeight <= 400) &&
                (patternWidth <= imageWidth) && (patternHeight <= imageHeight)) {


                bool pattern_not_found, pattern_is_matching;

                result = new int[] {  -1, -1 } ;
                pattern_not_found = true;

                for ( int img_x = 0; (pattern_not_found && (img_x <= (imageWidth - patternWidth))); img_x++) { // <- check if img_x == (imageWidth - patternWidth) or not
                    for (int img_y = 0; (pattern_not_found && (img_y <= (imageHeight - patternHeight))); img_y++) { // <- check if img_y == (imageHeight - patternHeight) or not
                        pattern_is_matching = true;
    

                    for (int pattern_x = 0; (pattern_is_matching && (pattern_x < patternWidth)); pattern_x++) {
                            for (int pattern_y = 0; (pattern_is_matching && (pattern_y < patternHeight)); pattern_y++) {
                                if (img[(img_x + pattern_x), (img_y + pattern_y)] != pat[pattern_x, pattern_y]) {
                                    pattern_is_matching = false;
                                }
                            }
                        }

                        if (pattern_is_matching) {
                            pattern_not_found = false;
                            result = new int[] { img_x, img_y };
                        }
                    }
                }
            } else {
                //  XXX Error : preconditions
                //  result = ???
            }

            return result;
        }
    //Répondre avec citation Répondre avec citation   0  0


    }
}
