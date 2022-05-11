using NUnit.Framework;
using System;

namespace MarsKataTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_Original_Position_Plus_FacingOrderL_Return_Position_O()
        {
            //ARRANGE   
            Point point = new Point(0,0);
            Rovert rovert = new Rovert(point,'N');

            //ACT
            rovert.Command('L');

            //ASSERT
            Rovert expected = new Rovert(point, 'O');
            Assert.AreEqual(rovert.coordenates, expected.coordenates);
        }


        [Test]
        public void Given_Wrong_Order()
        {
            //ARRANGE   
            Point point = new Point(0, 0);
            Rovert rovert = new Rovert(point, 'N');

            //ACT
            rovert.Command('X');

            //ASSERT
            Rovert expected = new Rovert(point, 'O');
            Assert.AreEqual(rovert.coordenates, expected.coordenates);
        }

        [Test]
        public void Given_Original_Position_Plus_FacingOrderR_Return_Position_E()
        {
            //ARRANGE   
            Point point = new Point(0, 0);
            Rovert rovert = new Rovert(point, 'S');
            Direction direction = new Direction('L');

            //ACT
            rovert.Command('R');

            //ASSERT
            Rovert expected = new Rovert(point, 'O');
            Assert.AreEqual(rovert.direction, expected.direction);
        }

        [Test]
        public void Given_Original_Rover_Plus_MovementOrderF_Return_Position()
        {
            //ARRANGE
            Point point = new Point(0,0);
            Rovert rovert = new Rovert(point, 'N');

            //ACT
            rovert.Command('F') ;

            //ASSERT
            Point pointExpected = new Point(0,1);
            Rovert expected = new Rovert(pointExpected, 'N');
            Assert.AreEqual(rovert.coordenates, expected.coordenates);
        }
        [Test]
        public void Given_Original_Rover_Plus_MovementOrderB_Return_Position()
        {
            //ARRANGE
            Point point = new Point(1, 2);
            Rovert rovert = new Rovert(point, 'E');

            //ACT
            rovert.Command('B');

            //ASSERT
            Point pointExpected = new Point(0, 2);
            Rovert expected = new Rovert(pointExpected, 'E');
            Assert.AreEqual(rovert.coordenates, expected.coordenates);
        }


        [Test]
        public void Given_Original_Rover_Plus_MovementOrderF_Return_Position_Sphere()
        {
            //ARRANGE
            Point point = new Point(5, 2);
            Rovert rovert = new Rovert(point, 'E');

            //ACT
            rovert.Command('F');

            //ASSERT
            Point pointExpected = new Point(0, 2);
            Rovert expected = new Rovert(pointExpected, 'E');
            Assert.AreEqual(rovert.coordenates, expected.coordenates);
        }


        [Test]
        public void Given_Original_Rover_Plus_MovementOrderB_Return_Position_Sphere()
        {
            //ARRANGE
            Point point = new Point(0, 3);
            Rovert rovert = new Rovert(point, 'N');

            //ACT
            rovert.Command('B');

            //ASSERT
            Point pointExpected = new Point(5, 3);
            Rovert expected = new Rovert(pointExpected, 'N');
            Assert.AreEqual(rovert.coordenates, expected.coordenates);
        }
    }
}