using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleQuizApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApplication.Tests
{
  
    public class MultipleChoiceQuestionTests
    {
        [TestMethod()]
        public void MultipleChoiceQuestionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getQuestionTest()
        {
            // Arrange
            String strQuestion = "Test Question";
           
            String[] possibleAnswers = { "Answer A", "Answer B", "Answer C", "Answer D" };
      
            Question q = new MultipleChoiceQuestion(strQuestion, possibleAnswers, 1);

            //Act
            String strResult = q.getQuestion();

            //Assert
            Assert.AreEqual(strQuestion, possibleAnswers);

        }

        [TestMethod()]
        public void getAnswerTest()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod()]
        public void checkAnswerTest()
        {
            Assert.Fail();
        }
    }
}