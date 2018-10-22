using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elementary_Task_6;

namespace HappyTicketsUnitTest
{
    [TestClass]
    public class HappyTicketUnitTest
    {
        [TestMethod]
        [DataRow(-3, 2)]
        [DataRow(3, 1)]
        [ExpectedException(typeof(ArgumentException))]
        public void PiterMethodBuild_ExceptionThrow(int leftBorder, int rightBorder)
        {
            //Arrange

            //Act
            PiterMethod piterMethod = PiterMethod.PiterMethodInitialize(leftBorder, rightBorder);

            //Assert
        }

        [TestMethod]
        [DataRow(-3, 2)]
        [DataRow(3, 1)]
        [ExpectedException(typeof(ArgumentException))]
        public void MoscowMethod_ExceptionThrow(int leftBorder, int rightBorder)
        {
            //Arrange

            //Act
            MoscowMethod moscowMethod = MoscowMethod.MoscovMethodInitialize (leftBorder, rightBorder);

            //Assert
        }

        [TestMethod]
        [DataRow(1, 999999, 55251)]
        [DataRow(222222, 222222, 1)]
        public void PiterMethodCalculatingCaunt(int leftBorder, int rightBorder, int expectedCount)
        {
            //Arrange
            int count = 0;
            //Act
            PiterMethod piterMethod = PiterMethod.PiterMethodInitialize(leftBorder, rightBorder);
            foreach(Ticket t in piterMethod.GetTickets())
            {
                count++;
            }
            //Assert
            Assert.AreEqual(count, expectedCount);
        }


        [TestMethod]
        [DataRow(1, 999999, 55251)]
        [DataRow(222222, 222222, 1)]
        public void MoscowMethodCalculatingCaunt(int leftBorder, int rightBorder, int expectedCount)
        {
            //Arrange
            int count = 0;
            //Act
            MoscowMethod moscowMethod = MoscowMethod.MoscovMethodInitialize(leftBorder, rightBorder);
            foreach (Ticket t in moscowMethod.GetTickets())
            {
                count++;
            }
            //Assert
            Assert.AreEqual(count, expectedCount);
        }

    }
}
