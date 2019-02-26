using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace Project_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Your application should allow the end user to pass end a file path for output 
            * or guide them through generating the file.
            **/
            
            string filePath = Directory.GetCurrentDirectory();
            string stepBackOne = Directory.GetParent(filePath).ToString();
            string stepBackTwo = Directory.GetParent(filePath).ToString();
            string stepBackThree = Directory.GetParent(filePath).ToString();
            Console.WriteLine(stepBackThree);

            String[] arrayOfValues;
            //List<Program> listOfPlayers;

            string adjustedFilePath = $@"{stepBackThree}\Super_Bowl_Project.csv";
            Console.WriteLine(adjustedFilePath);

            if(File.Exists(adjustedFilePath)) 
            {

            FileStream aFile = new FileStream(adjustedFilePath, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(aFile);

            while(!read.EndOfStream) 
            {
                //Serialize the objects into the program
                arrayOfValues = read.ReadLine().Split(',');
                Console.WriteLine(arrayOfValues.Length);
                //listOfPlayers.Add(new Program(arrayOfValues[0], arrayOfValues[1], Int32.Parse(arrayOfValues[2]), arrayOfValues[3]));
            }

            read.Close();
            aFile.Close();

            //Creating an html from the file
            using (FileStream fs = new FileStream("test.htm", FileMode.Create)) 
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8)) 
                {
                    w.WriteLine(@"Super_Bowl_Project.csv");
                }
            }
            try
        {

             //Delete the file if it exists.
            {
                File.Delete(filePath);
            }
        }
            catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
            }
        }

    }

}
    


