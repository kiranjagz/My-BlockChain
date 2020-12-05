using BobCoin.Core.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BobCoin.Tests
{
    [TestFixture]
    public class TransactionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateTransactionTest()
        {
            var trx = new Transaction
            {
                Sender = "Kiran",
                Recipient = "Bobbi",
                Amount = 90,
                Fee = 0.0001
            };

            Assert.Multiple(() =>
            {
                Assert.That("Bobbi", Is.EqualTo(trx.Recipient));
                Assert.That("Kiran", Is.EqualTo(trx.Sender));
                Assert.That(90, Is.EqualTo(trx.Amount));
            });
        }

        [Test]
        public void TestListTransactionTest()
        {
            //create list of transactions
            var lsTrx = new List<Transaction>();

            //Create first transaction
            var trx1 = new Transaction
            {
                Sender = "Wizard",
                Recipient = "Merlin",
                Amount = 3.0,
                Fee = 0.3
            };

            //Create 2nd transaction
            var trx2 = new Transaction
            {
                Sender = "Jefff",
                Recipient = "Hefe",
                Amount = 2.5,
                Fee = 0.2
            };

            //Create 3nd transaction
            var trx3 = new Transaction
            {
                Sender = "David",
                Recipient = "Beckham",
                Amount = 1.5,
                Fee = 0.02
            };

            lsTrx.Add(trx1);
            lsTrx.Add(trx2);
            lsTrx.Add(trx3);

            //Test size of list
            Assert.That(3, Is.EqualTo(lsTrx.Count));
        }

        [Test]
        public void ListToBytesTest()
        {
            //Create list of transactions
            var lsTrx = new List<Transaction>();

            //Create first transaction
            var trx1 = new Transaction
            {
                Sender = "Johana",
                Recipient = "Merlin",
                Amount = 3.0,
                Fee = 0.3
            };

            //Create 2nd transaction
            var trx2 = new Transaction
            {
                Sender = "Budiawan",
                Recipient = "Norita",
                Amount = 2.5,
                Fee = 0.2
            };

            lsTrx.Add(trx1);
            lsTrx.Add(trx2);

            var transactionBytes = lsTrx.ToArray().ConvertToByte();

            Assert.That(transactionBytes, Is.Not.Empty);
        }
    }
}
