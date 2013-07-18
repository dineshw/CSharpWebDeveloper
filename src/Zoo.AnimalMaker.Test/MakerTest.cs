using NUnit.Framework;
using Zoo.AnimalMaker.Core;
using Zoo.AnimalMaker.Core.Animals;

namespace Zoo.AnimalMaker.Test
{
    [TestFixture]
    public class MakerTest
    {
        private IAnimalMaker _animalMaker;
        private IAnimalRepository _repository;

        [SetUp]
        public void SetUpAnimalLibrary()
        {
            //Instantiate an AnimalMaker using the AnimalMakerFactory.
            _animalMaker = AnimalMakerFactory.GetInstanceOf<IAnimalMaker>();

            //Instantiate an PropertyFeeder using the AnimalMakerFactory.
            _repository = AnimalMakerFactory.GetInstanceOf<IAnimalRepository>();
        }

        [TestCase()]
        public void Maker_AnimalMaker_Injected_Success()
        {
            Assert.IsNotNull(_animalMaker);
        }

        [TestCase()]
        public void Maker_AnimalRepository_Injected_Success() {
            Assert.IsNotNull(_repository);
        }

        [TestCase()]
        public void Maker_MakeADog_Success()
        {
            var dog = _animalMaker.Make("Dog", _repository);
            Assert.IsNotNull(dog);
            Assert.IsInstanceOf(typeof(Dog), dog);
            Assert.AreEqual(4, dog.NumberOfLegs);
        }

        [TestCase()]
        public void Maker_MakeACat_Success() {
            var cat = _animalMaker.Make("Cat", _repository);
            Assert.IsNotNull(cat);
            Assert.IsInstanceOf(typeof(Cat), cat);
            Assert.AreEqual(10, cat.DailyFeedCost);
        }

        [TestCase()]
        public void Maker_MakeALion_Success() {
            var lion = _animalMaker.Make("Lion", _repository);
            Assert.IsNotNull(lion);
            Assert.IsInstanceOf(typeof(Lion), lion);
            Assert.AreEqual(40, lion.DailyFeedCost);
        }

        [TestCase()]
        public void Maker_MakeADog_CaseInsensitive_Success() {
            var dog1 = _animalMaker.Make("dog", _repository);
            var dog2 = _animalMaker.Make("DOG", _repository);
            var dog3 = _animalMaker.Make("dOg", _repository);
            Assert.IsNotNull(dog1);
            Assert.IsNotNull(dog2);
            Assert.IsNotNull(dog3);
        }

        [TestCase()]
        public void Maker_MakeADragon_NotSuccess() {
            var dragon = _animalMaker.Make("Dragon", _repository);
            Assert.IsNull(dragon);
        }

        [TestCase()]
        public void Maker_MakeAnAnimal_EmptyName_NotSuccess() {
            var invisibleAnimal = _animalMaker.Make("", _repository);
            Assert.IsNull(invisibleAnimal);
        }
    }
}
