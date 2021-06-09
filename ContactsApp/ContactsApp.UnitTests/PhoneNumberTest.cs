﻿using System;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    class PhoneNumberTests
    {
        [Test]
        public void PhoneNumber_CorrectPhoneNumber_ReturnSamePhoneNumber()
        {
            //Setup
            var sourcePhoneNumber = 79528074444;
            var phoneNumber = new PhoneNumber();
            var expectedPhoneNumber = sourcePhoneNumber;

            //Act
            phoneNumber.Number = sourcePhoneNumber;
            var actualPhoneNumber = phoneNumber.Number;

            //Assert
            Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
        }

        [Test]
        public void PhoneNumber_InсorrectPhoneNumber_ThrowsException()
        {
            //Setup
            var phoneNumber = new PhoneNumber();
            var sourceNumber = 1234656478978877;

            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>

                {
                    //Act
                    phoneNumber.Number = sourceNumber;
                }
            );
        }

        [Test]
        public void PhoneNumber_TooLongPhoneNumber_ThrowsException()
        {
            //Setup
            var phoneNumber = new PhoneNumber();
            var sourceNumber = 19123456789;

            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>

                {
                    //Act
                    phoneNumber.Number = sourceNumber;
                }
            );
        }
    }
}

