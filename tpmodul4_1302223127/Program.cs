using tpmodul4_1302223127;
using static tpmodul4_1302223127.KodePos;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===== 1). Table-Driven : Kode Pos =====");

        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode pos dari kelurahan " + KelurahanEnum.Batununggal + " adalah : " + kodePos.getKodePos(KelurahanEnum.Batununggal));
        Console.WriteLine("Kode pos dari kelurahan " + KelurahanEnum.Kujangsari + " adalah : " + kodePos.getKodePos(KelurahanEnum.Kujangsari));


        Console.WriteLine("\n===== 2). State-Based Construction =====");
        DoorMachine doorMachine = new DoorMachine();
        Console.WriteLine("State Awal : " + doorMachine.currentState);
        doorMachine.ActivateTrigger(DoorTriggerEnum.Buka_Pintu);
        doorMachine.ActivateTrigger(DoorTriggerEnum.Kunci_Pintu);
        doorMachine.ActivateTrigger(DoorTriggerEnum.Kunci_Pintu);
    }
}