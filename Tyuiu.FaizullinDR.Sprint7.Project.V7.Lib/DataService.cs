﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path) // возврашает данные из excel
        {
            string[] str = File.ReadAllLines(path);

            int columns = str[0].Split(';').Length;
            int rows = str.Length;
            
            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < strArr.Length; c++)
                {
                    matrix[i, c] = strArr[c];
                }
            }
            return matrix;
        }
        public object[,] DataTable(string path)
        {
            path = @"C:\Project\Домоуправление.csv";
            string[] strLines = File.ReadAllLines(path);
            object[,] DataTable = new object[strLines.Length, strLines[0].Split(';').Length];

            for (int i = 0; i < DataTable.GetLength(0); i++)
            {
                for (int j = 0; j < DataTable.GetLength(1); j++)
                {
                    DataTable[i, j] = strLines[i].Split(';')[j];
                }
            }
            return DataTable;
        }

        public string[] ArrayStrEntrance(object[,] DataTable)
        {
            int flag = 0;
            string strCountEntrance = "";
            for (int i = 1; i < DataTable.GetLength(0); i++)
            {
                flag = 0;
                for (int a = 1; a < i; a++)
                {
                    if (Convert.ToInt32(DataTable[a, 0]) == Convert.ToInt32(DataTable[i, 0]))
                        flag = 1;
                }
                if (flag == 0)
                    strCountEntrance += Convert.ToString(DataTable[i, 0]) + " ";
            } 
            string[] str = strCountEntrance.Split(' ');
            string[] res = new string[str.Length - 1];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = str[i];
            }


            return res;
        }

        public int[] ArraySumPeopleInEntrance(object[,] DataTable, string[] Entrance)
        {
            int[] res = new int[Entrance.Length];
            for (int i = 0; i < Entrance.Length; i++)
            {
                for (int j = 1; j < DataTable.GetLength(0); j++)
                {
                    if (Convert.ToInt32(Entrance[i]) == Convert.ToInt32(DataTable[j, 0]))
                        res[i] += 1;
                }
            }
            return res;
        }

        public int[] ArrayCountBuyOrRent(object[,] DataTable)
        {
            int[] res = new int[2];
            for (int i = 0; i < DataTable.GetLength(0); i++)
            {
                if (Convert.ToString(DataTable[i, 6]) == "аренда")
                    res[0] += 1;
                else if (Convert.ToString(DataTable[i, 6]) == "покупка")
                    res[1] += 1;
            }
            return res;
        }

        public int[] ArrayUseFlatAreaAndSumRooms(object[,] DataTable)
        {
            int[] res = new int[2];
            for (int i = 1; i < DataTable.GetLength(0); i++)
            {
                res[0] += Convert.ToInt32(DataTable[i,4]);
                res[1] += Convert.ToInt32(DataTable[i, 5]);
            }
            return res;
        }
    }
}
