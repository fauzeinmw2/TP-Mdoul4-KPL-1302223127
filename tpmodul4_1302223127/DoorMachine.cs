using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302223127
{
    public enum DoorStateEnum { Terkunci, Terbuka }
    public enum DoorTriggerEnum { Buka_Pintu, Kunci_Pintu }
    public class DoorMachine
    {
        private class DoorTransition
        {
            public DoorStateEnum stateAwal;
            public DoorStateEnum stateAkhir;
            public DoorTriggerEnum trigger;
            public DoorTransition(DoorStateEnum stateAwal, DoorStateEnum stateAkhir, DoorTriggerEnum trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }
        }

        DoorTransition[] doorTransisi =
        {
            new DoorTransition(DoorStateEnum.Terkunci, DoorStateEnum.Terkunci, DoorTriggerEnum.Kunci_Pintu),
            new DoorTransition(DoorStateEnum.Terkunci, DoorStateEnum.Terbuka, DoorTriggerEnum.Buka_Pintu),
            new DoorTransition(DoorStateEnum.Terbuka, DoorStateEnum.Terkunci, DoorTriggerEnum.Kunci_Pintu),
            new DoorTransition(DoorStateEnum.Terbuka, DoorStateEnum.Terbuka, DoorTriggerEnum.Buka_Pintu)
        };

        public DoorStateEnum currentState = DoorStateEnum.Terkunci;

        public DoorStateEnum GetNextState(DoorStateEnum stateAwal, DoorTriggerEnum trigger)
        {
            DoorStateEnum stateAkhir = stateAwal;
            for (int i = 0; i < doorTransisi.Length; i++)
            {
                DoorTransition perubahan = doorTransisi[i];
                if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }

            return stateAkhir;
        }

        public void ActivateTrigger(DoorTriggerEnum trigger)
        {
            Console.Write("\n");

            if (currentState == DoorStateEnum.Terkunci && trigger == DoorTriggerEnum.Buka_Pintu)
            {
                Console.WriteLine("Membuka Pintu...");
            }
            else if (currentState == DoorStateEnum.Terbuka && trigger == DoorTriggerEnum.Kunci_Pintu)
            {
                Console.WriteLine("Mengunci Pintu...");
            }
           
            currentState = GetNextState(currentState, trigger);
            
            if (currentState == DoorStateEnum.Terkunci)
            {               
                Console.WriteLine("Pintu Terkunci");
            }
            else
            {               
                Console.WriteLine("Pintu Tidak Terkunci");
            }
        }
    }
}
