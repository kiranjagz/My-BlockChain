using BobCoin.Core.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BobCoin.Tests
{
    public class BlockUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNewBlock()
        {

            var lsTrx = new List<Transaction>();

            //Create first transaction
            var trx1 = new Transaction
            {
                Sender = "Bobbi",
                Recipient = "Jan",
                Amount = 3.0,
                Fee = 0.3
            };

            lsTrx.Add(trx1);

            var block = new Block(0, String.Empty.ConvertToBytes(), lsTrx.ToArray(), "Admin");

            Assert.That(0, Is.EqualTo(block.Height));
            Assert.That(string.Empty.ConvertToBytes(), Is.EqualTo(block.PrevHash));
            Assert.That("Admin", Is.EqualTo(block.Creator));
            Assert.That(lsTrx, Is.EqualTo(block.Transactions));
            Assert.That(32, Is.EqualTo(block.Hash.Length));
        }
    }
}