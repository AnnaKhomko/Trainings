using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class TimeMeasurement
    {
        public List<ICollection> AllCollections { get; set; }
        public List<string> Result { get; set; }
        

        public TimeMeasurement()
        {
            this.AllCollections = new List<ICollection>();
            AllCollections.Add(new WorkWithDictionary());
            //AllCollections.Add(new WorkWithLinkedList());
            AllCollections.Add(new WorkWithList());
            AllCollections.Add(new WorkWithQueue());
            //AllCollections.Add(new WorkWithSortedDictionary());
            //AllCollections.Add(new WorkWithSortedSet());
            AllCollections.Add(new WorkWithStack());

            this.Result = new List<string>();
            
        }

        public void MesureTimeForAdding()
        {

            Result.Add($"\r\n{"Collection Name:".PadRight(30)} Time, ms");
            Result.Add($"\r\n\t\t Add {ResourceData.CountForAdd} elements\r\n");
            int countForAdd = int.Parse(ResourceData.CountForAdd);
            foreach (var elem in this.AllCollections)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                elem.AddElements(countForAdd);
                stopWatch.Stop();
                this.Result.Add($"{elem.ToString().PadRight(30)}  {stopWatch.ElapsedMilliseconds.ToString().PadRight(30)} \n");
            }
        }

        public void MesureTimeForReading()
        {
            Result.Add($"\r\n\t\t Read {ResourceData.CountForAdd} elements\r\n");
            foreach (var elem in this.AllCollections)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                elem.ReadElements();
                stopWatch.Stop();
                this.Result.Add($"{elem.ToString().PadRight(30)}  {stopWatch.ElapsedMilliseconds.ToString().PadRight(30)} \n");
            }
        }

        public void MesureTimeForFinding()
        {
            Result.Add($"\r\n\t\t Find {ResourceData.CountForFind} elements\r\n");
            int countForFind = int.Parse(ResourceData.CountForFind);
            foreach (var elem in this.AllCollections)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                elem.FindElement(countForFind);
                stopWatch.Stop();
                this.Result.Add($"{elem.ToString().PadRight(30)}  {stopWatch.ElapsedMilliseconds.ToString().PadRight(30)} \n");
            }
        }

        public void MesureTimeForRemoving()
        {
            Result.Add($"\r\n\t\t Delete {ResourceData.CountForDelete} elements\r\n");
            int countForDeelete = int.Parse(ResourceData.CountForDelete);
            foreach (var elem in this.AllCollections)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                elem.RemoveElements(countForDeelete);
                stopWatch.Stop();
                this.Result.Add($"{elem.ToString().PadRight(30)}  {stopWatch.ElapsedMilliseconds.ToString().PadRight(30)} \n");
            }
        }

        public void WriteToLogFile(string path)
        {
            using (var stream = File.Create(path))
            {
                stream.Close();
            }

            File.AppendAllLines(path, this.Result);

        }

    }
}
