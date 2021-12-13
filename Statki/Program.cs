using BattleShipConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace BattleShipConsole
{
class Program
{
static void Main(string[] args)
{

        bool pokazstatki = false;//pokazuje pozycje wrogie

        zasoby mzasoby = new zasoby();
        zasoby pzasoby = new zasoby();



        Dictionary<char, int> kordy = PopulateDictionary();
        naglowek();
        for (int h = 0; h < 19; h++)
        {
            Write(" ");
        }


        PrintMap(mzasoby.pozstrzalu, mzasoby, pzasoby, pokazstatki);
        
        int gra;
            for (gra = 1; gra < 101; gra++)
            {
                mzasoby.ZrobioneRuchy++;

                Position position = new Position();

                ForegroundColor = ConsoleColor.White;
                WriteLine("Podaj pozycje w zakresie (A-F 1-10).");
                string input = ReadLine();
                position = AnalyzeInput(input, kordy);

                if (position.x == -1 || position.y == -1)
                {
                    WriteLine("nieprawidłowe koordynaty!");
                    gra--;
                    continue;
                }

                if (mzasoby.pozstrzalu.Any(EFP => EFP.x == position.x && EFP.y == position.y))
                {
                    WriteLine("Juz tu strzeliles.");
                    gra--;
                    continue;
                }


                pzasoby.Fire();
