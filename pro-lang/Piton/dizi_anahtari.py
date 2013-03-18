#!-*- coding:utf-8 -*-

def dizi_anahtari(sayi_dizisi):
	
	sayi_liste = sayi_dizisi.split('-')
	bos_liste = []
	
	for rakam in sayi_liste:
		bos_liste.append(int(rakam))
	bos_liste.sort()
	
	uzunluk = len(bos_liste)
	print bos_liste
	toplam = 0
	
	for rakam in bos_liste:
		toplam += rakam
	
	if uzunluk % 2 == 0:
		b = (bos_liste[uzunluk / 2] + bos_liste[uzunluk / 2 - 1]) / 2
	else:
		b = bos_liste[uzunluk / 2]
		
	print (toplam / uzunluk) * b
 	
