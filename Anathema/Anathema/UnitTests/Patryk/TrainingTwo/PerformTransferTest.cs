﻿using System;
using System.Collections.Generic;
using Anathema.Patryk.TrainingTwo.Banks;
using Anathema.Patryk.TrainingTwo.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Patryk.TrainingTwo
{
    [TestClass]
    public class PerformTransferTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"..//..//Patryk//TrainingTwo//Files//BankTransfersToDo.txt";

            PerfromBankTransfers perfromBankTransfers = new PerfromBankTransfers();

            perfromBankTransfers.PerformTransfers(path);

        }
    }
}
