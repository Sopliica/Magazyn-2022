﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Magazyn_2022.Controler.Login;

namespace Magazyn2022Testss.LoginControllerTests
{
    [TestFixture]
    public class AuthorisationTests
    {
        public int xd;
        private LoginControler loginControler;

        [SetUp]
        public void SetUp()
        {
            xd = 360;
            loginControler = new LoginControler();
        }

        [Test] 
        [TestCase(1)]
        [TestCase(90)]
        [TestCase(360)]
        public void VariableXd(int xd2)
        {
            
            xd2.Should().Be(360);
            xd2.Should().BeOfType(typeof(int));
            xd2.Should().NotBe(null);
        }

        [Test]
        [TestCase("xd")]
        [TestCase("xaxaxaxaxaxaxaxaxaxax")]
        [TestCase("21719578158917259")]
        [TestCase("@@@@@@@@@@@@@@@@@@@@@@@@@@@")]
        [TestCase(null)]

        public void IsInputInLoginAreaNotNull(string login)
        {
            login.Should().NotBe(null);
        }
        [Test]
        public void LoginMethodShouldLoginUserWithCorrectData()
        {
            string inputLogin = "PaKę";
            string inputPassword = "P@$$w0rd";
            string correctLogin = "PaKę";
            string correctPassword = "P@$$w0rd";
            var result = loginControler.LogIn(inputLogin, inputPassword);
            result.Should().NotBe(null);
            result.Login.Should().Be(correctLogin);
            result.Password.Should().Be(correctPassword);
        }
    }
}