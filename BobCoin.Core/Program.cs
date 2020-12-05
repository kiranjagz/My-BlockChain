using BobCoin.Core.Logic;
using System;
using System.Collections.Generic;

namespace BobCoin.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make blockchain
            var bc = new BlockChain();

            //Create new transaction
            var trx1 = new Transaction
            {
                Sender = "Genesis Account",
                Recipient = "Ricardo",
                Amount = 300,
                Fee = 0.001
            };

            //Create new transaction
            var trx2 = new Transaction
            {
                Sender = "Genesis Account",
                Recipient = "Frodo",
                Amount = 250,
                Fee = 0.001
            };

            //Create new transaction
            var trx3 = new Transaction
            {
                Sender = "Ricardo",
                Recipient = "Madona",
                Amount = 20,
                Fee = 0.0001
            };

            //Create list of transactions
            var lsTrx = new List<Transaction>
            {
                trx1,
                trx2
            };

            var transactions = lsTrx.ToArray();
            bc.AddBlock(transactions);

            lsTrx = new List<Transaction>
            {
                trx3
            };

            transactions = lsTrx.ToArray();
            bc.AddBlock(transactions);

            //Print all blocks
            bc.PrintBlocks();

            try
            {
                //Check balance for each account account
                var balance = bc.GetBalance("Genesis Account");
                Console.WriteLine("Genesis Account balance: {0}", balance);

                balance = bc.GetBalance("Ricardo");
                Console.WriteLine("Ricardo balance: {0}", balance);

                balance = bc.GetBalance("Frodo");
                Console.WriteLine("Frodo  balance: {0}", balance);


                balance = bc.GetBalance("Madona");
                Console.WriteLine("Madona balance: {0}", balance);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred: {ex.Message}");
            }


            Console.ReadKey();
        }
    }
}
