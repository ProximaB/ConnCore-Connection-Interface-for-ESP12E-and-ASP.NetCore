using ConnCore_ESP12E_Service.Providers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConnCore_ESP12E_Service.Providers
{
    public class MockESPProvider
    {
        public EspBoard espBoard { get; set; } = new EspBoard();

        public void GenerateRandomInput()
        {
            var rand = new Random();

            ConsoleStatusBoard("Before", espBoard);
            foreach (var pin in espBoard.Pins)
            {
                pin.State = rand.Next(0, 2) == 0 ? false : true;
            }
            ConsoleStatusBoard("After", espBoard);
        }

        public void ConsoleStatusBoard(string infoTxt, EspBoard board)
        {
            Console.WriteLine(infoTxt);
            foreach ( var pin in board.Pins )
            {
                Console.Write($"{board.Pins.IndexOf(pin)} => {pin.State}\n ");
            }
        }
    }
}
