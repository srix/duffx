using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Duffx
{
    public delegate bool DelegateCompare(FileMetaData srcFile, FileMetaData tgtFile, int matches);

    class Compare
    {
        public ArrayList Run(ArrayList files, DelegateCompare dlgCompare)
        {
            ArrayList dupFiles = new ArrayList();
            bool hasDuplicate = false;

            int count = files.Count;
           while(count >1)//perform compare only if there is more than 1 file
            {
                int firstNode = 0;
                hasDuplicate = false;
                for (int j = firstNode + 1; j < count; j++)
                {

                    if (dlgCompare(((FileMetaData)files[firstNode]), ((FileMetaData)files[j]), 2) == true)
                    {
                        FileMetaData curFile = (FileMetaData)files[firstNode];
                        curFile.AddDupFiles((FileMetaData)files[j]);

                        files[firstNode] = curFile;

                        //remove duplicate file from search list
                        files.RemoveAt(j);

                        //Adjust count
                        count--;

                        //Adjust index j
                       // if (j == (i + 1))
                            j--;
                        hasDuplicate = true;
                    }
                }

                //Add the files with duplicates to dupfile arraylist
                if (true == hasDuplicate)
                {
                    dupFiles.Add(files[firstNode]);
                }

                //remove searched file from the list
                files.RemoveAt(firstNode);
                //Adjust count
                count--;
            }

            return dupFiles;
        }

        public bool CompareFileName(FileMetaData srcFile, FileMetaData tgtFile, int matches)
        {
            return srcFile.Name == tgtFile.Name;
        }

        public bool CompareSimilarFileName(FileMetaData srcFile, FileMetaData tgtFile, int matches)
        {
            string[] srcWords = srcFile.Words;
            string[] tgtWords = tgtFile.Words;

            int matchCnt = 0;

            int iterateCount = srcWords.Length < tgtWords.Length ? srcWords.Length : tgtWords.Length;
            for (int i = 0; i < iterateCount; i++)
            {
                if (srcWords[i] != tgtWords[i])
                {
                    break;
                }

                matchCnt++;                    
                if (matchCnt == matches)
                    break;
            }
            

            return matchCnt == matches;
        }

       
    }
}
