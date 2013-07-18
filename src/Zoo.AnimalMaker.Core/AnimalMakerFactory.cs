using Ninject;
using Ninject.Modules;
using Zoo.AnimalMaker.Core.Makers;
using Zoo.AnimalMaker.Core.Repositories;

namespace Zoo.AnimalMaker.Core {

    public class AnimalMakerFactory
    {

        private static IKernel kernel;

        static AnimalMakerFactory()
        {
            //Configures the ninject kernel with DI bindings
            kernel = new StandardKernel();
            kernel.Load(new RegisterModule());
        }

        /// <summary>
        /// Returns an instantiated object for the given type (interface)
        /// </summary>
        /// <typeparam name="T">Type to be instantiated</typeparam>
        /// <returns></returns>
        public static T GetInstanceOf<T>()
        {
            return kernel.Get<T>();
        }

    }

    internal class RegisterModule : NinjectModule
    {
        /// <summary>
        /// Load & configure Ninject DI bindings required for the solution.
        /// </summary>
        public override void Load() {

            //IMaker binding [ options: Maker|ReflectionAnimalMaker ]
            Bind<IAnimalMaker>().To<ReflectionAnimalMaker>();

            //IAnimalRepository binding [ options : DefaultRepository|XmlRepository ]
            Bind<IAnimalRepository>().To<XmlRepository>();
        }
    }


}
