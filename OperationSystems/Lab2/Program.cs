using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace Lab2
{
    internal class Program
    {
        const string empty = "empty";
        const string bad = "bad";
        const string eof = "eof";

        public struct Pair
        {
            public object Key{ get; set; }
            public object Value { get; set; }

            public Pair(object key, object value) { Key = key; Value = value; }
        }

        static void Main(string[] args)
        {
            List<Pair> fileDescriptor = new List<Pair>() {new Pair("A", 2), new Pair("B", 14), new Pair("C", 22), new Pair("D", 8) };

            List<Pair> FAT = new List<Pair>()
            {
                new Pair(0, empty),   new Pair(1, empty),   new Pair(2, 3),       new Pair(3,4),        new Pair(4, 5),
                new Pair(5, 6),       new Pair(6, eof),     new Pair(7, empty),   new Pair(8, 9),       new Pair(9, 26),
                new Pair(10, bad),    new Pair(11, eof),    new Pair(12, empty),  new Pair(13, empty),  new Pair(14, 16),
                new Pair(15, bad),    new Pair(16, 26),     new Pair(17, empty),  new Pair(18, empty),  new Pair(19, empty),
                new Pair(20, empty),  new Pair(21, bad),    new Pair(22, 23),     new Pair(23, 26),     new Pair(24, empty),
                new Pair(25, empty),  new Pair(26, 27),     new Pair(27, 28),     new Pair(28, eof),    new Pair(29, empty),
                new Pair(30, empty),  new Pair(31, empty),  new Pair(32, eof),     new Pair(33, 32),     new Pair(34, 35),
                new Pair(35, 36),     new Pair(36, 37),     new Pair(37, 38),     new Pair(38, eof),    new Pair(39, empty),
                new Pair(40, empty),  new Pair(41, empty),  new Pair(42, empty),  new Pair(43, bad),    new Pair(44, empty),
                new Pair(45, empty),  new Pair(46, empty),  new Pair(47, empty),  new Pair(48, empty),  new Pair(49, empty)
            };

            List<List<Pair>> files = GetFiles(fileDescriptor, FAT);
            PrintBorder("All files", ConsoleColor.Green);
            for(int i = 0; i<fileDescriptor.Count; i++)
            {
                PrintFile(fileDescriptor[i].Key.ToString()!,files[i]);
                Console.WriteLine(Environment.NewLine);
            }

            PrintBorder("Lost files", ConsoleColor.Magenta);
            LostFiles(fileDescriptor, FAT);
            PrintBorder("Fixed lost files", ConsoleColor.Green);
            {
                foreach (Pair file in fileDescriptor)
                {
                    PrintFile(file.Key.ToString()!, GetSingleFile(file, FAT));
                }
                Console.WriteLine();
            }

            PrintBorder("Crossing files", ConsoleColor.Magenta);
            CrossingFiles(fileDescriptor, FAT);
            PrintBorder("Fixed crossing files", ConsoleColor.Green);
            {
                foreach(Pair file in fileDescriptor)
                {
                    PrintFile(file.Key.ToString()!, GetSingleFile(file, FAT));
                }
                Console.WriteLine();
            }

            PrintBorder("Bad clusters", ConsoleColor.Magenta);
            BadClusters(fileDescriptor, FAT);
        }

        static void PrintBorder(string msg, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine($"================================ {msg} ================================{Environment.NewLine}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static List<Pair> GetSingleFile(Pair index, List<Pair> FAT)
        {
            List<Pair> file = new List<Pair>();
            int i = Convert.ToInt32(index.Value);
            while (FAT[i].Value.ToString() != eof && FAT[i].Value.ToString() != empty && FAT[i].Value.ToString() != bad)
            {
                file.Add(FAT[i]);
                if (!int.TryParse(FAT[i].Value.ToString(), out i)) break;
            }             
            file.Add(FAT[i]);

            return file;
        }

        static List<List<Pair>> GetFiles(List<Pair> fileDescriptor, List<Pair> FAT)
        {
            List<List<Pair>> files = new List<List<Pair>>();

            foreach (Pair cluster in fileDescriptor)
                files.Add(GetSingleFile(cluster, FAT));            

            return files;
        }

        private static List<Pair> GetFileByItsEnd(Pair indexOfEnd, List<Pair> FAT)
        {
            int searchedCluster = Convert.ToInt32(indexOfEnd.Key);
            int buff = -1;

            while (true) 
            {
                for (int i = 0; i < FAT.Count; i++) 
                {
                    if (FAT[i].Value.ToString() != eof && FAT[i].Value.ToString() != bad && FAT[i].Value.ToString() != empty)
                    {
                        if (Convert.ToInt32(FAT[i].Value) == searchedCluster)
                        {
                            searchedCluster = Convert.ToInt32(FAT[i].Key);
                            break;
                        }
                    }
                }

                if (buff == searchedCluster)
                {
                    break;
                }

                buff = searchedCluster;
            }

            if (searchedCluster == Convert.ToInt32(indexOfEnd.Key))
            {
                return [indexOfEnd];
            }

            return GetSingleFile(new Pair("", FAT[searchedCluster].Key), FAT);
        }


        static void PrintFile(string fileName, List<Pair> file)
        {
            Console.WriteLine($"File \"{fileName}\":");
            for (int j = 0; j < file.Count - 1; j++)
                Console.Write($"{file[j].Key} -> {file[j].Value} | ");
            Console.Write($"{file.Last().Key} -> {file.Last().Value}");
            Console.WriteLine();
        }

        static void CrossingFiles(List<Pair> fileDescriptor, List<Pair> FAT)
        {
            List<List<Pair>> files = GetFiles(fileDescriptor, FAT);


            for (int i = 0; i < fileDescriptor.Count; i++)
            {
                PrintBorder($"File: {fileDescriptor[i].Key.ToString()}", ConsoleColor.White);

                bool isCrossing = false;
                for(int j = i + 1; j < fileDescriptor.Count; j++)
                {
                    if (files[i].Last().Key == files[j].Last().Key)
                    {
                        int firstIterator = files[i].Count - 1;
                        int secondIterator = files[j].Count - 1;

                        while(firstIterator !=0 && secondIterator !=0)
                        {
                            if (files[i][firstIterator].Key == files[j][secondIterator].Key && firstIterator == 0 && secondIterator == 0)
                            {
                                Console.WriteLine($"Files {fileDescriptor[i].Key} and {fileDescriptor[j].Key} are completely intersecting!");
                                Console.WriteLine(Environment.NewLine);
                                PrintFile(fileDescriptor[i].ToString()!, files[i]);
                                PrintFile(fileDescriptor[j].ToString()!, files[j]);

                                FixCrossingFiles(fileDescriptor, FAT, j, 0);
                                break;
                            }
                            else
                            {
                                if (files[i][firstIterator].Key != files[j][secondIterator].Key)
                                {
                                    Console.WriteLine($"Files {fileDescriptor[i].Key} and {fileDescriptor[j].Key} intersect at {files[i][firstIterator + 1].Key} cluster!");
                                    Console.WriteLine();
                                    Console.WriteLine($"File {fileDescriptor[i].Key} gets in cluster {files[i][firstIterator + 1].Key} from cluster {files[i][firstIterator].Key}.");
                                    Console.WriteLine($"File {fileDescriptor[j].Key} gets in cluster {files[j][secondIterator + 1].Key} from cluster {files[j][secondIterator].Key}.");
                                    Console.WriteLine();
                                    PrintFile(fileDescriptor[i].Key.ToString()!, files[i]);
                                    Console.WriteLine();
                                    PrintFile(fileDescriptor[j].Key.ToString()!, files[j]);
                                    Console.WriteLine();

                                    FixCrossingFiles(fileDescriptor, FAT, j, secondIterator);
                                    break;
                                }
                            }

                            firstIterator--;
                            secondIterator--;
                        }
                        isCrossing = true;
                    }
                }
                if (!isCrossing)
                {
                    Console.WriteLine($"File {fileDescriptor[i].Key} does not intersect with any other files!");
                    Console.WriteLine();
                }
            }

        }

        static void FixCrossingFiles(List<Pair> fileDescriptor, List<Pair> FAT, int fileIndex, int crossingIndex)
        {
            List<Pair> file = GetSingleFile(fileDescriptor[fileIndex], FAT);

            if (crossingIndex == 0)
            {
                for (int i = 0; i < FAT.Count; ++i)
                {
                    if (FAT[i].Value.ToString() == empty)
                    {
                        fileDescriptor[fileIndex] = new Pair(fileDescriptor[fileIndex].Key, i);

                        break;
                    }

                    if (i == FAT.Count - 1)
                    {
                        Console.WriteLine("Ошибка при решении проблемы пересечения. Диск заполнен");
                        return;
                    }
                }

                List<int> emptyClusters = new List<int>();

                for (int j = 0; j < FAT.Count; ++j)
                {
                    if (FAT[j].Value.ToString() == empty)
                    {
                        emptyClusters.Add(j);
                        if (emptyClusters.Count + 1 > file.Count - crossingIndex)
                        {
                            break;
                        }
                    }

                    if (j == FAT.Count - 1)
                    {
                        Console.WriteLine("Ошибка при решении проблемы пересечения. Диск заполнен");
                        return;
                    }
                }

                for (int i = 0; i < emptyClusters.Count - 1; ++i)
                {
                    int curClaster = emptyClusters[i];
                    int nextClaster = emptyClusters[i + 1];

                    FAT[curClaster] = new Pair(FAT[curClaster].Key, FAT[nextClaster].Value);
                }
                FAT[emptyClusters[emptyClusters.Count - 1]] = new Pair(emptyClusters[emptyClusters.Count - 1], eof);
            }
            else
            {
                List<int> emptyClasters = new List<int>();


                for (int j = 0; j < FAT.Count; ++j)
                {
                    if (FAT[j].Value.ToString() == empty)
                    {
                        emptyClasters.Add(j);
                        if (emptyClasters.Count + 2 > file.Count - crossingIndex)
                        {
                            break;
                        }
                    }

                    if (j == FAT.Count - 1)
                    {
                        Console.WriteLine("Ошибка при решении проблемы пересечения. Диск заполнен");
                        return;
                    }
                }

                FAT[Convert.ToInt32(file[crossingIndex].Key)] = new Pair(file[crossingIndex].Key, emptyClasters[0]);

                for (int i = 0; i < emptyClasters.Count - 1; ++i)
                {
                    int curClaster = emptyClasters[i];
                    int nextClaster = emptyClasters[i + 1];

                    FAT[curClaster] = new Pair(FAT[curClaster].Key, FAT[nextClaster].Key);
                }
                FAT[emptyClasters[emptyClasters.Count - 1]] = new Pair(emptyClasters[emptyClasters.Count - 1], eof);
            }
        }

        static void LostFiles(List<Pair> fileDescriptor, List<Pair> FAT)
        {
            List<List<Pair>> files = GetFiles(fileDescriptor, FAT);

            List<int> usedClusterIDs = new List<int>();
            List<int> usedEOFClusterIDs = new List<int>();

            List<int> lostClusterIDs = new List<int>();
            List<List<Pair>> lostFiles = new List<List<Pair>>();

            List<int> lostUnstructuredClusters = new List<int>();

            for (int i = 0; i < fileDescriptor.Count; i++)
            {
                for(int j = 0; j < files[i].Count; j++)
                {
                    usedClusterIDs.Add((int)files[i][j].Key);
                    if (files[i][j].Value.ToString() == eof)
                        usedEOFClusterIDs.Add((int)files[i][j].Key);
                    
                }
            }

            foreach(Pair cluster in FAT)
            {
                if((cluster.Value.ToString() == eof ) && !usedEOFClusterIDs.Contains((int)cluster.Key))
                {
                    List<Pair> lostFile = GetFileByItsEnd(cluster, FAT);
                    if (lostFile.Count > 0) 
                        lostFiles.Add(lostFile);
                }
            }

            foreach (List<Pair> lostFile in lostFiles)
            {
                foreach (Pair lostCluster in lostFile)
                    lostClusterIDs.Add((int)lostCluster.Key);
            }

            foreach(Pair cluster in FAT)
            {
                if(cluster.Value.ToString() != empty && !usedClusterIDs.Contains((int)cluster.Key) && !lostClusterIDs.Contains((int)cluster.Key))
                    lostUnstructuredClusters.Add((int)cluster.Key);
                
            }

            LostFileFixer(fileDescriptor, lostFiles);

            for(int i = 0; i < lostFiles.Count; i++)           
                PrintFile($"Lost file #{i + 1}", lostFiles[i]);

            Console.WriteLine($"{Environment.NewLine}Lost unstructured clusters:");
            for(int i = 0; i < lostUnstructuredClusters.Count; i++)
            {
                if(i + 1 == lostUnstructuredClusters.Count)
                    Console.Write($"{lostUnstructuredClusters[i]}");
                else
                    Console.Write($"{lostUnstructuredClusters[i]}, ");
            }

            Console.WriteLine(Environment.NewLine);
        }

        static void LostFileFixer(List<Pair> fileDescriptor, List<List<Pair>> lostFiles)
        {
            foreach(List<Pair> lostFile in lostFiles)
            {
                string newName = "";                
                int letterCode = 65;

                while(true)
                {
                    bool needChange = false;
                    newName += (char)letterCode;

                    foreach (Pair file in fileDescriptor)
                    {
                        if (file.Key != null && file.Key.ToString() == newName)
                        {
                            needChange = true;
                            break;
                        }
                    }

                    if (needChange)
                    {
                        newName = newName.TrimEnd((char)letterCode);
                        letterCode++;
                        if (letterCode > 90)
                        {
                            letterCode = 65;
                            newName += (char)letterCode;
                        }
                        continue;
                    }
                    else break;
                }

                fileDescriptor.Add(new Pair(newName, lostFile[0].Key));
                
            }
        }


        static void BadClusters(List<Pair> fileDescriptor, List<Pair> FAT)
        {
            List<Pair> badClusters = new List<Pair>();

            foreach(Pair cluster in FAT)
            {
                if(cluster.Value.ToString() == bad) badClusters.Add(cluster);
            }

            if (badClusters.Count == 0)
            {
                Console.WriteLine($"Corrupted files are not found{Environment.NewLine}");
                return;
            }

            Console.WriteLine($"Programm found {badClusters.Count} corrupted clusters:");
            foreach(Pair cluster in badClusters)            
                Console.WriteLine($"{cluster.Key} -> {cluster.Value}");
            


        }
    }
}
