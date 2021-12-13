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
