from math import *

def newton(Xo, epsino, fonk, turev ):
    sayac = 0
    Xn = Xo
    while(True):
        Xm = Xn - (fonk(Xn) / turev(Xn))
        h = abs(Xm - Xn)
        print "X%d = %s => X%d = %s X%d - X%d = %s" % (sayac, Xn, sayac + 1, Xm, sayac + 1, sayac, h)
        if (epsino > h):
            break
        else:
            Xn = Xm
            sayac += 1
