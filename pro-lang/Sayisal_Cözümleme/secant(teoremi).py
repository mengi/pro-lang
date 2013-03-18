
from math import *

def secant(Xo, Xb, epsino, fonk):
    sayac = 1
    Xn = Xo
    Xm = Xb
    while(True):
        Xm = (((Xn * fonk(Xm)) - (Xm * fonk(Xn))) / (fonk(Xm) - fonk(Xn)))
        h = abs(Xm - Xn)
        print "X%d = %s => X%d = %s X%d - X%d = %s" % (sayac, Xn, sayac + 1, Xm, sayac + 1, sayac, h)
        if (epsino > h):
            break
        else:
            Xn = Xm
            sayac += 1
