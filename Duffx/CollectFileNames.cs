using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

// thanks to http://www.vbforums.com/showthread.php?t=359249

namespace Duffx
{
    public struct FileMetaData
    {
        public string Name;
        public string FolderPath;
        public bool IsDuplicate;
        private ArrayList Dupfiles;
        public double Size;
        public DateTime DateCreated;
        public string[] Words;

        public void AddDupFiles(FileMetaData dupFile)
        {
            if (null == Dupfiles )
            {
                Dupfiles = new ArrayList();
            }
            Dupfiles.Add(dupFile);
        }

        public ArrayList GetDupFiles()
        {
            return Dupfiles;
        }
    }
    class CollectFileNames
    {
        #region GetFiles (string Path)
        /// <summary>
        /// Gets all the files in the given folder path and all its subdirectories
        /// </summary>
        public static ArrayList GetFiles(string path)
        {
            ArrayList files = new ArrayList();
            getFiles(path, ref files);

            return files ;
        }
        private static void getFiles(string path, ref ArrayList files)
        {
            try
            {
                string[] folders = Directory.GetDirectories(path);
                for (int i = 0; i < folders.Length; i++)
                    getFiles(folders[i], ref files);


                string[] curFiles = Directory.GetFiles(path);

                foreach (string filePath in curFiles)
                {
                    //fileinfo
                    FileInfo fileinfo = new FileInfo(filePath);

                    FileMetaData fileMetaData = new FileMetaData();
                    fileMetaData.Name = fileinfo.Name;
                    fileMetaData.FolderPath = fileinfo.DirectoryName;
                    fileMetaData.IsDuplicate = false;
                    fileMetaData.Words = GetWords(fileinfo.Name);
                   
                    fileMetaData.Size = fileinfo.Length;
                    fileMetaData.DateCreated = fileinfo.CreationTime;

                    files.Add(fileMetaData);
                }

                //files.AddRange(curFiles);
            }
            catch
            { }
        }
        #endregion

        #region GetFiles (string path, string[] searchPatterns, bool includeSubFolders) +1 overload
        /// <summary>
        /// Gets all the files in the given folder path and all its subdirectories.
        /// </summary>
        /// <param name="searchPatterns">search patterns (ie, "*.exe")</param>
        public static string[] GetFiles(string path, string[] searchPatterns, bool includeSubFolders)
        {
            ArrayList files = new ArrayList();
            if (includeSubFolders)
            {
                getFiles(path, searchPatterns, ref files);
            }
            else
            {
                try
                {
                    for (int i = 0; i < searchPatterns.Length; i++)
                    {
                        string[] curFiles = Directory.GetFiles(path, searchPatterns[i]);
                        files.AddRange(curFiles);
                    }
                }
                catch
                { }
            }
            return (string[])files.ToArray(typeof(string));
        }


        /// <summary>
        /// Gets all the files in the given folder path and all its subdirectories.
        /// </summary>
        /// <param name="searchPattern">A series of valid search patterns, separated
        /// by ";". For example "*.jpg;prog*.exe"</param>
        public static string[] GetFiles(string path, string searchPattern, bool includeSubFolders)
        {
            string[] patterns = searchPattern.Split(';');
            return GetFiles(path, patterns, includeSubFolders);
        }

        private static void getFiles(string path, string[] searchPattern, ref ArrayList files)
        {
            // Try to get the current directory's folders
            try
            {
                string[] folders = Directory.GetDirectories(path);
                for (int i = 0; i < folders.Length; i++)
                    getFiles(folders[i], searchPattern, ref files);


                for (int i = 0; i < searchPattern.Length; i++)
                {
                    string[] curFiles = Directory.GetFiles(path, searchPattern[i]);
                    files.AddRange(curFiles);
                }
            }
            catch
            { }
        }
        #endregion

        private static string[] GetWords(string fileName)
        {
            fileName = fileName.Trim();
            //no punctuation charaacter should appear as leading or trailing characters
            fileName = fileName.Trim(new char[] { ',', ';', ':', '.', '_' });
            char[] chrFileName = fileName.ToCharArray();
            char[] buffer = new char[fileName.Length * 2];

            int bfrcnt = 0;
            buffer[bfrcnt] = chrFileName[0];

            for (int i = 1; i < fileName.Length; i++)
            {
                if (GetCharType(chrFileName[i]) == CharType.Other)
                {


                    if (GetCharType(chrFileName[i - 1]) == CharType.Digit && GetCharType(chrFileName[i + 1]) == CharType.Digit)
                    {
                        buffer[++bfrcnt] = chrFileName[i];
                    }
                    else
                    {
                        buffer[++bfrcnt] = '|';
                    }


                }
                else if (GetCharType(chrFileName[i - 1]) == CharType.Other)
                {
                    buffer[++bfrcnt] = chrFileName[i];
                }
                // if the curren char and the previous one are of same type then
                // its the part of the same word
                else if (GetCharType(chrFileName[i]) == GetCharType(chrFileName[i - 1]))
                {
                    buffer[++bfrcnt] = chrFileName[i];
                }
                else
                {
                    buffer[++bfrcnt] = '|';
                    buffer[++bfrcnt] = chrFileName[i];
                }

            }

            string retString = new string(buffer);
            retString = retString.Trim(new char[] { '\0' });
            return retString.Split(new char[] { '|' });
        }

        private enum CharType
        {
            Alphabet,
            Digit,
            Other
        }

        private static CharType GetCharType(char c)
        {
            CharType ret;

            if (char.IsLetter(c) == true)
            {
                ret = CharType.Alphabet;
            }
            else if (char.IsDigit(c) == true)
            {
                ret = CharType.Digit;
            }
            else
            {
                ret = CharType.Other;
            }

            return ret;
        }
    }
}
