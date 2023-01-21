using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleProject;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1TRUE()
        {

           // проверка, что знак водолей и год рождения - лошадь TRUE
            List<Program.DateGor> dateGors = new List<Program.DateGor>() {new Program.DateGor { Day = 1, Month = 2, Year = 2002} };
            List<string> strings = Program.HoroWriter(dateGors);
            string ss = strings[0];
            Assert.AreEqual("Ваш знак зодиака - Водолей;Лошадь;", ss);

            
        }

        [TestMethod]
        public void TestMethod1False()
        {

            // проверка, что знак водолей и год рождения - лошадь False
            List<Program.DateGor> dateGors = new List<Program.DateGor>() { new Program.DateGor { Day = 1, Month = 2, Year = 2002 } };
            List<string> strings = Program.HoroWriter(dateGors);
            string ss = strings[0];
            Assert.AreEqual("Ваш знак зодиака - Скорпион;Лошадь;", ss);


        }

        [TestMethod]
        public void TestMethod2()
        {

            // проверка, что знак Телец и год рождения - Крысы true
            List<Program.DateGor> dateGors = new List<Program.DateGor>() { new Program.DateGor { Day = 19, Month = 5, Year = 2020 } };
            List<string> strings = Program.HoroWriter(dateGors);
            string ss = strings[0];
            Assert.AreEqual("Ваш знак зодиака - Телец;Крыса;", ss);


        }
        [TestMethod]
        public void TestMethod2False ()
        {

            // проверка, что знак Телец и год рождения - Крысы false
            List<Program.DateGor> dateGors = new List<Program.DateGor>() { new Program.DateGor { Day = 19, Month = 5, Year = 2020 } };
            List<string> strings = Program.HoroWriter(dateGors);
            string ss = strings[0];
            Assert.AreEqual("Ваш знак зодиака - Телец;Крыса;", ss);


        }

        [TestMethod]
        public void TestMethod3True()
        {

            // проверка, что знак Весы и год рождения - Овца true
            List<Program.DateGor> dateGors = new List<Program.DateGor>() { new Program.DateGor { Day = 26, Month = 9, Year = 2003 } };
            List<string> strings = Program.HoroWriter(dateGors);
            string ss = strings[0];
            Assert.AreEqual("Ваш знак зодиака - Весы;Овца;", ss);


        }
        [TestMethod]
        public void TestMethod3False()
        {

            // проверка, что знак Весы и год Собака - лошадь FALSE
            List<Program.DateGor> dateGors = new List<Program.DateGor>() { new Program.DateGor { Day = 26, Month = 9, Year = 2003 } };
            List<string> strings = Program.HoroWriter(dateGors);
            string ss = strings[0];
            Assert.AreEqual("Ваш знак зодиака - Весы;Собака;", ss);

        }




        // блок проверки граничных значений даты месяца и года
        [TestMethod]
        public void TestMethodException()
        {

            // проверка на то, что метод при определении знака зодиака не дает исключений
            List<Program.DateGor> dateGors = new List<Program.DateGor>() { new Program.DateGor { Day = 1, Month = 2, Year = 2002 } };      
            Assert.ThrowsException<AssertFailedException>(()=>Assert.ThrowsException<SystemException>(()=>Program.HoroWriter(dateGors)));



        }

        [TestMethod]
        public void TestMethodException0()
        {

            // проверка на то, что метод при определении знака зодиака не дает исключений
            List<Program.DateGor> dateGors = new List<Program.DateGor>() { new Program.DateGor { Day = 0, Month = 0, Year = 0 } };
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Program.HoroWriter(dateGors)));



        }

        [TestMethod]
        public void TestMethodExceptionMinues()
        {

            // проверка на то, что метод при определении знака зодиака не дает исключений
            List<Program.DateGor> dateGors = new List<Program.DateGor>() { new Program.DateGor { Day = -1, Month = -1, Year = -1 } };
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Program.HoroWriter(dateGors)));



        }
        [TestMethod]
        public void TestMethodException1()
        {

            // проверка на то, что метод вызывает исключение (а он не вызывает)
            List<Program.DateGor> dateGors = new List<Program.DateGor>() { new Program.DateGor { Day = 0, Month = 0, Year = 0 } };
            Assert.ThrowsException<AssertFailedException>(() => Program.HoroWriter(dateGors));


        }
    }
}
