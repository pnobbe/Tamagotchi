using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace TamaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITamaLogic" in both code and config file together.
    [ServiceContract]
    public interface ITamaLogic
    {

        [OperationContract]
        string GetTamagotchi(int value);

        [OperationContract]
        void AddTamagotchi(string name);

        [OperationContract]
        List<Tamagotchi> GetAllTamagotchi();

    }

}
