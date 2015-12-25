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
        Tamagotchi GetTamagotchi(int TamaID);

        [OperationContract]
        int AddTamagotchi(string name);

        [OperationContract]
        List<Tamagotchi> GetAllTamagotchi();

        [OperationContract]
        TamaFlags GetFlag(int FlagID);

        [OperationContract]
        bool UpdateTamagochi(int TamaID);

        [OperationContract]
        bool FlipFlag(string name, int tamaID);

        [OperationContract]
        bool Eat(int TamaID);

        [OperationContract]
        bool Sleep(int TamaID);

        [OperationContract]
        bool Play(int TamaID);

        [OperationContract]
        bool Workout(int TamaID);

        [OperationContract]
        bool Hug(int TamaID);

        string GetStatus(int tamaID);


    }

}
