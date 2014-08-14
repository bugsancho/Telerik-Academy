﻿using System;

public static class FileNameManager
{
    public static string GetFileExtension(string fileName)
    {
        int indexOfLastDot = fileName.LastIndexOf(".");
        if (indexOfLastDot == -1)
        {
            throw new ArgumentException("The file name doesn't have a valid extension!");
        }

        string extension = fileName.Substring(indexOfLastDot + 1);
        return extension;
    }

    public static string GetFileNameWithoutExtension(string fileName)
    {
        int indexOfLastDot = fileName.LastIndexOf(".");
        if (indexOfLastDot == -1)
        {
            return fileName;
        }

        string extension = fileName.Substring(0, indexOfLastDot);
        return extension;
    }
}