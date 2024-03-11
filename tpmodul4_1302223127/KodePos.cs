using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302223127
{
    public class KodePos
    {
        public enum KelurahanEnum
        {
            Batununggal, Kujangsari, mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
        }

        public int getKodePos(KelurahanEnum kelurahan)
        {
            int[] kodepos = { 40266, 40287, 40267, 40265, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

            return kodepos[(int)kelurahan];
        }
    }
}
