using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using BobCoin.Core.Logic;

namespace BobCoin.Tests
{
    [TestFixture]
    public class BlockChainTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateGenesisBlockTest()
        {
            var bc = new BlockChain();

            var genesisBlock = bc.Blocks[0];

            Assert.That(1, Is.EqualTo(bc.Blocks.Count));
        }

        [Test]
        public void TestGetLastBlockTest()
        {
            var bc = new BlockChain();

            var lastBlock = bc.GetLastBlock();
            Assert.That(1, Is.EqualTo(lastBlock.Height));
            Assert.That(string.Empty.ConvertToBytes(), Is.EqualTo(lastBlock.PrevHash));
            Assert.That(32, Is.EqualTo(lastBlock.Hash.Length));
        }

        [Test]
        public void TestAddBlockTest()
        {

            var bc = new BlockChain();

            var lsTrx = new List<Transaction>();

            //Create 1st transaction
            var trx1 = new Transaction
            {
                Sender = "Stevano",
                Recipient = "Valentino",
                Amount = 3.0,
                Fee = 0.3
            };

            lsTrx.Add(trx1);
            bc.AddBlock(lsTrx.ToArray());
            Assert.That(2, Is.EqualTo(bc.Blocks.Count));

            //Create 2nd transaction
            trx1 = new Transaction
            {
                Sender = "Budiawan",
                Recipient = "Norita",
                Amount = 2.5,
                Fee = 0.2
            };

            lsTrx = new List<Transaction>();
            lsTrx.Add(trx1);
            bc.AddBlock(lsTrx.ToArray());
            Assert.That(3, Is.EqualTo(bc.Blocks.Count));


        }
    }
}
