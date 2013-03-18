from math import *

def  bisection(a, b, epsino, fonk):
    sayac = 0
    while(True):
        c = (a + b) / 2.0
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
