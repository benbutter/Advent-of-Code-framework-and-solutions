using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AOC_2022._23_04
{
    public class Solver23_04Ben : ISolver
    {
        public string GetSolution(StreamReader streamReader)
        {
            int overalltotal = 0;
            int cardTotal = 0;
            int cardNbrOfWinners = 0;
            while (!streamReader.EndOfStream)
            {
                cardTotal = 0;
                cardNbrOfWinners = 0;

                var fullLine = streamReader.ReadLine();

                var splitLines = fullLine.Split("|");

                var winningNumbers = splitLines[0].Split(" ");
                var cardNumbers = splitLines[1].Split(" ");

                int numberForTryParse = 0;

                foreach (var cardNumber in cardNumbers)
                {
                    if (Int32.TryParse(cardNumber, out numberForTryParse))
                    {
                        if (winningNumbers.Contains(cardNumber))
                        {
                            cardNbrOfWinners++;
                        }
                    }
                }

                //convert winners to points
                for (int i = 1; i <= cardNbrOfWinners; i++)
                {
                    if (i == 1)
                    {
                        cardTotal = 1;
                    }
                    else
                    {
                        cardTotal = cardTotal * 2;
                    }
                }

                overalltotal = overalltotal + cardTotal;
            }

            return overalltotal.ToString();
        }
    }
}
