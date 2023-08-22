using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPSejeLMSP.Communications
{
    enum StructureLength
    {
        HEAD_LEN = 6,
        LEN_LEN = 5,
        CMD_LEN = 3,
        CKS_LEN = 4,
        FOOT_LEN = 5,                                                                // 4(Cks) + 1(@)
        MAX_DAT_LEN = 8192,                                                          // Largo maximo Data
        FIX_LEN = (HEAD_LEN + LEN_LEN + CMD_LEN + FOOT_LEN),
        LEN_POS = (HEAD_LEN),                                                        // Posición Largo en Mensaje
        CMD_POS = (HEAD_LEN + LEN_LEN),                                              // Posición Comando en Mensaje
        DAT_POS = (HEAD_LEN + LEN_LEN + CMD_LEN),                                    // Posición Data en Mensaje
        MIN_MSG_LEN = (HEAD_LEN + LEN_LEN + CMD_LEN + FOOT_LEN),                     // Largo Min Mensaje
        MAX_MSG_LEN = (HEAD_LEN + LEN_LEN + CMD_LEN + MAX_DAT_LEN + FOOT_LEN)        // Largo Max Mensaje
    }
}