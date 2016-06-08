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
            A.CallTo(() => _box.Bag.Name).Returns(_bag.Name);


        }

        [TestMethod]
        public void TestMethod1()
        {
            _bagFiller = A.Fake<IBagFiller>();
            A.CallTo(() => _bagFiller.FillBag()).Returns(_bag);

            _boxPacker = A.Fake<IBoxPacker>();
            A.CallTo(() => _boxPacker.PackBox(_bag)).Returns(_box);

            var runner = new PackingRunner(_bagFiller, _boxPacker);
            var box = runner.PackBagInBox();
            Assert.AreEqual(box.Bag.Name, _bag.Name);
            Assert.AreEqual(box.Name, _box.Name);
        }
    }
}
