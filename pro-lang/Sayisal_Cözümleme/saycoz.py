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
def bisectionadim(a, b, epsino):
    return (log(a-b, 10) - log(2 * epsino, 10)) / log(2,10)


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

def newInterBhesap(Xler, fonklar, a, liste):
    if (a == len(Xler) - 1):
        print liste,  a
        Bo = (float(fonklar[a]) - liste[-1]) / (Xler[a] - Xler[a - 1])
        liste.append(Bo)
        newInterBhesap(Xler, fonklar, a-1, liste)
    

    else:
        print liste
        Bo = fonklar[a]
        liste.append(Bo)
        newInterBhesap(Xler, fonklar, a+1, liste)
