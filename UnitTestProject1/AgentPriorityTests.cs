using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace UnitTestProject1
{
    [TestClass]
    public class AgentPriorityTests
    {
        Calculation calculation = new Calculation();
        [TestMethod]
        public void GetPriorityForAgent_ValidParameters_ReturnsExpectedResult()
        {

            float age = 23;
            int experience = 2;
            int agentType = 2;
            int expectedPriority = 7;


            int priority = calculation.GetPriorityForAgent(age, experience, agentType);


            Assert.AreEqual(expectedPriority, priority);
        }

        [TestMethod]
        public void GetPriorityForAgent_ValidParameters_ReturnsExpectedResult2()
        {

            float age = 23;
            int experience = 1;
            int agentType = 2;
            int expectedPriority = 3;


            int priority = calculation.GetPriorityForAgent(age, experience, agentType);


            Assert.AreEqual(expectedPriority, priority);
        }



        [TestMethod]
        public void GetPriorityForAgent_AgentTypeNotSupported_ReturnsMinusOne()
        {

            float age = 35;
            int experience = 12;
            int agentType = 4;
            int expectedPriority = -1;


            int priority = calculation.GetPriorityForAgent(age, experience, agentType);


            Assert.AreEqual(expectedPriority, priority);
        }

        [TestMethod]
        public void GetPriorityForAgent_AgentTypeNotSupported_ReturnsMinusOne2()
        {

            float age = 35;
            int experience = 12;
            int agentType = 0;
            int expectedPriority = -1;


            int priority = calculation.GetPriorityForAgent(age, experience, agentType);


            Assert.AreEqual(expectedPriority, priority);
        }



        [TestMethod]
        public void GetPriorityForAgent_AgentIsYoung_ReturnsExpectedResult()
        {

            float age = 22;
            int experience = 1;
            int agentType = 1;
            int expectedPriority = 2;


            int priority = calculation.GetPriorityForAgent(age, experience, agentType);


            Assert.AreEqual(expectedPriority, priority);
        }

        [TestMethod]
        public void GetPriorityForAgent_AgentIsYoung_ReturnsExpectedResult2()
        {

            float age = 25;
            int experience = 1;
            int agentType = 1;
            int expectedPriority = 2;


            int priority = calculation.GetPriorityForAgent(age, experience, agentType);


            Assert.AreEqual(expectedPriority, priority);
        }

        [TestMethod]
        public void GetPriorityForAgent_AgentIsYoung_ReturnsExpectedResult5()
        {

            float age = 22;
            int experience = 2;
            int agentType = 3;
            int expectedPriority = 9;


            int priority = calculation.GetPriorityForAgent(age, experience, agentType);


            Assert.AreEqual(expectedPriority, priority);
        }

        [TestMethod]
        public void GetPriorityForAgent_AgentIsYoung_ReturnsExpectedResult6()
        {

            float age = 22;
            int experience = 3;
            int agentType = 3;
            int expectedPriority = 13;


            int priority = calculation.GetPriorityForAgent(age, experience, agentType);


            Assert.AreEqual(expectedPriority, priority);
        }

        public void GetPriorityForAgent_AgentIsYoung_ReturnsExpectedResult4()
        {

            float age = 22;
            int experience = 1;
            int agentType = 3;
            int expectedPriority = 4;


            int priority = calculation.GetPriorityForAgent(age, experience, agentType);


            Assert.AreEqual(expectedPriority, priority);
        }


        [TestMethod]
        public void GetPriorityForAgent_AgentIsYoung_ReturnsExpectedResult3()
        {

            float age = 27;
            int experience = 2;
            int agentType = 1;
            int expectedPriority = 4;


            int priority = calculation.GetPriorityForAgent(age, experience, agentType);


            Assert.AreEqual(expectedPriority, priority);
        }

        [TestMethod]
            public void GetPriorityForAgent_AgentIsYoung_ReturnsExpectedResult7()
        {

            float age = 27;
            int experience = 2;
            int agentType = 2;
            int expectedPriority = 6;


            int priority = calculation.GetPriorityForAgent(age, experience, agentType);


            Assert.AreEqual(expectedPriority, priority);
        }



    }
}
