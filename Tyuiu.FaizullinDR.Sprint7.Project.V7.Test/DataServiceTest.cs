using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FaizullinDR.Sprint7.Project.V7.Lib;

namespace Tyuiu.FaizullinDR.Sprint7.Project.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestArrayStrEntrance()
        {
            
            string[,] DataTable =
            {
                {"feerf","fewwe","fewfe" },
                {"1","fewwe","fewfe" },
                {"2","fewwe","fewfe" },
                {"2","fewwe","fewfe" },
                {"4","fewwe","fewfe" },
                {"2","fewwe","fewfe" },
                {"4","fewwe","fewfe" },
            };
            string[] res = ds.ArrayStrEntrance(DataTable);
            string[] wait = { "1", "2", "4" };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestArraySumPeopleInEntrance()
        {
            string[,] DataTable =
           {
                {"feerf","fewwe","fewfe" },
                {"1","fewwe","fewfe" },
                {"2","fewwe","fewfe" },
                {"2","fewwe","fewfe" },
                {"4","fewwe","fewfe" },
                {"2","fewwe","fewfe" },
                {"4","fewwe","fewfe" },
            };
            object[,] DataTabl =
            {
                {"feerf","fewwe","fewfe" },
                {"1","fewwe","fewfe" },
                {"2","fewwe","fewfe" },
                {"2","fewwe","fewfe" },
                {"4","fewwe","fewfe" },
                {"2","fewwe","fewfe" },
                {"4","fewwe","fewfe" },
            };
            string[] Entrance = ds.ArrayStrEntrance(DataTable);

            int[] res = ds.ArraySumPeopleInEntrance(DataTabl, Entrance);
            int[] wait = { 1,3,2 };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestArrayCountBuyOrRent()
        {
            object[,] DataTabl =
            {
                {"feerf","fewwe","fewfe","пекп56п","пекп","пе5п","аренда" },
                {"2","fewwe","fewfe","пекп56п","пекп","пе5п","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","пекп","пе5п","покупка" },
                {"feerf","fewwe","fewfe","пекп56п","пекп","пе5п","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","пекп","пе5п","покупка" },
            };

            int[] res = ds.ArrayCountBuyOrRent(DataTabl);
            int[] wait = { 3,2 };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestArrayUseFlatAreaAndSumRooms()
        {
            object[,] DataTabl =
            {
                {"feerf","fewwe","fewfe","пекп56п","grg","gtrg","аренда" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","20","1","покупка" },
                {"feerf","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","89","5","покупка" },
            };

            int[] res = ds.ArrayUseFlatAreaAndSumRooms(DataTabl);
            int[] wait = { 209,10};

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestSortMin()
        {
            string[,] DataTabl =
            {
                {"feerf","fewwe","fewfe","пекп56п","grg","gtrg","аренда" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","20","1","покупка" },
                {"feerf","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","89","5","покупка" },
            };

            

            string[,] res = ds.SortMin(DataTabl, 4);
            string[,] wait =
            {
                { "feerf", "fewwe", "fewfe", "пекп56п", "grg", "gtrg", "аренда" },
                { "feerf","fewwe","fewfe","пекп56п","20","1","покупка" },
                { "2","fewwe","fewfe","пекп56п","50","2","аренда" },
                
                { "feerf","fewwe","fewfe","пекп56п","50","2","аренда" },
                { "feerf","fewwe","fewfe","пекп56п","89","5","покупка" },
            };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestSortMax()
        {
            string[,] DataTabl =
            {
                {"feerf","fewwe","fewfe","пекп56п","grg","gtrg","аренда" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","20","1","покупка" },
                {"feerf","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","89","5","покупка" },
            };



            string[,] res = ds.SortMax(DataTabl, 4);
            string[,] wait =
            {
                {"feerf","fewwe","fewfe","пекп56п","grg","gtrg","аренда" },
                 {"feerf","fewwe","fewfe","пекп56п","89","5","покупка" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","20","1","покупка" },
                
               
            };
            CollectionAssert.AreEqual(wait, res);
        }


        [TestMethod]
        public void TestSortBeginBuy()
        {
            string[,] DataTabl =
            {
                {"feerf","fewwe","fewfe","пекп56п","grg","gtrg","rweeg" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","20","1","покупка" },
                {"feerf","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","89","5","покупка" },
            };



            string[,] res = ds.SortBeginBuy(DataTabl, 6);
            string[,] wait =
            {
                {"feerf","fewwe","fewfe","пекп56п","grg","gtrg","rweeg" },
                {"feerf","fewwe","fewfe","пекп56п","20","1","покупка" },
                {"feerf","fewwe","fewfe","пекп56п","89","5","покупка" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                
                {"feerf","fewwe","fewfe","пекп56п","50","2","аренда" },
                

            };
            CollectionAssert.AreEqual(wait, res);
        }


        [TestMethod]
        public void TestSortBeginRent()
        {
            string[,] DataTabl =
            {
                {"feerf","fewwe","fewfe","пекп56п","grg","gtrg","rweeg" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","20","1","покупка" },
                {"feerf","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","89","5","покупка" },
            };



            string[,] res = ds.SortBeginRent(DataTabl, 6);
            string[,] wait =
            {
                {"feerf","fewwe","fewfe","пекп56п","grg","gtrg","rweeg" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                 {"feerf","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"feerf","fewwe","fewfe","пекп56п","20","1","покупка" },
               
                {"feerf","fewwe","fewfe","пекп56п","89","5","покупка" },


            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
