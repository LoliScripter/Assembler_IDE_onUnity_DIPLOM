﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Registers
{
        public static Register al = new Register(Regname.al, 1, DescriptBase.descr_AL);
        public static Register ah = new Register(Regname.ah, 1, DescriptBase.descr_AH);
        public static Register bl = new Register(Regname.bl, 1, DescriptBase.descr_BL);
        public static Register bh = new Register(Regname.bh, 1, DescriptBase.descr_BH);
        public static Register cl = new Register(Regname.cl, 1, DescriptBase.descr_CL);
        public static Register ch = new Register(Regname.ch, 1, DescriptBase.descr_CH);
        public static Register dl = new Register(Regname.dl, 1, DescriptBase.descr_DL);
        public static Register dh = new Register(Regname.dh, 1, DescriptBase.descr_DH);

        public static Register ax = new Register(Regname.ax, 2, DescriptBase.descr_AX);
        public static Register bx = new Register(Regname.bx, 2, DescriptBase.descr_BX);
        public static Register cx = new Register(Regname.cx, 2, DescriptBase.descr_CX);
        public static Register dx = new Register(Regname.dx, 2, DescriptBase.descr_DX);

        public static Register si = new Register(Regname.si, 2, DescriptBase.descr_SI);
        public static Register di = new Register(Regname.di, 2, DescriptBase.descr_DI);
        public static Register sp = new Register(Regname.sp, 2, DescriptBase.descr_SP);
        public static Register bp = new Register(Regname.ip, 2, DescriptBase.descr_IP);
        
        public static Register CS = new Register(Regname.CS, 2, DescriptBase.descr_CS);
        public static Register DS = new Register(Regname.DS, 2, DescriptBase.descr_DS);
        public static Register ES = new Register(Regname.ES, 2, DescriptBase.descr_ES);
        public static Register SS = new Register(Regname.SS, 2, DescriptBase.descr_SS);

}
