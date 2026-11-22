using AufgabeStack;
using System.Collections;

namespace Test_StringStack
{
    [TestClass]
    public sealed class Test1
    {
        // Grenzfalltests mit Push
        [TestMethod]
        public void TestElementhinzufuegen()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Auto A");

            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual("Auto A", stack.Peek());
        }

        [TestMethod]
        public void TestVollerStack()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Auto A");
            stack.Push("Auto B");
            stack.Push("Auto C");


            Assert.AreEqual(2, stack.Count);
            Assert.AreEqual("Auto B", stack.Peek());
        }

        //Grenzfalltests mit Pop
        [TestMethod]

        public void TestOberstesElementEntfernen()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Auto A");
            stack.Push("Auto B");

            string? result = stack.Pop();

            Assert.AreEqual("Auto B", result);
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void TestPop_LeererStack()
        {
            StringStack stack = new StringStack(3);

            string? result = stack.Pop();

            Assert.IsNull(result);
            Assert.IsTrue(stack.IsEmpty);
        }

        //Grenzfalltests mit Peek
        [TestMethod]

        public void PeekOberstesElementEntfernen()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Auto A");
            stack.Push("Auto B");

            string? result = stack.Pop();

            Assert.AreEqual("Auto B", result);
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void PeekPop_LeererStack()
        {
            StringStack stack = new StringStack(3);

            string? result = stack.Pop();

            Assert.IsNull(result);
            Assert.IsTrue(stack.IsEmpty);
        }

        // Grenzfalltest mit Swap

        public void Swab_ObersteElementeVertauschen()
        {
            StringStack stack = new StringStack(2);
            stack.Push("Auto A");
            stack.Push("Auto B");
            stack.Push("Auto C");

            stack.Swap();

            Assert.AreEqual("Auto B", stack.Pop());
            Assert.AreEqual("Auto C", stack.Pop());
            Assert.AreEqual("Auto A", stack.Pop());
        }

        [TestMethod]
        public void Swap_NurEinElement()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Auto A");

            stack.Swap();

            Assert.AreEqual("Auto A", stack.Peek());
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void Clear_AlleElementeEntfernen()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Auto A");
            stack.Push("Auto B");

            stack-Clear();

            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual(0, stack.Count);
            Assert.IsNull(stack.Peek());
        }

        [TestMethod]
        public void IsEmpty_LeerUndNichtLeer()
        {
            StringStack stack = new StringStack(3);
            Assert.IsTrue(stack.IsEmpty)
        }

    }
}
