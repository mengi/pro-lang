#!-*- codin:utf-8 -*-
def en_uzun_kelime(cumle):
    kelimeler=cumle.split()
    uzunluk=[]
    for kelime in kelimeler:
        uzunluk.append(len(kelime))
        x = uzunluk.index(max(uzunluk))
        y = uzunluk.index(min(uzunluk))
    print "en uzun kelime : ", kelimeler[x]
    print "en kisa kelime : ", kelimeler[y]
en_uzun_kelime("muhammet bugun ders calisacak")
