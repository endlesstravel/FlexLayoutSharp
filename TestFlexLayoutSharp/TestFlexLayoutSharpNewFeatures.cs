using FlexLayoutSharp;
using NUnit.Framework;

namespace TestFlexLayoutSharp
{
    [TestFixture]
    public class TestFlexLayoutSharpNewFeatures
    {
        [Test]
        public void TestJustifyContentRowSpaceBetween()
        {
            var root = Flex.CreateDefaultNode();
            root.StyleSetFlexDirection(FlexDirection.Row);
            root.StyleSetJustifyContent(Justify.SpaceBetween);
            root.StyleSetWidth(102);
            root.StyleSetHeight(102);

            var rootChild0 = Flex.CreateDefaultNode();
            rootChild0.StyleSetWidth(10);
            root.InsertChild(rootChild0, 0);

            var rootChild1 = Flex.CreateDefaultNode();
            rootChild1.StyleSetWidth(10);
            root.InsertChild(rootChild1, 1);

            var rootChild2 = Flex.CreateDefaultNode();
            rootChild2.StyleSetWidth(10);
            root.InsertChild(rootChild2, 2);
            Flex.CalculateLayout(root, float.NaN, float.NaN, Direction.LTR);

            Assert.AreEqual(0, root.LayoutGetLeft());
            Assert.AreEqual(0, root.LayoutGetTop());
            Assert.AreEqual(102, root.LayoutGetWidth());
            Assert.AreEqual(102, root.LayoutGetHeight());

            Assert.AreEqual(0, rootChild0.LayoutGetLeft());
            Assert.AreEqual(0, rootChild0.LayoutGetTop());
            Assert.AreEqual(10, rootChild0.LayoutGetWidth());
            Assert.AreEqual(102, rootChild0.LayoutGetHeight());

            Assert.AreEqual(46, rootChild1.LayoutGetLeft());
            Assert.AreEqual(0, rootChild1.LayoutGetTop());
            Assert.AreEqual(10, rootChild1.LayoutGetWidth());
            Assert.AreEqual(102, rootChild1.LayoutGetHeight());

            Assert.AreEqual(92, rootChild2.LayoutGetLeft());
            Assert.AreEqual(0, rootChild2.LayoutGetTop());
            Assert.AreEqual(10, rootChild2.LayoutGetWidth());
            Assert.AreEqual(102, rootChild2.LayoutGetHeight());

            Flex.CalculateLayout(root, float.NaN, float.NaN, Direction.RTL);

            Assert.AreEqual(0, root.LayoutGetLeft());
            Assert.AreEqual(0, root.LayoutGetTop());
            Assert.AreEqual(102, root.LayoutGetWidth());
            Assert.AreEqual(102, root.LayoutGetHeight());

            Assert.AreEqual(92, rootChild0.LayoutGetLeft());
            Assert.AreEqual(0, rootChild0.LayoutGetTop());
            Assert.AreEqual(10, rootChild0.LayoutGetWidth());
            Assert.AreEqual(102, rootChild0.LayoutGetHeight());

            Assert.AreEqual(46, rootChild1.LayoutGetLeft());
            Assert.AreEqual(0, rootChild1.LayoutGetTop());
            Assert.AreEqual(10, rootChild1.LayoutGetWidth());
            Assert.AreEqual(102, rootChild1.LayoutGetHeight());

            Assert.AreEqual(0, rootChild2.LayoutGetLeft());
            Assert.AreEqual(0, rootChild2.LayoutGetTop());
            Assert.AreEqual(10, rootChild2.LayoutGetWidth());
            Assert.AreEqual(102, rootChild2.LayoutGetHeight());
        }
    }
}