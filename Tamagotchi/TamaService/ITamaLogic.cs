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
        Tamagotchi GetTamagotchi(int value);

        [OperationContract]
        int AddTamagotchi(string name);

        [OperationContract]
        List<Tamagotchi> GetAllTamagotchi();

        [OperationContract]
        TamaFlags GetFlag(int value);

        [OperationContract]
        bool UpdateTamagochi(int value);

        [OperationContract]
        bool FlipFlag(string name, int tamaID);

        [OperationContract]
        bool Eat(Tamagotchi tama);

        [OperationContract]
        bool Sleep(Tamagotchi tama);

        [OperationContract]
        bool Play(Tamagotchi tama);

        [OperationContract]
        bool Workout(Tamagotchi tama);

        [OperationContract]
        bool Hug(Tamagotchi tama);


    }

}
