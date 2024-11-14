namespace Assignment2_3_1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteFile(@"C:\TestFiles\Test.txt");
            ReadFile(@"C:\TestFiles\Test.txt");
        }

        static public void ReadFile(string path)
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                var sr = new StreamReader(path);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            //finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}
        }

        static public void WriteFile(string path)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(path);
                //Write a line of text
                sw.WriteLine("Hello World!!");
                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            //finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}
        }

    }
}
