from math import *

def  regularfalsi(a, b, epsino, fonk):
    sayac = 0
    while(True):
        c = (((a * float(fonk(b))) - (b * fonk(a))) / (fonk(b) - float(fonk(a))))
        print "A%d = %s => B%d = %s A%d - B%d = %s" % (sayac, a, sayac , b, sayac , sayac, abs(a - b))
        if(abs(a - b) < epsino):
            return (a,b)
        if ((fonk(a) * fonk(c)) < 0):
            b = c
        elif((fonk(c) * fonk(b)) < 0):
            a = c
        else:
            if(not fonk(a)):
                return c
            else:
                return b
        sayac += 1
