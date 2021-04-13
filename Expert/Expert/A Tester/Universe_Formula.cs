using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Expert.A_Tester
{
    class Universe_Formula
    {
        public static string Find(string path, string fName, string chemin)
        {

            if (chemin == "")
            {
                foreach (string sDirectoryName in Directory.GetDirectories(path))
                {

                    foreach (string sFileName in Directory.GetFiles(sDirectoryName))
                    {
                        if (sFileName.Contains(fName))
                        {
                            chemin = sFileName;
                            return chemin;
                        }

                    }

                    if (sDirectoryName.Contains("\\"))
                    {
                        string tempo = sDirectoryName.Replace("\\", "/");

                        tempo = Find(tempo, fName, chemin);

                        if (tempo != "") return tempo;

                    }

                    else
                    {

                        string tempo = Find(sDirectoryName, fName, chemin);
                        if (tempo != "") return tempo;
                    }

                }


            }

            return chemin;

        }

    }
}
