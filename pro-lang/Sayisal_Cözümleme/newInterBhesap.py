from math import *

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
