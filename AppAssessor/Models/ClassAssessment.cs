//-----------------------------------------Objext class for a single object of an assessed class--------------------------------
//-------------------------------------contains properties which are populated by the constructor-------------------------------
//------constructor receives a file name and iterates through all lines of the file to increment the respective accumulator-----
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAssessor.Models
{
    class ClassAssessment
    {
        public string className { get; set; }
        public int allLines { get; set; }
        public int comments { get; set; }
        public int whiteSpace { get; set; }
        public int references { get; set; }
        public int methods { get; set; }
        public int ave { get; set; }

        public ClassAssessment(string fileName)
        {
            className = fileName.Substring(fileName.LastIndexOf('\\') + 1);

            String[] lines = File.ReadAllLines(fileName);

            foreach (String line in lines)
            {
                allLines++;
                if (line.Contains("//"))
                {
                    comments++;
                }
                else
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        whiteSpace++;
                    }
                    else
                        if (line.Contains("using"))
                        {
                            references++;
                        }
                        else
                            if (line.Contains("void") || line.Contains("return"))
                            {
                                methods++;
                            }
            }
            averageLinesPerMethod();
        }

        //Method to get the average lines per method from the populated properties
        public void averageLinesPerMethod()
        {
            if (methods != 0)
            {
                ave = (allLines - comments - whiteSpace - references) / methods;
            }
            else
            {
                ave = 0;
            }
        }

        //ovverridden toString method to display in correct format in listViews
        public override string ToString()
        {
            return string.Format("{0} ({1})", className, ave);
        }

    }
}
