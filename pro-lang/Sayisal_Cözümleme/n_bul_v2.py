# -*- coding: cp1254 -*-

times = 0
liste = []

import time

def bul(pay, payda, n=2):
    global times, liste, i, j
    t1 = time.clock()
    if pay >= payda:
        print "Lütfen basit kesir giriniz."
    else:
        if n > 1:
            for i in range(2, 1000, 1):
                if i * pay != payda:
                    j = (float(i) * payda) / (i * pay - payda)

                    if int(j) == j and j > 0  and i != j:
                        liste.append("1/" + str(int(j)))
                        return bul(1, i, n - 1)
                    
                    else:
                        for j in range(2, 1000, 1):
                            if(i * j * pay) != (payda * (i + j)):
                                z = (i * j * payda) / ((i * j * pay) - (payda * (i + j)))
                                if int(j) == j and j > 0 and z > 0 and int(z) == z and i != j and j != z and i != z:
                                    liste.append("1/" + str(int(z)))
                                    return bul(1, i, n - 1)

        else:
            liste.append("1/" + str(i))
            print " + ".join(liste[::-1])

    t2 = time.clock()
    times += t2 - t1
    times = 0
    liste = []

bul(5, 23, 10)
bul(1, 2, 2)
                    

