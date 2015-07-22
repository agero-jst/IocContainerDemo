using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackingEngine.Implementations;
using PackingEngine.Interfaces;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Bag _bag;
        private Box _box;
        private IBagFiller _bagFiller;
        private IBoxPacker _boxPacker;

        [TestInitialize]
        public void Setup()
        {
            _bag = A.Dummy<Bag>();
            A.CallTo(() => _bag.Name).Returns("A bag");

            _box = A.Dummy<Box>();
            A.CallTo(() => _box.Name).Returns("A box");


        }

        [TestMethod]
        public void TestMethod1()
        {
            _bagFiller = A.Fake<IBagFiller>();
            A.CallTo(() => _bagFiller.FillBag()).Returns(_bag);

            _boxPacker = A.Fake<IBoxPacker>();
            A.CallTo(() => _boxPacker.PackBox(A<Bag>.Ignored)).Returns(_box);

            var runner = new PackingRunner(_bagFiller, _boxPacker);
            var bundle = runner.PackBagInBox();
            Assert.AreEqual(bundle.Bag.Name, _bag.Name);
            Assert.AreEqual(bundle.Box.Name, _box.Name);
        }
    }
}
