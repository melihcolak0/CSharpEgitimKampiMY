using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik Üçgen

            //*
            //**
            //***
            //****
            //*****

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik Üçgen

            //*****
            //****
            //***
            //**
            //*

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i; j <= 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //---------------------------------

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yarım Baklava

            //*
            //**
            //***
            //****
            //*****
            //****
            //***
            //**
            //*

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava

            //   *
            //  ***
            // *****
            //*******
            //*******
            // *****
            //  ***
            //   *

            //int m = 1;

            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= m; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    m += 2;
            //    Console.WriteLine();
            //}

            //int m2 = 7;

            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= m2; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    m2 -= 2;
            //    Console.WriteLine();
            //}

            //   *
            //  ***
            // *****
            //*******
            // *****
            //  ***
            //   *

            //int m = 1;

            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= m; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    m += 2;
            //    Console.WriteLine();
            //}

            //int m2 = 5;

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= m2; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    m2 -= 2;
            //    Console.WriteLine();
            //}

            //------------------------------

            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int m2 = 5;

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= m2; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    m2 -= 2;
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                //boşluklar
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                //yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.ReadLine();
        }
    }
}
